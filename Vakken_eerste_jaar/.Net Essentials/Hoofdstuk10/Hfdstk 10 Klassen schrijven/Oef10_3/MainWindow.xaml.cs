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

namespace Oef10_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BankAccount bankAccount;
        public MainWindow()
        {
            InitializeComponent();
            bankAccount = new BankAccount();
            depositTextbox.Text = "0";
            saldoTextBlock.Text = "saldo \t\t 0";
        }

        private void saldoButton_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(depositTextbox.Text);
            if (amount >= 0)
            {
                bankAccount.Deposit(amount);
            } else
            {
                bankAccount.WithDraw(-amount);
            }
            saldoTextBlock.Text = $"saldo \t\t{bankAccount.Saldo}";
            if (bankAccount.Saldo < 0)
            {
                MessageBox.Show($"You are in red!!!");
            }
        }
    }
}
