using PropertyChanged;

namespace _08_MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public bool IsBlocked { get; set; }

        [DependsOn("Id", "Name", "Surname", "Phone", "IsBlocked")]
        public string ShortInfo => ToString();

        public override string ToString()
        {
            return $"[{Id}] - {Name} {Surname} ... {Phone} {(IsBlocked ? "X" : "")}";
        }
    }
}
