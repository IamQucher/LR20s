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
using System.Windows.Shapes;

namespace WpfApp1.pages
{
    /// <summary>
    /// Логика взаимодействия для PageClient2.xaml
    /// </summary>
    public partial class PageClient2 : Page
    {
        private string userLogin;

        public PageClient2()
        {
            InitializeComponent();
            dg.ItemsSource = bd.Product.ToList();
     ;
        }
        masterEntities bd = new masterEntities();

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AuthorizationPage());
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

    }
}
