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
    /// Interaction logic for Educational.xaml
    /// </summary>
    public partial class Educational : Page
    {

        public static List<Student> Students = new List<Student>();
        

        public Educational()
        {
            InitializeComponent();
            
        }
        //removes default text on focus
        private void SelectAll(object sender, RoutedEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if (tb != null)
            {
                tb.Foreground = Brushes.Black;
                tb.BorderBrush = Brushes.Black;
                tb.Text="";
                tb.SelectionStart = 1;
            }
        }
        //validates input boxes pushes to list and pushes new frame into focus
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (ValidateAll())
            {
                Student tempStudent = new Student(FNBox.Text, LNBox.Text, uID.Text, address.Text, email.Text,number.Text,
                                                  month.Text + ", " + day.Text + ", " + year.Text, gender.Text, race.Text,
                                                  Disabilites.Text, 0, "", 0, 0);

                Students.Add(tempStudent);
                error.Visibility = Visibility.Hidden;
                

                NavigationService.Navigate(new Uri("SchoolInfo.xaml", UriKind.Relative));
                
            }
           
        }


        
        //even larger bool validation for input boxes
        //can do better with bindings
        private bool ValidateAll()
        {
            bool fnValid;
            bool lnValid;
            bool IdValid;
            bool addressValid;
            bool emailValid;
            bool phoneValid;
            bool dobValid;
            bool raceValid;
            bool disablitiesValid;
            bool genderValid;

            if(string.IsNullOrWhiteSpace(FNBox.Text) || FNBox.Text == FNBox.Tag.ToString())
            {
                fnValid = false;
                FNBox.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                fnValid = true;
                FNBox.Background = Brushes.White;
               
            }
            if (string.IsNullOrWhiteSpace(LNBox.Text) || LNBox.Text == LNBox.Tag.ToString())
            {
                lnValid = false;
                LNBox.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                lnValid = true;
                LNBox.Background = Brushes.White;
                
            }
            if (string.IsNullOrWhiteSpace(uID.Text) || uID.Text == uID.Tag.ToString())
            {
                IdValid = false;
                uID.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                IdValid = true;
                uID.Background = Brushes.White;
            }
            if (string.IsNullOrWhiteSpace(address.Text) || address.Text == address.Tag.ToString())
            {
                addressValid = false;
                address.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                addressValid = true;
                address.Background = Brushes.White;
            }
            if (string.IsNullOrWhiteSpace(email.Text) || email.Text == email.Tag.ToString())
            {
                emailValid = false;
                email.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                emailValid = true;
                email.Background = Brushes.White;
            }
            if (string.IsNullOrWhiteSpace(number.Text) || number.Text == number.Tag.ToString())
            {
                phoneValid = false;
                number.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                phoneValid = true;
                number.Background = Brushes.White;
            }
            if (string.IsNullOrWhiteSpace(month.Text) || month.Text == month.Tag.ToString())
            {
                dobValid = false;
                month.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                dobValid = true;
                month.Background = Brushes.White;
            }
            if (string.IsNullOrWhiteSpace(day.Text) || day.Text == day.Tag.ToString())
            {
                dobValid = false;
                day.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                dobValid = true;
                day.Background = Brushes.White;
            }
            if (string.IsNullOrWhiteSpace(year.Text) || year.Text == year.Tag.ToString())
            {
                dobValid = false;
                year.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                dobValid = true;
                year.Background = Brushes.White;
            }
            if (string.IsNullOrWhiteSpace(gender.Text) || gender.Text == gender.Tag.ToString())
            {
                genderValid = false;
                gender.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                genderValid = true;
                gender.Background = Brushes.White;
            }
            if (string.IsNullOrWhiteSpace(race.Text) || race.Text == race.Tag.ToString())
            {
                raceValid = false;
                race.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                raceValid = true;
                race.Background = Brushes.White;
            }
            if (string.IsNullOrWhiteSpace(Disabilites.Text) || Disabilites.Text == Disabilites.Tag.ToString())
            {
                disablitiesValid = false;
                Disabilites.Background = Brushes.Coral;
                error.Visibility = Visibility.Visible;
            }
            else
            {
                disablitiesValid = true;
                Disabilites.Background = Brushes.White;
            }


            return (fnValid && lnValid && IdValid && addressValid && emailValid && phoneValid && dobValid && raceValid && disablitiesValid && genderValid);
            
        }

        //replaces default text on lost focus if null
        private void LoseFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = tb.Tag.ToString();
            }

        }
    }
}
