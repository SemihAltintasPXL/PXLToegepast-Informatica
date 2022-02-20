using System;
using System.Windows;

namespace Exercise11
{
    public partial class MainWindow : Window
    {
        private Random generator1 = new Random(5000);
        private Random generator2 = new Random(5000);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void generator1Button_Click(object sender, RoutedEventArgs e)
        {
            generator1Label.Content = Convert.ToString(generator1.Next());
        }

        private void generator2Button_Click(object sender, RoutedEventArgs e)
        {
            generator2Label.Content = Convert.ToString(generator1.Next());
        }
    }
}
