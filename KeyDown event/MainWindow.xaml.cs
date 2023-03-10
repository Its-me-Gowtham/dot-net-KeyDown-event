using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(3000);
            timer.Tick += Timer_Tick;
        }

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            LastKeyPressedLabel.Content = $"Last Key Pressed: {e.Key.ToString()}";
            LastKeyPressedLabel.Visibility = Visibility.Visible;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs f)
        {
            timer.Stop();
            LastKeyPressedLabel.Visibility = Visibility.Hidden;
            LastKeyPressedLabel.Content = string.Empty;
        }
    }
}
