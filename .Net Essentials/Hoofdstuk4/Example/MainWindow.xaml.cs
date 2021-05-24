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

namespace Example
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int cents = Convert.ToInt32(inputTextBox.Text);
            //output1TextBlock.Text = $"{cents / 100 } euros and {cents % 100} cents";
            // 6 posities voor de euros 2 voor de cents, links uitgelijnd
            output1TextBlock.Text = $"{cents / 100, -6} euros and {cents % 100, -2} cents";
            //output2TextBlock.Text = $"{cents / 100.0:C}"; => 2 cijfers na de komma
            // met 0 cijfer1 na de komma
            output2TextBlock.Text = $"{cents / 100.0:C0}";
        }
    }
}
