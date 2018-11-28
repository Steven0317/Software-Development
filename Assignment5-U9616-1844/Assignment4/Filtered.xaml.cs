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
using System.Windows.Shapes;

namespace Assignment4
{
    /// <summary>
    /// Interaction logic for Filtered.xaml
    /// </summary>
    public partial class Filtered : Window
    {
        public Filtered()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            HomePageVM home = new HomePageVM();
            foreach(var item in new ObservableCollection<object>(home._FilteredList))
            {
                home._FilteredList.Remove(item);
            }
        }
    }
}
