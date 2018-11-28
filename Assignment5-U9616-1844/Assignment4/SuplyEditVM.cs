using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class SupplyEditVM : INotifyPropertyChanged
    {

        public EditSupplyVM Parent { get; set; }
        public SupplyEditVM(EditSupplyVM parent) { Parent = parent; }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
