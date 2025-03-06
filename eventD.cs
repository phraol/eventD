using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
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
        private Random _random = new Random();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("o thanks 😊");
        }
        private void MyButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;

            // Get the max width and height of the window
            double maxWidth = this.ActualWidth - btn.ActualWidth;
            double maxHeight = this.ActualHeight - btn.ActualHeight;

            // Generate random position
            double newX = _random.NextDouble() * maxWidth;
            double newY = _random.NextDouble() * maxHeight;

            // Set new position
            btn.Margin = new Thickness(newX, newY, 0, 0);
        }

        private void txtinput_TextChanged(object sender, TextChangedEventArgs e)
        {
            string currentText = name.Text;
            MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButton.YesNo);
           // MessageBox.Show("An error occurred.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void cmbColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedColor = (cmbColors.SelectedItem as ComboBoxItem)?.Content.ToString();
            MessageBox.Show($"Selected Color: {selectedColor}");
        }
        private void cmbColors_DropDownOpened(object sender, EventArgs e)
        {
            MessageBox.Show("Dropdown Opened");
        }
        private void cmbColors_DropDownClosed(object sender, EventArgs e)
        {
            MessageBox.Show("Dropdown Closed");
        }

    }
}
