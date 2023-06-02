using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _03_controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (datePicker.SelectedDate != null)
                this.Title = datePicker.SelectedDate.Value.ToLongDateString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (calendar.SelectedDate != null)
                MessageBox.Show($"From: {calendar.SelectedDates.First()}\nTo: {calendar.SelectedDates.Last()}", "Selected Date Range");
        }
    }
}
