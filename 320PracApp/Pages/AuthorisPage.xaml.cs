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
using _320PracApp.DataBase;
using _320PracApp.Functions;

namespace _320PracApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorisPage.xaml
    /// </summary>
    public partial class AuthorisPage : Page
    {
        public static Employee empl;
        public AuthorisPage()
        {
            InitializeComponent();
        }

        private void btnGuest_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GuestPage());
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLog.Text.Trim();
            string password = tbPass.Password.Trim();
            empl = AuthorisationFunction.AuthorizationEmpl(login, password);
            if (empl != null) 
            {
                NavigationService.Navigate(new TeachMainPage());
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
        }
    }
}
