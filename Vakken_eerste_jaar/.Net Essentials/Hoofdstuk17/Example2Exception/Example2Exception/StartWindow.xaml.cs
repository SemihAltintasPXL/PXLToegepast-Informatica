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

namespace Example2Exception
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

        private void startApplicationButton_Click(object sender, RoutedEventArgs e)
        {// bij het klikken op deze button mag het startwindow niet meer zichtbaar zijn
         // bij sluiten van mainwindow moet startwindow terug zichtbaar zijn
            MainWindow mainWindow = new MainWindow(clientTextBox.Text, this);
            mainWindow.Show();
            
            clientTextBox.Text = "";
            startApplicationButton.IsEnabled = false;
        }

        private void clientTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            startApplicationButton.IsEnabled = true;
        }
    }
}
