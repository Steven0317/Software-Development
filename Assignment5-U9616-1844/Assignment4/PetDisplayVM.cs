using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Assignment4
{
    public class PetDisplayVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        
        private ObservableCollection<Pets> PetsCollection;
        public ObservableCollection<Pets> _PetsCollection
        {
            get { return PetsCollection; }
            set {
                PetsCollection = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_PetsCollection"));
            }
        }

        private Pets _SelectedPet;

        public Pets SelectedPet
        {
            get { return _SelectedPet; }
            set
            {
                _SelectedPet = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_SelectedPet"));
            }
        }



        public PetDisplayVM()
        {
            CreateCollection();
        }

        private void CreateCollection()
        {
            PetsCollection = new ObservableCollection<Pets>()
            {
                new LandPet("Kitten", 10.00, @"\ImageSource\kitten.jpg" , 15),
                new LandPet("Puppy", 12.00, @"\ImageSource\puppy.jpg", 10),
                new LandPet("Hamster", 8.75, @"\ImageSource\hamster.jpg", 24),
                new LandPet("Rabbit", 9.25, @"\ImageSource\rabbit.jpg",18),
                new LandPet("Ferret", 18.50,@"\ImageSource\ferret.jpg", 10),
                new LandPet("Parakeet", 22.15,@"\ImageSource\parakeet.jpg", 9),
                new WaterPet("Turtle", 7.50,@"\ImageSource\turtle.jpg", 4),
                new WaterPet("Goldfish", 1.00, @"\ImageSource\goldfish.jpg", 100),
            };
        }

        private void ItemDoubleClick(object obj)
        {
            if (LoginPage.Loggedin_User.Authentication == "seller")
            {
                EditItemVM editVM = new EditItemVM(this);
                EditItem edit = new EditItem
                {
                    DataContext = editVM
                };
                edit.Show();
            }
            else
            {
                MessageBox.Show("Access Denied");
            }
        }
        public ICommand EditItemCommand
        {
            get
            {
                if (_editItemEvent == null)
                {
                    _editItemEvent = new DelegateCommand(ItemDoubleClick);
                }

                return _editItemEvent;
            }
        }
        DelegateCommand _editItemEvent;


    }
}
