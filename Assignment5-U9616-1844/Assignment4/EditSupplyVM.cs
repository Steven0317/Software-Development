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
    class EditSupplyVM : INotifyPropertyChanged
    {

        public SupplyDisplayVM Parent { get; set; }
        public EditSupplyVM(SupplyDisplayVM parent) { Parent = parent; }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private Supplies _selecteditem;
        public Supplies SelectedItem
        {
            get { return _selecteditem; }
            set
            {
                _selecteditem = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_selectedPet"));

            }

        }


        private void AddItemClicked(object obj)
        {
            ItemAddVM addVM = new ItemAddVM(Parent);

            ItemAdd add = new ItemAdd
            {
                DataContext = addVM
            };
            add.Show();

        }
        public ICommand AddItemCommand
        {
            get
            {
                if (_AddPet == null)
                {
                    _AddPet = new DelegateCommand(AddItemClicked);
                }
                return _AddPet;
            }
        }
        DelegateCommand _AddPet;


        private void EditItemClicked(object obj)
        {
            if (_selecteditem == null) { MessageBox.Show("Select an Item to Edit"); }
            else
            {
                SupplyEditVM itemEdit = new SupplyEditVM(this);
                SupplyEdit edit = new SupplyEdit
                {
                    DataContext = itemEdit
                };
                edit.Show();
            }
        }
        public ICommand EditItemCommand
        {
            get
            {
                if (_updatePet == null)
                {
                    _updatePet = new DelegateCommand(EditItemClicked);
                }
                return _updatePet;
            }
        }
        DelegateCommand _updatePet;

        private void DeleteItemClicked(object obj)
        {
            if (_selecteditem == null) { MessageBox.Show("Select an Item to Delete"); }
            else
            {
                ObservableCollection<Supplies> toDelete = new ObservableCollection<Supplies>();

                foreach (Supplies item in Parent._SupplyCollection)
                {
                    if (item == SelectedItem)
                        toDelete.Add(item);
                }

                foreach (Supplies itemToDelete in toDelete)
                {
                    Parent._SupplyCollection.Remove(itemToDelete);
                }
            }
        }
        public ICommand DeleteItemCommand
        {
            get
            {
                if (_deletePet == null)
                {
                    _deletePet = new DelegateCommand(DeleteItemClicked);
                }
                return _deletePet;
            }

        }
        DelegateCommand _deletePet;
    }
}
