using _08_MVVM.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _08_MVVM.ViewModels
{
    public class ViewModel
    {
        private ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();

        private readonly RelayCommand dublicateCommand;
        private readonly RelayCommand removeCommand;
        private readonly RelayCommand removeAllCommand;

        // ! We can bind ONLY to a public property
        public IEnumerable<Contact> Contacts => contacts;
        public Contact SelectedContact { get; set; }
        public ICommand DublicateCmd => dublicateCommand;
        public ICommand RemoveCmd => removeCommand;
        public ICommand RemoveAllCmd => removeAllCommand;

        public ViewModel()
        {
            // initialize / read from database...
            contacts.Add(new Contact() { Id = 120, Name = "Vladyslav", Surname = "Tm", Age = 25, Phone = "3909989898", IsBlocked = true});
            contacts.Add(new Contact() { Id = 300, Name = "Oleg", Surname = "Sb", Age = 12, Phone = "22-44-22", IsBlocked = false });
            contacts.Add(new Contact() { Id = 310, Name = "Viktoria", Surname = "Gh", Age = 44, Phone = "3909939673", IsBlocked = true });

            dublicateCommand = new((o) => Dublicate(), (o) => SelectedContact != null);
            removeCommand = new((o) => Delete(), (o) => SelectedContact != null);
            removeAllCommand = new((o) => contacts.Clear(), (o) => contacts.Count > 0);
        }

        // ------------- Presentation Logic
        public void Dublicate()
        {
            contacts.Add((Contact)SelectedContact.Clone()); 
        }
        public void Delete()
        {
            contacts.Remove(SelectedContact);
        }
    }
}
