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
    /// Interaction logic for WindowSolution2.xaml
    /// </summary>
    public partial class WindowSolution2 : Window
    {// betere oplossing dan de eerste oplossing zonder gebruik te maken van f of switch
        private List<SolidColorBrush> colorList;
     

        public WindowSolution2()
        {
            InitializeComponent();
            colorList = new List<SolidColorBrush>() { new SolidColorBrush(Colors.Red),
         new SolidColorBrush(Colors.Green),  new SolidColorBrush(Colors.Blue) };
    
        }
        private void colorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            colorLabel.Background = colorList[colorComboBox.SelectedIndex];
            
        }
    }
}
