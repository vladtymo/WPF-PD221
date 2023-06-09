﻿using _08_MVVM.ViewModels;
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

namespace _08_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel viewModel = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = viewModel;
            // or set in XAML
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Dublicate();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            viewModel.Delete();
        }
    }
}