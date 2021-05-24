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

namespace Oefening5_15
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int input = Convert.ToInt32(inputSeconden.Text);
            ConvertSecondsToHoursMinutesSeconds(input);
        }
        public void ConvertSecondsToHoursMinutesSeconds(int seconden)
        {
            int input = seconden;
            int uren = seconden / 3600;
            seconden = seconden % 3600;
            int minuten = seconden / 60;
            seconden = seconden % 60;
            
            //seconden = seconden - ((minuten * 60) + (uren * 3600));
            MessageBox.Show(($"{input} seconden is {uren}, {minuten} en {seconden} seconden"));
        }
    }
}
