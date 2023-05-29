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

namespace _01_intro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string current = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        // event handlers...
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello WPF!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your text: " + myTxtBox.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string text = (sender as Button).Content.ToString();
            current += text;

            MessageBox.Show($"Button: {current} was clicked!");
        }
    }
}
