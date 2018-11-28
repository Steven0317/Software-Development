using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class PetEditVM : INotifyPropertyChanged
    {
        public EditItemVM Parent { get; set; }
        public PetEditVM(EditItemVM parent) { Parent = parent; }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
