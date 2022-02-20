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
using System.Windows.Shapes;

namespace ExampleComboBox
{
    /// <summary>
    /// Interaction logic for WindowSolution3.xaml
    /// </summary>
    public partial class WindowSolution3 : Window
    { // vertrekken van Solution2 maar de Combobox krijgt zijn waarden hier
        private List<SolidColorBrush> colorList;
        private List<string> list;
        public WindowSolution3()
        {
            InitializeComponent();
            colorList = new List<SolidColorBrush>() { new SolidColorBrush(Colors.Red),
         new SolidColorBrush(Colors.Green),  new SolidColorBrush(Colors.Blue) };
            list = new List<string>() { "Red", "Green", "Blauw" };
            colorComboBox.ItemsSource = list;

        }

        private void colorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            colorLabel.Background = colorList[colorComboBox.SelectedIndex];

        }
    }
}
