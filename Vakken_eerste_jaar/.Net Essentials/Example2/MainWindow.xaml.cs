using System;
using System.Windows;

namespace Example2
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
        //deze onderste functie komt als je dubbel klikt op button
        private void clickButton_Click(object sender, RoutedEventArgs e)
        {
            outputLabel.Content = "Hello, 1TINE";
            MessageBox.Show("Hello again", "1TINE");//berichtvenster met message en titel
            Console.WriteLine("Hello output in console");//iets afdrukken in console
        }
    }
}
