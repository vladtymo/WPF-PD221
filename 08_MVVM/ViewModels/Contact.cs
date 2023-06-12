using PropertyChanged;
using System;

namespace _08_MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class Contact : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public bool IsBlocked { get; set; }

        [DependsOn("Id", "Name", "Surname", "Phone", "IsBlocked")]
        public string ShortInfo => ToString();

        public object Clone()
        {
            var copy = (Contact)this.MemberwiseClone();

            copy.Name = (string)this.Name.Clone();
            copy.Surname = (string)this.Surname.Clone();
            copy.Phone = (string)this.Phone.Clone();

            return copy;
        }

        public override string ToString()
        {
            return $"[{Id}] - {Name} {Surname} ... {Phone} {(IsBlocked ? "X" : "")}";
        }
    }
}
