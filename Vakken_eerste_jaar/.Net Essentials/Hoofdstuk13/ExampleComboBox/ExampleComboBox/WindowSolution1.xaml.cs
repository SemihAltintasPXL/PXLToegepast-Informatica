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

namespace ExampleComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SolidColorBrush redColor = new SolidColorBrush(Colors.Red);
        private SolidColorBrush greenColor = new SolidColorBrush(Colors.Green);
        private SolidColorBrush blueColor = new SolidColorBrush(Colors.Blue);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void colorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = colorComboBox.SelectedItem as ComboBoxItem;
            string color = Convert.ToString(item.Content);
            switch (color)
            {
                case "Red":colorLabel.Background = redColor; break;
                case "Green": colorLabel.Background = greenColor; break;
                case "Blue": colorLabel.Background = blueColor; break;
            }
        }
    }
}
