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
    /// Interaction logic for Educational.xaml
    /// </summary>
    public partial class Educational : Page
    {
        List<Student> ListOfStudents = new List<Student>();
        public Educational()
        {
            InitializeComponent();
            
        }

        private void SelectAll(object sender, RoutedEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if (tb != null)
            {
                tb.Foreground = Brushes.Black;
                tb.Text="";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(FNBox.Text == "" || FNBox.Text =="First Name")
            {
                FNBox.Text = "First Name";
                FNBox.Foreground = Brushes.Red;
                error.Foreground = Brushes.Red;
                error.Content = "Please fix all red fields";

            }
            if (LNBox.Text == "" || LNBox.Text == "Last Name")
            {
                LNBox.Text = "Last Name";
                LNBox.Foreground = Brushes.Red;
                error.Foreground = Brushes.Red;
                error.Content = "Please fix all red fields";
            }
            if (email.Text == "" || email.Text == "Email Address")
            {
                email.Text = "Email Address";
                email.Foreground = Brushes.Red;
                error.Foreground = Brushes.Red;
                error.Content = "Please fix all red fields";
            }
            if (Month.Text == "       Birth Month")
            {
                Month.Text = "       Birth Month";
                Month.Foreground = Brushes.Red;
                error.Foreground = Brushes.Red;
                error.Content = "Please fix all red fields";
            }
            if (day.Text == "" || day.Text == "Day")
            {
                day.Text = "Day";
                day.Foreground = Brushes.Red;
                error.Foreground = Brushes.Red;
                error.Content = "Please fix all red fields";
            }
            if (year.Text == "" || year.Text == "Year")
            {
                year.Text = "Year";
                year.Foreground = Brushes.Red;
                error.Foreground = Brushes.Red;
                error.Content = "Please fix all red fields";
            }
            if (gender.Text == "" || gender.Text == "Gender")
            {
                gender.Text = "Gender";
                gender.Foreground = Brushes.Red;
                error.Foreground = Brushes.Red;
                error.Content = "Please fix all red fields";
            }
            if (race.Text == "" || race.Text == "Race")
            {
                race.Text = "Race";
                race.Foreground = Brushes.Red;
                error.Foreground = Brushes.Red;
                error.Content = "Please fix all red fields";
            }
            if (uID.Text == "" || uID.Text == "User ID")
            {
                uID.Text = "User ID";
                uID.Foreground = Brushes.Red;
                error.Foreground = Brushes.Red;
                error.Content = "Please fix all red fields";
            }
            if (Disabilites.Text == "" || Disabilites.Text == "Learning Disabilites")
            {
                Disabilites.Text = "Learning Disabilites";
                Disabilites.Foreground = Brushes.Red;
                error.Foreground = Brushes.Red;
                error.Content = "Please fix all red fields";
            }
            if (address.Text == "" || address.Text == "Street Address")
            {
                address.Text = "Street Address";
                address.Foreground = Brushes.Red;
                error.Foreground = Brushes.Red;
                error.Content = "Please fix all red fields";
            }
            if (number.Text == "" || number.Text == "Telephone Number" )
            {
                number.Text = "Telephone Number";
                number.Foreground = Brushes.Red;
                error.Foreground = Brushes.Red;
                error.Content = "Please fix all red fields";
            }
            else
            {
                Student tempStudent = new Student(FNBox.Text, LNBox.Text, uID.Text, address.Text, email.Text, number.Text,
                                                  Month.Text + " " + day.Text + " " + year.Text, gender.Text, race.Text, 
                                                  Disabilites.Text, "","",0,"");

                ListOfStudents.Add(tempStudent);

            }
        }
    }
}
