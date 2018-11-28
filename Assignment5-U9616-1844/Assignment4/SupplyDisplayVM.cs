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
    public class SupplyDisplayVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Supplies> SupplyCollection;

        public ObservableCollection<Supplies> _SupplyCollection
        {
            get { return SupplyCollection; }
            set
            {
                SupplyCollection = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_SupplyCollection"));
            }
        }

        private Supplies SelectedItem;

        public Supplies _SelectedItem
        {
            get { return SelectedItem; }
            set
            {
                SelectedItem = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_SelectedItem"));
            }
        }

        public SupplyDisplayVM()
        {
            CreateCollection();
        }

        private void CreateCollection()
        {
            SupplyCollection = new ObservableCollection<Supplies>()
            {
                new Food("Purina Beef", "The Classic", 35.89, 15, @"\ImageSource\beef.jpg" , "Dog"),
                new Food("Purina Chicken", "The Other Classic", 32.50, 10, @"\ImageSource\chicken.jpg" , "Dog"),
                new Food("Blue Wilderness", "The Healthy Alternative", 20.99, 8, @"\ImageSource\salmon.jpg","Cat"),
                new Beds("Plush feather Bed", "Extra Soft", 12.99, 25, @"\ImageSource\plush.jpg", "S,M,L", "Cotton" ),
                new Beds("Rickety Cot", "No Frills Cot", 0.99, 3, @"\ImageSource\cot.jpg", "L", "Polyester"),
                new Clothes("Santa Outfit", " White beard not included", 10.99, 11, @"\ImageSource\santa.jpg", "S,M,L", "Cotton Blend"),
                new Clothes("Shark Outfit", "For the little chompers", 13.49, 7,@"\ImageSource\shark.jpg", "S", "Polyester & Nylon"),
                new Clothes("Viking Hats for Cats","They dont like it", 7.99, 18,@"\ImageSource\viking.jpg", "One Size Fits All", "Cotton"),


            };
        }

        private void ItemDoubleClick(object obj)
        {
            if (LoginPage.Loggedin_User.Authentication == "seller")
            {
                EditSupplyVM editVM = new EditSupplyVM(this);
                EditSupply edit = new EditSupply
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
