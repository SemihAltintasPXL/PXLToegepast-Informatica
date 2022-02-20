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

namespace oefening6._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        private int randomgetal;
        private double som;
        private double average;
        private double aantal;
        
        
        public MainWindow()
        {
            InitializeComponent();
            txtNumber.IsEnabled = false;
            
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            
            randomgetal = random.Next(200, 400);
            aantal++;
            txtNumber.Text = Convert.ToString(randomgetal);
            som += randomgetal;
            txtSum.Text = Convert.ToString(som);
            average = som / aantal;
            txtAverage.Text = Convert.ToString(average);
            
        }
    }
}
