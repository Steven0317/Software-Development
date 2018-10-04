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

namespace StudentApp
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        private Educational StudentList = new Educational();

        public HomePage()
        {
            InitializeComponent();

            if(!Educational.Students.Any())
            {
                SearchStudent.IsEnabled = false;
                DeleteStudent.IsEnabled = false;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Educational.xaml", UriKind.Relative));
        }

        private void Search_Button(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Search.xaml", UriKind.Relative));
        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Delete.xaml", UriKind.Relative));
        }
    }
}
