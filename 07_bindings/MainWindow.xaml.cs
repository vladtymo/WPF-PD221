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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _07_bindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel viewModel = new("Intro to ViewModel");

        public MainWindow()
        {
            InitializeComponent();

            // allow window controls to binding to User object
            this.DataContext = viewModel; // View -> View Model
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(viewModel.CurrentUser.ToString());
        }
    }
}
