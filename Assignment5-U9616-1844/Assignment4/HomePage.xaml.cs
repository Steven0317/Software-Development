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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            HomePageVM homepage = new HomePageVM();
            InitializeComponent();
            welcome.Text += LoginPage.Loggedin_User.Name;
            DataContext = homepage;
        }

        private void LogoutEvent(object sender, RoutedEventArgs e)
        {
            LoginPage.Loggedin_User = null;
            NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow help = new HelpWindow();
            help.Show();
        }
    }
}
