using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Xml.Serialization;

namespace StudentApp
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        
        
        private Educational StudentList = new Educational();


       
        XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
        public HomePage()
        {
            InitializeComponent();

            try
            {
                ReadStudentsFromMemory();
            }
            catch (Exception ex)
            {
                Console.WriteLine("      Unable to read xml file      ", ex.InnerException);
                MessageBox.Show($"Unable to read xml file\nInner Exception:{ex.InnerException.Message}");
            }
        }

        private void ReadStudentsFromMemory()
        {
            string path = "student.xml";
            if (File.Exists(path))
            {
                using (FileStream readStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    Educational.Students = serializer.Deserialize(readStream) as List<Student>;
                }
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
