using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        private Educational StudentList = new Educational();
        ObservableCollection<Student> StudentCollection = new ObservableCollection<Student>();
        public Search()
        {
            InitializeComponent();
            CollectionBox.ItemsSource = StudentCollection;
        }

        //sends us back to home page
        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }

        //searches the list based on requested criteria
        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            StudentCollection.Clear();

            error.Visibility = Visibility.Hidden;


            if( FinderBox.Text == "Name" && NameBox.Text != NameBox.Tag.ToString())
            {
                var queryName = from student in Educational.Students
                                where student.FirstName + " " + student.LastName == NameBox.Text
                                select student;

                if (queryName.Count() != 0)
                {
                    foreach (Student student in queryName)
                    {
                        StudentCollection.Add(student);
                    }
                }
                else
                {
                    error.Visibility = Visibility.Visible;
                }
            }
            if (FinderBox.Text == "Student ID" && IDBox.Text != IDBox.Tag.ToString())
            {
                var queryName = from student in Educational.Students
                                where student.ID == IDBox.Text
                                select student;

                if (queryName.Count() != 0)
                {
                    foreach (Student student in queryName)
                    {
                        StudentCollection.Add(student);
                    }
                }
                else
                {
                    error.Visibility = Visibility.Visible;
                }


            }
            if (FinderBox.Text == "G.P.A" && GPALow.Text != GPALow.Tag.ToString() && GPAHigh.Text != GPAHigh.Tag.ToString())
            {
                var queryName = from student in Educational.Students
                                where student.GPA >= Convert.ToDouble(GPALow.Text) && student.GPA <= Convert.ToDouble(GPAHigh.Text)
                                select student;

                if (queryName.Count() != 0)
                {
                    foreach (Student student in queryName)
                    {
                        StudentCollection.Add(student);
                    }
                }
                else
                {
                    error.Visibility = Visibility.Visible;
                }
            }
            if(FinderBox.Text == "Disabilities")
            {
                var queryName = from student in Educational.Students
                                where student.LearningDisabilities != "none"
                                select student;

                if (queryName.Count() != 0)
                {
                    foreach (Student student in queryName)
                    {
                        StudentCollection.Add(student);
                    }
                }
                else
                {
                    error.Visibility = Visibility.Visible;
                }
            }
            if(FinderBox.Text == "Department" && DeptBox.Text != DeptBox.Tag.ToString())
            {
                if(string.IsNullOrWhiteSpace(GRBox.Text))
                {
                    var queryName = from student in Educational.Students
                                    where student.Department == DeptBox.Text
                                    select student;

                    if (queryName.Count() != 0)
                    {
                        foreach (Student student in queryName)
                        {
                            StudentCollection.Add(student);
                        }
                    }
                    else
                    {
                        error.Visibility = Visibility.Visible;
                    }
                }
                else
                {
                    var queryName = from student in Educational.Students
                                    where (student.Department == DeptBox.Text && student.Gender == GRBox.Text) || (student.Department == DeptBox.Text && student.Race == GRBox.Text)
                                    select student;

                    if (queryName.Count() != 0)
                    {
                        foreach (Student student in queryName)
                        {
                            StudentCollection.Add(student);
                        }
                    }
                    else
                    {
                        error.Visibility = Visibility.Visible;
                    }
                }
            }

            ClearAll();
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

        //resets default text on lost focus
        private void LoseFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = tb.Tag.ToString();
            }

        }

        //activates input boxes depending on combobox text
        private void FinderBox_MouseLeftButtonDown(object sender, EventArgs e)
        {
            //StudentCollection.Clear();

            if (FinderBox.Text == "Name")
            {
                NameBox.Visibility = Visibility.Visible;
                IDBox.Visibility = Visibility.Hidden;
                GPALow.Visibility = Visibility.Hidden;
                GPAHigh.Visibility = Visibility.Hidden;
                DeptBox.Visibility = Visibility.Hidden;
                
                GRBox.Visibility = Visibility.Hidden;
                
            }
            if (FinderBox.Text == "Student ID")
            {
                NameBox.Visibility = Visibility.Hidden;
                IDBox.Visibility = Visibility.Visible;
                GPALow.Visibility = Visibility.Hidden;
                GPAHigh.Visibility = Visibility.Hidden;
                DeptBox.Visibility = Visibility.Hidden;
                
                GRBox.Visibility = Visibility.Hidden;
                
            }
            if(FinderBox.Text == "G.P.A")
            {
                NameBox.Visibility = Visibility.Hidden;
                IDBox.Visibility = Visibility.Hidden;
                GPALow.Visibility = Visibility.Visible;
                GPAHigh.Visibility = Visibility.Visible;
                DeptBox.Visibility = Visibility.Hidden;
                
                GRBox.Visibility = Visibility.Hidden;
                
            }
            if(FinderBox.Text == "Department")
            {
                NameBox.Visibility = Visibility.Hidden;
                IDBox.Visibility = Visibility.Hidden;
                GPALow.Visibility = Visibility.Hidden;
                GPAHigh.Visibility = Visibility.Hidden;
                DeptBox.Visibility = Visibility.Visible;
                
                GRBox.Visibility = Visibility.Visible;
            }
            if(FinderBox.Text == "Disabilities")
            {
                NameBox.Visibility = Visibility.Hidden;
                IDBox.Visibility = Visibility.Hidden;
                GPALow.Visibility = Visibility.Hidden;
                GPAHigh.Visibility = Visibility.Hidden;
                DeptBox.Visibility = Visibility.Hidden;
                
                GRBox.Visibility = Visibility.Hidden;
               
            }
        }

     
        
        private void ClearAll()
        {
            NameBox.Clear();
            IDBox.Clear();
            DeptBox.Clear();
            GRBox.Clear();
            GPAHigh.Clear();
            GPALow.Clear();

        }
    }

}
