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
    
    public class ShoppingCartVM : INotifyPropertyChanged
    {
        public HomePageVM Parent { get; set; }
        
        public ShoppingCartVM(HomePageVM parent) { Parent = parent; }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };


        //updates the cart on button click if the user
        //changes the number within the text fields
        public void UpdateCartClicked(object obj)
        {
            double sumTotal = 0;
            List<Object> toDelete = new List<Object>();

            foreach (var cartObject in Parent.CartContents)
            {
                if (cartObject is Pets)
                {
                    var pet = cartObject as Pets;
                    sumTotal += double.Parse(pet.Price.ToString().Replace("$", "")) * pet.PurchasedAmount;
                    if (pet.PurchasedAmount == 0) { toDelete.Add(pet); }
                }
                else
                {
                    var item = cartObject as Supplies;
                    sumTotal += double.Parse(item.Price.ToString().Replace("$", "")) * item.PurchasedAmount;
                    if (item.PurchasedAmount == 0) { toDelete.Add(item); }
                }
              
            }

            foreach (Object itemToDelete in toDelete) { Parent.CartContents.Remove(itemToDelete); }
            Parent.TotalCost = sumTotal;
        }
        public ICommand UpdateOrderCommand
        {
            get
            {
                if (_updateCartEvent == null)
                {
                    _updateCartEvent = new DelegateCommand(UpdateCartClicked);
                }

                return _updateCartEvent;
            }
        }
        DelegateCommand _updateCartEvent;



        /// places the order and
        /// subtracts the cart amount 
        /// from the intial list object
        public ICommand PlaceOrderCommand
        {
            get
            {
                if(_PayCartEvent == null)
                {
                    _PayCartEvent = new DelegateCommand(PlaceOrderClicked);
                }

                return _PayCartEvent;
            }
        }
        DelegateCommand _PayCartEvent;

        public void PlaceOrderClicked(object obj)
        {
            

            foreach (Object cartObject in Parent.CartContents)
            {


                if (cartObject is Pets)
                {
                    Pets pet = cartObject as Pets;
                        int difference = pet.Stock - pet.PurchasedAmount;
                        if (difference >= 0)
                        {
                            pet.Stock -= pet.PurchasedAmount;

                        }
                        else
                        {
                            MessageBox.Show(string.Format("Not enough items in stock to purchase, Total Items for purchase: {0}", pet.Stock));
                        }
                    
                }
                else if(cartObject is Supplies)
                {
                    Supplies supply = cartObject as Supplies;
                     int difference = supply.Stock - supply.PurchasedAmount;
                    if(difference >= 0)
                    {
                        supply.Stock -= supply.PurchasedAmount;
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Not enough items in stock to purchase, Total Items for purchase: {0}", supply.Stock));
                    }

                }
            }

            
        }




    }
}
