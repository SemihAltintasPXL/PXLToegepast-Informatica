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

namespace oefening4._9
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

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            int amountGiven = Convert.ToInt32(inputAmountGiven.Text);
            int itemcost = Convert.ToInt32(inputCost.Text);
            
            int resultaat = amountGiven - itemcost;
            int euro, vijftig, twintig, tien, vijf, twee, een;
            euro = resultaat / 100;
            resultaat = resultaat % 100;
            vijftig = resultaat / 50;
            resultaat = resultaat % 50;
            twintig = resultaat / 20;
            resultaat = resultaat % 20;
            tien = resultaat / 10;
            resultaat = resultaat % 10;
            vijf = resultaat / 5;
            resultaat = resultaat % 5;
            twee = resultaat / 2;
            een = resultaat % 2;
            MessageBox.Show( ($"{euro}euro {vijftig} vijftig cents {twintig} twintig cents{tien}tien cents {vijf}vijf cents{twee}twee cents {een}een cents"));
            //MessageBox.Show($"return amount in cents{resultaat}");




        }
    }
}
