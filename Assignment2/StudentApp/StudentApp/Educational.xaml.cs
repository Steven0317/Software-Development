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
        //private HomePage StudentList = new HomePage();

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
                                                  dob.SelectedDate.ToString(), gender.Text, race.Text,
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



            fnValid = string.IsNullOrWhiteSpace(FNBox.Text) ? false : ValidateLetter(FNBox.Text);
            FNBox.Background = fnValid ? Brushes.White : Brushes.Coral;
            error.Visibility = fnValid ? Visibility.Hidden : Visibility.Visible;

            lnValid = string.IsNullOrWhiteSpace(LNBox.Text)? false : ValidateLetter(LNBox.Text);
            LNBox.Background = lnValid ? Brushes.White : Brushes.Coral;
            error.Visibility = lnValid ? Visibility.Hidden : Visibility.Visible;


            IdValid = (string.IsNullOrWhiteSpace(uID.Text)) ? false : ValidateDigit(uID.Text,  uID.MaxLength);
            uID.Background = IdValid ? Brushes.White : Brushes.Coral;
            error.Visibility = IdValid ? Visibility.Hidden : Visibility.Visible;


            addressValid = (string.IsNullOrWhiteSpace(address.Text)) ? false : true;
            address.Background = addressValid ? Brushes.White : Brushes.Coral;
            error.Visibility = addressValid ? Visibility.Hidden : Visibility.Visible;

            emailValid = string.IsNullOrWhiteSpace(email.Text) ? false : true;
            email.Background = emailValid ? Brushes.White : Brushes.Coral;
            error.Visibility = emailValid ? Visibility.Hidden : Visibility.Visible;

            phoneValid = string.IsNullOrWhiteSpace(number.Text) ? false : ValidateDigit(number.Text, number.MaxLength);
            number.Background = phoneValid ? Brushes.White : Brushes.Coral;
            error.Visibility = emailValid ? Visibility.Hidden : Visibility.Visible;

            dobValid = dob.SelectedDate == null ? false : true;
            dob.Background = dobValid ? Brushes.White : Brushes.Coral;
            error.Visibility = dobValid ? Visibility.Hidden : Visibility.Visible;

            genderValid = string.IsNullOrWhiteSpace(gender.Text) ? false : ValidateLetter(gender.Text);
            gender.Background = genderValid ? Brushes.White : Brushes.Coral;
            error.Visibility = genderValid ? Visibility.Hidden : Visibility.Visible;


            raceValid = string.IsNullOrWhiteSpace(race.Text) ? false : ValidateLetter(race.Text);
            race.Background = raceValid ? Brushes.White : Brushes.Coral;
            error.Visibility = raceValid ? Visibility.Hidden : Visibility.Visible;


            disablitiesValid = string.IsNullOrWhiteSpace(Disabilites.Text) ? false : ValidateLetter(Disabilites.Text);
            Disabilites.Background = disablitiesValid ? Brushes.White : Brushes.Coral;
            error.Visibility = disablitiesValid ? Visibility.Hidden : Visibility.Visible;
           


            return (fnValid && lnValid && IdValid && addressValid && emailValid && phoneValid && dobValid && raceValid && disablitiesValid && genderValid);
            
        }

        //replaces default text on lost focus if null
        private void LoseFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
               
            }

        }

        private bool ValidateLetter(string test)
        {
            return test.Where(x => char.IsLetter(x)).Count() == test.Length;
        }

        private bool ValidateDigit(string test, int maxLength)
        {
            return test.All("0123456789-Uu".Contains);
        }

        public static implicit operator Educational(List<Student> v)
        {
            throw new NotImplementedException();
        }
    }
}
