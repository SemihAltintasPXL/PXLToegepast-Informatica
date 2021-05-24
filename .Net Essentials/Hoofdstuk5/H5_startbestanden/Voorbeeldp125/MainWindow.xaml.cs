using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Voorbeeldp125
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
            int number1 = Convert.ToInt32(number1TextBox.Text);
            int number2 = Convert.ToInt32(number2TextBox.Text);
            ShowSum(sumLabel, number1, number2);
            
        }

        private void ShowSum(Label display, int n1, int n2)
        {
            display.Background = new SolidColorBrush(Colors.Blue);
            display.Content = Convert.ToString(n1 + n2);
        }
    }
}
