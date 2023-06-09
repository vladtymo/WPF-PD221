using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MVVM.ViewModels
{
    public class ViewModel
    {
        private ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();

        // ! We can bind ONLY to a public property
        public IEnumerable<Contact> Contacts => contacts;
        public Contact SelectedContact { get; set; }

        public ViewModel()
        {
            // initialize / read from database...
            contacts.Add(new Contact() { Id = 120, Name = "Vladyslav", Surname = "Tm", Age = 25, Phone = "3909989898", IsBlocked = true});
            contacts.Add(new Contact() { Id = 300, Name = "Oleg", Surname = "Sb", Age = 12, Phone = "22-44-22", IsBlocked = false });
            contacts.Add(new Contact() { Id = 310, Name = "Viktoria", Surname = "Gh", Age = 44, Phone = "3909939673", IsBlocked = true });
        }

        // ------------- Presentation Logic
        public void Dublicate()
        {
            if (SelectedContact != null)
                contacts.Add(SelectedContact);
        }
        public void Delete()
        {
            if (SelectedContact != null)
                contacts.Remove(SelectedContact);
        }
    }
}
