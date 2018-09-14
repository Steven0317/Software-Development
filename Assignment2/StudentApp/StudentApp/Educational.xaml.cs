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
    /// Interaction logic for Educational.xaml
    /// </summary>
    public partial class Educational : Page
    {
        public Educational()
        {
            InitializeComponent();
            FNBox.Focus();
        }

        private void SelectAll(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if(tb != null)
            {
                tb.SelectAll();
            }

        }

        private void SelectAll(object sender, RoutedEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if (tb != null)
            {
                tb.SelectAll();
            }
        }

        private void SelectAll(object sender, MouseEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if (tb != null)
            {
                tb.SelectAll();
            }
        }

        private void SelectAll(object sender, MouseButtonEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if (tb != null)
            {
                tb.SelectAll();
            }
        }
    }
}
