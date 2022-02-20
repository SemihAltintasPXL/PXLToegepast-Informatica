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

namespace Opdracht17_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EmailChecker checker = new EmailChecker();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                checker.CheckAddress(emailTextBox.Text);
                MessageBox.Show("The email is valid!");
            }
            catch (InvalidEmailException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
