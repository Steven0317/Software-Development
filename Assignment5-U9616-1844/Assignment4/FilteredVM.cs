using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Assignment4
{
    public class FilteredVM : INotifyPropertyChanged
    {
        public HomePageVM Parent { get; set; }
        public FilteredVM(HomePageVM parent) { Parent = parent; }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private ICommand closeWindowCommand;

        public ICommand CloseWindowCommand
        {
            get
            {
                if (closeWindowCommand == null)
                {
                    closeWindowCommand = new RelayCommand(param => this.CloseWindow(), null);
                }
                return closeWindowCommand;
            }
        }

        private void CloseWindow()
        {
            Parent._FilteredList.Clear();
        }

    }
}
