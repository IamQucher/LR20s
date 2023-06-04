using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApp1.pages
{
    /// <summary>
    /// Логика взаимодействия для AdministratorPage.xaml
    /// </summary>
    /// 

    public partial class AdministratorPage : Page
    {
        private string userLogin;


        private masterEntities db = new masterEntities();
        private bool isEditMode = false;
        private Product selectedProduct;
        public AdministratorPage()
        {
            InitializeComponent();
            dg.ItemsSource = db.Product.ToList();



        }
        public void SetUserLogin(string login)
        {
            userLogin = login;
            LoadUserData();

        }
        private void LoadUserData()
        {
            // Здесь выполняется поиск ФИО в базе данных на основе переданного логина
            string userFullName = GetUserFullNameFromDatabase(userLogin);
            // Отображение ФИО в интерфейсе
            fullNameLabel.Content = userFullName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 add = new Window1();
            add.Show();
            RefreshDataGrid();
        }
        public void RefreshDataGrid()
        {
            dg.ItemsSource = db.Product.ToList();
        }
        private void LoadData()
        {
            dg.ItemsSource = db.Product.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (dg.SelectedItem != null)
            {
                Product product = (Product)dg.SelectedItem;
                db.Product.Remove(product);
                db.SaveChanges();
                LoadData();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите товар для удаления.");
            }

        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (dg.SelectedItem != null)
            {
                selectedProduct = (Product)dg.SelectedItem;
                isEditMode = true;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите товар для редактирования.");
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            RefreshDataGrid();

        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AuthorizationPage());

        }
        private string GetUserFullNameFromDatabase(string login)
        {
            // Здесь выполняется запрос к базе данных для получения ФИО на основе логина
            // Вместо примера сделайте свой код для обращения к базе данных

            // Пример получения ФИО из базы данных
            using (masterEntities db = new masterEntities())
            {
                User user = db.User.FirstOrDefault(u => u.UserLogin == login);
                if (user != null)
                {
                    string fullName = $"{user.UserSurname} {user.UserName} {user.UserPatronymic}";
                    return fullName;
                }
            }
            return string.Empty;
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}