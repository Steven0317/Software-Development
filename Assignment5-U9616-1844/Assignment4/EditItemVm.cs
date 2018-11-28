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
    class EditItemVM : INotifyPropertyChanged
    {
      
        public PetDisplayVM Parent { get; set; }
        public EditItemVM(PetDisplayVM parent) { Parent = parent; }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private Pets _selectedPet;
        public Pets SelectedPet
        {
            get { return _selectedPet; }
            set
            {
                _selectedPet = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_selectedPet"));

            }

        }

        private void AddPetClicked(object obj)
        {
            PetAddVM addVM = new PetAddVM(Parent);

            PetAdd add = new PetAdd
            {
                DataContext = addVM
            };
            add.Show();

        }
        public ICommand AddPetCommand
        {
            get
            {
                if(_AddPet == null)
                {
                    _AddPet = new DelegateCommand(AddPetClicked);
                }
                return _AddPet;
            }
        }
        DelegateCommand _AddPet;


        private void EditPetClicked(object obj)
        {
            if (_selectedPet == null) { MessageBox.Show("Select a Pet to Edit"); }
            else
            {
                PetEditVM petEdit = new PetEditVM(this);
                PetEdit edit = new PetEdit
                {
                    DataContext = petEdit
                };
                edit.Show();
            }
        }
        public ICommand EditPetCommand
        {
            get
            {
                if(_updatePet == null)
                {
                    _updatePet = new DelegateCommand(EditPetClicked);
                }
                return _updatePet;
            }
        }
        DelegateCommand _updatePet;

        private void DeletePetClicked(object obj)
        {
            if (_selectedPet == null) { MessageBox.Show("Select a Pet to Delete"); }
            else
            {
                ObservableCollection<Pets> toDelete = new ObservableCollection<Pets>();

                foreach (Pets item in Parent._PetsCollection)
                {
                    if (item == SelectedPet)
                        toDelete.Add(item);
                }

                foreach (Pets itemToDelete in toDelete)
                {
                    Parent._PetsCollection.Remove(itemToDelete);
                }
            }
        }
        public ICommand DeletePetCommand
        {
            get
            {
                if(_deletePet == null)
                {
                    _deletePet = new DelegateCommand(DeletePetClicked);
                }
                return _deletePet;
            }
           
        }
        DelegateCommand _deletePet;
    }
}
