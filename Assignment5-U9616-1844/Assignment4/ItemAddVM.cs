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
    class ItemAddVM : INotifyPropertyChanged
    {
        private SupplyDisplayVM parent;

        public ItemAddVM(SupplyDisplayVM parent)
        {
            this.parent = parent;
        }



        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_Name"));
            }
        }


        private int _Stock;

        public int Stock
        {
            get { return _Stock; }
            set
            {
                _Stock = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_Stock"));
            }
        }

        private double _Price;

        public double Price
        {
            get { return _Price; }
            set
            {
                _Price = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_Price"));
            }
        }

        private string _ImagePath;

        public string ImagePath
        {
            get { return _ImagePath; }
            set
            {
                _ImagePath = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_ImagePath"));
            }
        }

        private string _ItemType;

        public string ItemType
        {
            get { return _ItemType; }
            set
            {
                _ItemType = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_ItemType"));
            }
        }

        private string _Size;

        public string Size
        {
            get { return _Size; }
            set
            {
                _Size = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_Size"));
            }
        }


        private void SelectImageClick(object obj)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".jpg";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            if (dlg.ShowDialog() == true)
            {
                ImagePath = dlg.FileName.ToString();
                PropertyChanged(this, new PropertyChangedEventArgs("_ImagePath"));
            }
        }
        public ICommand SelectImageCommand
        {
            get
            {
                if (_selectImage == null)
                {
                    _selectImage = new DelegateCommand(SelectImageClick);
                }
                return _selectImage;
            }

        }
        DelegateCommand _selectImage;

        private void AddItemClicked(object obj)
        {
            double result;
            int resultInt;
            if (string.IsNullOrWhiteSpace(_ItemType) && string.IsNullOrWhiteSpace(_ImagePath) && Double.TryParse(_Price.ToString(), out result) &&
                   int.TryParse(_Stock.ToString(), out resultInt) && string.IsNullOrWhiteSpace(_Name))
            {
                MessageBox.Show("Required Fields Left Blank, Please Fix");
            }
            else
            {
                if (_ItemType.Equals("Bedding"))
                {
                    parent._SupplyCollection.Add(new Beds(_Name,"", _Price, _Stock, _ImagePath,_Size,""));
                }
                else if(_ItemType.Equals("Clothing"))
                {
                    parent._SupplyCollection.Add(new Clothes(_Name, "", _Price, _Stock, _ImagePath, _Size, ""));
                }
                else
                {
                    parent._SupplyCollection.Add(new Food(_Name, "", _Price, _Stock, _ImagePath, ""));
                }
            }
        }
        public ICommand AddItemCommand
        {
            get
            {
                if (_itemCommand == null)
                {
                    _itemCommand = new DelegateCommand(AddItemClicked);
                }
                return _itemCommand;
            }
        }
        DelegateCommand _itemCommand;

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
