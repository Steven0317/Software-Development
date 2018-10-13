using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
    /// Interaction logic for SchoolInfo.xaml
    /// </summary>
    public partial class SchoolInfo : Page
    {
        private Educational StudentList = new Educational();

        XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));

        public SchoolInfo()
        {
            InitializeComponent();
        }


        //clears default text on focus
        private void SelectAll(object sender, RoutedEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if (tb != null)
            {
                tb.Foreground = Brushes.Black;
                tb.BorderBrush = Brushes.Black;
                tb.Text = "";
                tb.SelectionStart = 1;
            }
        }


        //replace text on lost focus if null
        private void LoseFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = tb.Tag.ToString();
            }

        }


        // validates entries then adds to list
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (ValidateAll())
            {
                
                /* I'm 100000% positve there is a cleaner way to modify the last student added
                 * versus deleting it and readding it after grabbing the educational info
                 */
                Student tempStudent = Educational.Students.Last();

                Educational.Students.RemoveAt(Educational.Students.Count -1);

                tempStudent.GPA = Convert.ToDouble(GPA.Text);
                tempStudent.Department = Department.Text;
                tempStudent.EnrollmentYear = Convert.ToInt32(Enrollment.Text);
                tempStudent.GraduationDate = Convert.ToInt32(Graduation.Text);

                Educational.Students.Add(tempStudent);

                error.Visibility = Visibility.Hidden;

                string path = "student.xml";
                if (Educational.Students.Count == 0 && File.Exists(path))
                {
                    File.Delete(path);
                }
                else
                {
                    using (FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                    {
                        serializer.Serialize(filestream, Educational.Students);
                    }
                    MessageBox.Show("All students have written to file", "Success!!");
                }

                NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));

            }

        }

        private void WriteCommand(object sender, RoutedEventArgs e)
        {
            string path = "student.xml";
            if (Educational.Students.Count == 0 && File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                using (FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                {
                    serializer.Serialize(filestream, Educational.Students);
                }
                MessageBox.Show("All students have written to file", "Success!!");
            }
        }

        // giant bool statement to check all text boxes
        private bool ValidateAll()
        {
            bool enrollValid;
            bool gradValid;
            bool gpaValid;
            bool deptValid;

            int Enrollval = -1;
            if (!int.TryParse(Enrollment.Text, out Enrollval))
            {
                enrollValid = false;
                Enrollment.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                enrollValid = true;
                Enrollment.Background = Brushes.White;

            }
            int GradVal = -1;
            if (!int.TryParse(Graduation.Text, out GradVal))
            {
                gradValid = false;
                Graduation.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                gradValid = true;
                Graduation.Background = Brushes.White;

            }
            double gpaVal = -1;
            if (!double.TryParse(GPA.Text,out gpaVal))
            {
                gpaValid = false;
                GPA.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                gpaValid = true;
                GPA.Background = Brushes.White;
            }
            if (Department.SelectedItem == null)
            {
                deptValid = false;
                Department.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                deptValid = true;
                Department.Background = Brushes.White;
            }

            return ((enrollValid && gradValid && gpaValid && deptValid));
        }

    }
}
