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

namespace Assignment4
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {

        public static List<Users> userList = new List<Users>()
        {
               new Users("John Adams", "jadams", "jadams@gmail.com", "123 Bull street", "1234432112344321", "0919", 702, "password1", "user"),
               new Users("George Washington", "gwashington", "gw123@gmail.com", "321 NotBull Street", "0987789009877890", "1222", 207, "password1", "seller"),

        };

        public static Users Loggedin_User;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Create_Account_Button_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("AccountCreation.xaml", UriKind.Relative));
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(userBox.Text) && !string.IsNullOrWhiteSpace(passBox.Password))
            {
                Users LoggedinUser = (from users in userList
                                      where users.Username == userBox.Text
                                      select users).SingleOrDefault();


                if (passBox.Password == LoggedinUser.Password)
                {

                    Loggedin_User = LoggedinUser;
                    
                        NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
                   
                }
                else
                {
                    MessageBox.Show("Password Incorrect!");
                }
            }
            else
            {
                MessageBox.Show("Login Information Incorrect");
            }
        }
    }
}
