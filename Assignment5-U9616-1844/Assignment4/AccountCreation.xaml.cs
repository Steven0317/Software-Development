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
    /// Interaction logic for AccountCreation.xaml
    /// </summary>
    public partial class AccountCreation : Page
    {
        public AccountCreation()
        {
            InitializeComponent();
        }


        private bool ValidateEntries()
        {

            bool nameValid;
            bool emailValid;
            bool addrValid;
            bool ccNValid;
            bool expValid;
            bool secValid;
            bool uValid;
            bool pValid;
            bool authentication;
        
           

            nameValid = string.IsNullOrWhiteSpace(NameBox.Text) ? false : ValidateLetter(NameBox.Text);

            emailValid = string.IsNullOrWhiteSpace(EmailBox.Text) ? false : true;

            addrValid = string.IsNullOrWhiteSpace(AddressBox.Text) ? false : true;

            ccNValid = string.IsNullOrWhiteSpace(CCBox.Text) ? false : ValidateDigit(CCBox.Text);

            expValid = string.IsNullOrWhiteSpace(ExpBox.Text) ? false : true;

            secValid = string.IsNullOrWhiteSpace(SecBox.Text) ? false : ValidateDigit(SecBox.Text);

            uValid = string.IsNullOrWhiteSpace(userBox.Text) ? false : true;

            pValid = (string.IsNullOrWhiteSpace(PassBox.Text) && string.IsNullOrWhiteSpace(ConfPassBox.Text))
                        && PassBox.Text.Equals(ConfPassBox.Text) ? false : true;

            authentication = seller.IsChecked == true ^ user.IsChecked == true ? false : true;

            return nameValid && emailValid && secValid && expValid && uValid
                   && pValid && ccNValid && addrValid;
        }

        private bool ValidateLetter(string test)
        {
            return test.Where(x => char.IsLetter(x)).Count() == test.Length;
        }

        private bool ValidateDigit(string test)
        {
            return test.All("0123456789-/".Contains);
        }

        private void Create_Button_Click(object sender, RoutedEventArgs e)
        {
            if(ValidateEntries())
            {
                

                Users temp = new Users(NameBox.Text, userBox.Text, EmailBox.Text, AddressBox.Text, CCBox.Text, ExpBox.Text, Convert.ToInt32(SecBox.Text), PassBox.Text, seller.IsChecked == true ? "seller" : "user");

                LoginPage.userList.Add(temp);
                LoginPage.Loggedin_User = temp;
                NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
            }
        }
    }
}
