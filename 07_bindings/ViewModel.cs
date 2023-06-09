using PropertyChanged;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace _07_bindings
{
    // ------------------------------------- implement INotifyPropertyChanged manualy

    //public class ViewModel : INotifyPropertyChanged
    //{
    //    private bool isDarkTheme;

    //    public User CurrentUser { get; set; }
    //    public string Title { get; set; }
    //    public Color Color => IsDarkTheme ? Colors.DarkGray : Colors.LightGray;
    //    public bool IsDarkTheme
    //    {
    //        get => isDarkTheme;
    //        set
    //        {
    //            this.isDarkTheme = value;
    //            OnPropertyChanged();
    //            OnPropertyChanged("Color");
    //        }
    //    }

    //    public ViewModel(string title)
    //    {
    //        CurrentUser = new() { Username = "tymo@gmail.com", Score = 33 };
    //        this.Title = title;
    //        IsDarkTheme = false;
    //    }


    //    // Create the OnPropertyChanged method to raise the event
    //    // The calling member's name will be used as the parameter.
    //    protected void OnPropertyChanged([CallerMemberName] string name = null)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    //    }
    //    public event PropertyChangedEventHandler? PropertyChanged;
    //}

    // ------------------------------------- using Attributes by Fody 

    [AddINotifyPropertyChangedInterface]
    public class ViewModel
    {
        public User CurrentUser { get; set; }
        public string Title { get; set; }

        [DependsOn("IsDarkTheme")]
        public Color Color => IsDarkTheme ? Colors.DarkGray : Colors.LightGray;
       
        public bool IsDarkTheme { get; set; }

        public ViewModel(string title)
        {
            CurrentUser = new() { Username = "tymo@gmail.com", Score = 33 };
            this.Title = title;
            IsDarkTheme = false;
        }
    }
}
