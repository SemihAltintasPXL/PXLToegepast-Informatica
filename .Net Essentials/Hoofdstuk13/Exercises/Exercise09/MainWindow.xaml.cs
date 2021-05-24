using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Exercise09
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string colorString = ((ComboBoxItem)colorsComboBox.SelectedItem).Name;
            Color colorColor = (Color)ColorConverter.ConvertFromString(colorString);
            SolidColorBrush brush = new SolidColorBrush(colorColor);
            colorLabel.Background = brush;
        }
    }
}
