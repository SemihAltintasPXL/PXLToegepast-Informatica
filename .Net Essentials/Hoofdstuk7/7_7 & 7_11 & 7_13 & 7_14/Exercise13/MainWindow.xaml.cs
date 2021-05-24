using System;
using System.Windows;

namespace Exercise13
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, RoutedEventArgs e)
        {
            double btw = 0.21;
            double netto = Convert.ToDouble(nettoPrijsTextBox.Text);

            if (verlaagdTariefCheckBox.IsChecked == true)
            {
                btw = 0.06;
            }

            btwTextBox.Text = Convert.ToString(btw * netto);
            totaalTextBox.Text = Convert.ToString(netto * (1 + btw));
        }
    }
}
