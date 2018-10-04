﻿using System;
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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        private Educational StudentList = new Educational();

        public Delete()
        {
            InitializeComponent();
        }

        //clear text box on focus
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


        //replace empty text box with default text
        private void LoseFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = tb.Tag.ToString();
            }

        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            /* will search for either the id or the concatinateed first &
             *  last name and return that to delete, check to make sure 
             *  we found the student as well
             */
            var Dstudent = Educational.Students.SingleOrDefault(s => s.ID == DeleteInfo.Text || s.FirstName + " " + s.LastName == DeleteInfo.Text);

            if (Dstudent != null)
            {
                Educational.Students.Remove(Dstudent);
                MessageBox.Show("Student Deleted");
            }
            else
            {
                MessageBox.Show("Student not Found");
            }
        }

        //send us back to the home screen
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }
    }
}
