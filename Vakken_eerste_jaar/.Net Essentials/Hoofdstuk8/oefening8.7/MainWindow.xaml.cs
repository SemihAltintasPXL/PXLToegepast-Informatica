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

namespace oefening8._7
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int getal = Convert.ToInt32(txtGetal.Text);
            for (int i = 0; i <= getal; i++)
            {
                txtResultaat.Text += (i + "\t");
                for (int j = 1; j <= getal; j++)
                {
                    if (i > 0)
                    {
                        txtResultaat.Text += (i * j + "\t");
                    }
                    
                    else
                    {
                        txtResultaat.Text += (j + "\t");
                    }
                    
                }
                txtResultaat.Text += ("\n");
            }
        }
    }
}
