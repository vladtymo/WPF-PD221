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
using System.Windows.Threading;

namespace _06_media_element
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
        }

        void UpdateSliderPosition()
        {
            duration.Value = player.Position.TotalSeconds;
            duration.SelectionEnd = duration.Value;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateSliderPosition();
        }

        private void Player_MediaOpened(object sender, RoutedEventArgs e)
        {
            duration.Minimum = 0;
            duration.Maximum = player.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            player.Pause();
            timer.Stop();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            player.Play();
            timer.Start();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            player.Position = player.Position.Add(new TimeSpan(0, 0, 0, 15));
            UpdateSliderPosition();
        }
    }
}
