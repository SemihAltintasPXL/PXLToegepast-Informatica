using System;
using System.Windows;

namespace Dice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            slider1.ValueChanged += slider_ValueChanged;
            slider2.ValueChanged += slider_ValueChanged;
            CheckValues(slider1.Value, slider2.Value);
        }


        private void slider_ValueChanged(object sender,
                               RoutedPropertyChangedEventArgs<double> e)
        {
            CheckValues(slider1.Value, slider2.Value);
        }

       

       
        private void CheckValues(double value1, double value2)
        {
            int die1 = Convert.ToInt32(value1);
            int die2 = Convert.ToInt32(value2);
            int total = die1 + die2;
            totalLabel.Content = $"total is {total}";

            if (total == 6)
            {
                statusLabel.Content = "You have won";
            }
            else
            {
                statusLabel.Content = "You have lost";
            }
        }

      
    }
}
