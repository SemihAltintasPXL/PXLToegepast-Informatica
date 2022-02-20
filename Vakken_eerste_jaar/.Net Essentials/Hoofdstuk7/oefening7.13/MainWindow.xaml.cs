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

namespace oefening7._13
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

        private void buttonBereken_Click(object sender, RoutedEventArgs e)
        {
            double nettoprijs = Convert.ToDouble(inputNettoPrijs.Text);
            double btwp = 0.21;
            double btw;
            double totaal;

            if (chkVerlaagdTarief.IsChecked == true)
            {
                btwp = 0.06;
                btw = nettoprijs * btwp;
                totaal = nettoprijs + btw;
            }else{
                btw = nettoprijs * btwp;
                totaal = nettoprijs + btw;
            }
            outputBtw.Text = Convert.ToString(btw);
            outputTotaal.Text = Convert.ToString(totaal);
        }
    }
}
