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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    /// 
 
    public partial class AuthorizationPage : Page
    {

        private masterEntities db = new masterEntities();
        public AuthorizationPage()
        {
            InitializeComponent();

        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {

            string login = logo.Text;



           


            string password = passwrd.Password;

            // Проверка учетных данных пользователя в базе данных
            var user = db.User.FirstOrDefault(u => u.UserLogin == login && u.UserPassword == password);

            if (user != null)
            {
                // Получение роли пользователя
                var role = db.Role.FirstOrDefault(r => r.RoleID == user.UserRole);

                if (role != null)
                {
                    // Переход на соответствующую страницу в зависимости от роли пользователя
                    if (role.RoleName == "Администратор")
                    {

                        AdministratorPage adminPage = new AdministratorPage();
                        adminPage.SetUserLogin(login);
                        NavigationService.Navigate(adminPage);




                    }
                    else if (role.RoleName == "Клиент" || role.RoleName == "Менеджер")
                    {
                        PageClient2 clienpage = new PageClient2();
                        clienpage.SetUserLogin(login);
                        NavigationService.Navigate(clienpage);




                    }
                }
                else
                {
                    MessageBox.Show("Ошибка: Роль пользователя не найдена.");
                }
            }
            else
            {


                MessageBox.Show("Ошибка: Неверные данные");
            }

        }
       
    }
}
