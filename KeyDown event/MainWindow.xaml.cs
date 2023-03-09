using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Update the Label with the last key pressed
            LastKeyPressedLabel.Content = $"Last Key Pressed: {e.Key.ToString()}";
        }
    }
}
