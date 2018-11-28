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
    class PetAddVM : INotifyPropertyChanged
    {
        public PetDisplayVM Parent { get; set; }
        public PetAddVM(PetDisplayVM parent) { Parent = parent; }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }


        private int _Stock;

        public int Stock
        {
            get { return _Stock; }
            set
            {
                _Stock = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Stock"));
            }
        }

        private double _Price;

        public double Price
        {
            get { return _Price; }
            set
            {
                _Price = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Price"));
            }
        }

        private string _ImagePath;

        public string ImagePath
        {
            get { return _ImagePath; }
            set
            {
                _ImagePath = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ImagePath"));
            }
        }

        private string _PetType;

        public string PetType
        {
            get { return _PetType; }
            set
            {
                _PetType = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_PetType"));
            }
        }


        private void SelectImageClick(object obj)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".jpeg";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            if (dlg.ShowDialog() == true)
            {
                ImagePath = dlg.FileName.ToString();
                
            }
        }
        public ICommand SelectImageCommand
        {
            get
            {
                if(_selectImage == null)
                {
                    _selectImage = new DelegateCommand(SelectImageClick);
                }
                return _selectImage;
            }
           
        }
        DelegateCommand _selectImage;

        private void AddPetClicked(object obj)
        {
            double result;
            int resultInt;
            if(_PetType != null && string.IsNullOrWhiteSpace(_ImagePath) && Double.TryParse(_Price.ToString(),out result) &&
                   int.TryParse(_Stock.ToString(), out resultInt) && string.IsNullOrWhiteSpace(_Name))
            {
                MessageBox.Show("Required Fields Left Blank, Please Fix");
            }
            else
            {
                if(_PetType.Equals("Aquatic Pet"))
                {
                    Parent._PetsCollection.Add(new WaterPet(_Name, _Price, _ImagePath, _Stock));
                }
                else
                {
                    Parent._PetsCollection.Add(new LandPet(_Name, _Price, _ImagePath, _Stock));
                }
            }
        }
        public ICommand AddPetCommand
        {
            get
            {
                if(_petCommand == null)
                {
                    _petCommand = new DelegateCommand(AddPetClicked);
                }
                return _petCommand;
            }
        }
        DelegateCommand _petCommand;
    }
}
