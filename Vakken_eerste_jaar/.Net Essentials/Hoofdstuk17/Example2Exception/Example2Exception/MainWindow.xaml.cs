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

namespace Example2Exception
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BankAccount _bankAccount;
        private StartWindow _startWindow;
        public MainWindow(string clientName, StartWindow startWindow)
        {
            InitializeComponent();
            _bankAccount = new BankAccount();
            depositTextbox.Text = "0";
            saldoTextBlock.Text = "saldo \t\t 0";
            Title = clientName;
            _startWindow = startWindow;
            _startWindow.Hide();
        }

        private void saldoButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int amount = Convert.ToInt32(depositTextbox.Text);
                if (amount >= 0)
                {
                    _bankAccount.Deposit(amount);
                }
                else
                {
                    _bankAccount.WithDraw(-amount);
                }
                saldoTextBlock.Text = $"saldo \t\t{_bankAccount.Saldo}";
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong input");
            }
            catch (BankException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _startWindow.Show();
        }
    }
}
