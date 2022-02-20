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

namespace Example1Exception
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            //mainWindow.Show();
            // je kan nog steeds aan het Startwindow aan en nog een mainwindow of integerWindow openen
            // als je dit niet wil (= modaal openen)
            mainWindow.ShowDialog();
        }

        private void integerDivisionButton_Click(object sender, RoutedEventArgs e)
        {
            WindowInteger windowInteger = new WindowInteger();
            windowInteger.ShowDialog();
        }
    }
}
