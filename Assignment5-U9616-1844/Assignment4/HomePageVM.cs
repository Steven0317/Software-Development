using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Assignment4
{
    public class HomePageVM : INotifyPropertyChanged
    {
        public TabItem selectedControl { get; set; }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private ObservableCollection<object> FilteredList = new ObservableCollection<object>();
        public ObservableCollection<object> _FilteredList
        {
            get { return FilteredList;  }
            set
            {
                FilteredList = value;
                PropertyChanged(this, new PropertyChangedEventArgs("FilteredList"));
            }
        }



        private ObservableCollection<object> _cartContents = new ObservableCollection<object>();
        public ObservableCollection<object> CartContents
        {
            get { return _cartContents; }
            set
            {
                _cartContents = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CartContents"));
            }
        }
        
        private string _UserName;
        public string UserName
        {
            get { return LoginPage.Loggedin_User.Name; }
            set { _UserName = value; }
        }

        private double _totalCost = 0;
        public double TotalCost
        {
            get { return Math.Round(_totalCost, 2, MidpointRounding.AwayFromZero); }
            set
            {
                _totalCost = value;
                TotalCostDisplay = "$" + Math.Round(_totalCost, 2, MidpointRounding.AwayFromZero);
                PropertyChanged(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }

        private string _SelectedItemPet;
        public string SelectedItemPet
        {
            get { return _SelectedItemPet; }
            set
            {
                if (_SelectedItemPet == value) return;
                _SelectedItemPet = value;
                SelectionEvent(_SelectedItemPet);
                PropertyChanged(this, new PropertyChangedEventArgs(_SelectedItemPet));
                
                
            }
        }

        private string _SelectedItemSupply;
        public string SelectedItemSupply
        {
            get { return _SelectedItemSupply; }
            set
            {
                _SelectedItemSupply = value;
                SelectionEvent(_SelectedItemSupply);
                PropertyChanged(this, new PropertyChangedEventArgs("_SelectedItemSupply"));
                
            }
        }

        private string totalCostdisplay;
        public string TotalCostDisplay
        {
            get { return totalCostdisplay; }
            set
            {
                totalCostdisplay = value;
                PropertyChanged(this, new PropertyChangedEventArgs("TotalCostDisplay"));
            }
        }

        private string _quantity;
        public string Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Quantity"));
            }
        }


        //adds selected pet and specified quantity 
        // to user shopping cart.
        private void AddToCartClicked(object obj)
        {
            ContentControl cc = selectedControl.Content as ContentControl;
            ListBox lb = cc.Content as ListBox;
            int purchasedAmount = int.Parse(Quantity);

            if (selectedControl.Header.ToString() == "Pets")
            {   
                Pets selectedPet = lb.SelectedItem as Pets;
                selectedPet.Stock -= purchasedAmount;
                selectedPet.PurchasedAmount = purchasedAmount;
                CartContents.Add(selectedPet as object);
                TotalCost += double.Parse(selectedPet.Price.ToString().Replace("$", "")) * purchasedAmount;
                
            }
            else
            {
                Supplies selectedItem = lb.SelectedItem as Supplies;
                selectedItem.Stock -= purchasedAmount;
                selectedItem.PurchasedAmount = purchasedAmount;
                CartContents.Add(selectedItem as object);
                TotalCost += double.Parse(selectedItem.Price.ToString().Replace("$", "")) * purchasedAmount;
            }
        }

        public ICommand AddToCartCommand
        {
            get
            {
                if (_addToCartEvent == null)
                {
                    _addToCartEvent = new DelegateCommand(AddToCartClicked);
                }

                return _addToCartEvent;
            }
        }
        DelegateCommand _addToCartEvent;



        //command to open
        //the cart window
        private void OpenCartClicked(object obj)
        {
            ShoppingCartVM shoppingCartVM = new ShoppingCartVM(this);

            ShoppingCart cart = new ShoppingCart
            {
                DataContext = shoppingCartVM
            };
            cart.Show();
        }

        public ICommand OpenCartCommand
        {
            get
            {
                if (_openCartEvent == null)
                {
                    _openCartEvent = new DelegateCommand(OpenCartClicked);
                }

                return _openCartEvent;
            }
        }
        DelegateCommand _openCartEvent;


        private void SelectionEvent(object obj)
        {
            if(SelectedItemPet == "Pets with Feet")
            {
                
                PetDisplayVM petDisplay = new PetDisplayVM();

                foreach (Pets ListItem in new ObservableCollection<Pets>(petDisplay._PetsCollection))
                {
                    if (ListItem is LandPet)
                        FilteredList.Add(ListItem);
                }

                if(_SelectedItemSupply != null)
                {
                    if(SelectedItemSupply == "Bedding")
                    {
                        SupplyDisplayVM supplyDisplay = new SupplyDisplayVM();

                        foreach(Supplies ListItem in new ObservableCollection<Supplies>(supplyDisplay._SupplyCollection))
                        {
                            if(ListItem is Beds)
                            {
                                FilteredList.Add(ListItem);
                            }
                        }
                    }
                    else if (SelectedItemSupply == "Clothes")
                    {
                        SupplyDisplayVM supplyDisplay = new SupplyDisplayVM();

                        foreach (Supplies ListItem in new ObservableCollection<Supplies>(supplyDisplay._SupplyCollection))
                        {
                            if (ListItem is Clothes )
                            {
                                FilteredList.Add(ListItem);
                            }
                        }
                    }
                    else if (SelectedItemSupply == "Food")
                    {
                        SupplyDisplayVM supplyDisplay = new SupplyDisplayVM();

                        foreach (Supplies ListItem in new ObservableCollection<Supplies>(supplyDisplay._SupplyCollection))
                        {
                            if (ListItem is Food)
                            {
                                FilteredList.Add(ListItem);
                            }
                        }
                    }
                }

              
            }
            else
            {
                PetDisplayVM petDisplay = new PetDisplayVM();

                foreach (Pets ListItem in new ObservableCollection<Pets>(petDisplay._PetsCollection))
                {
                    if (ListItem is WaterPet)
                        FilteredList.Add(ListItem);
                }

                if (_SelectedItemSupply != null)
                {
                    if (SelectedItemSupply == "Bedding")
                    {
                        SupplyDisplayVM supplyDisplay = new SupplyDisplayVM();

                        foreach (Supplies ListItem in new ObservableCollection<Supplies>(supplyDisplay._SupplyCollection))
                        {
                            if (ListItem is Beds)
                            {
                                FilteredList.Add(ListItem);
                            }
                        }
                    }
                    else if (SelectedItemSupply == "Clothes")
                    {
                        SupplyDisplayVM supplyDisplay = new SupplyDisplayVM();

                        foreach (Supplies ListItem in new ObservableCollection<Supplies>(supplyDisplay._SupplyCollection))
                        {
                            if (ListItem is Clothes)
                            {
                                FilteredList.Add(ListItem);
                            }
                        }
                    }
                    else if (SelectedItemSupply == "Food")
                    {
                        SupplyDisplayVM supplyDisplay = new SupplyDisplayVM();

                        foreach (Supplies ListItem in new ObservableCollection<Supplies>(supplyDisplay._SupplyCollection))
                        {
                            if (ListItem is Food)
                            {
                                FilteredList.Add(ListItem);
                            }
                        }
                    }
                }

            }


            FilteredVM filteredVM = new FilteredVM(this);
            Filtered filter  = new Filtered
            {
                DataContext = filteredVM
            };
            filter.Show();
            
            
        }

       
    } 
}
