using System;
using System.Windows;

namespace FormatDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine(Math.Round(6.5));
            Console.WriteLine(Math.Round(7.5));
        }

        private void intButton_Click(object sender, RoutedEventArgs e)
        {
            int wholeNumber = Convert.ToInt32(wholeNumberTextBox.Text);
            string placeHolder = "{0:" + formatTextBox.Text + "}";
            resultLabel.Content = placeHolder + " wordt " + String.Format(placeHolder, wholeNumber);
        }

        private void doubleButton_Click(object sender, RoutedEventArgs e)
        {
            double rationalNumber = Convert.ToDouble(rationalNumberTextBox.Text);
            string placeHolder = "{0:" + formatTextBox.Text + "}";
            resultLabel.Content = placeHolder + " wordt " + string.Format(placeHolder, rationalNumber); ;
        }
    }
}
