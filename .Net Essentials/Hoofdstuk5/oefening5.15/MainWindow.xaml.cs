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

namespace oefening5._15
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

        private void buttontoBinary_Click(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(inputNumber.Text);
            
            outputBinary.Content = ConvertNumberToBinary(number);
        }
        private String ConvertNumberToBinary(int getal)
        {
            int eerste, tweede, derde, vierde, vijfde, zesde, zevende, achtste;
            eerste = getal / 128;
            getal = getal % 128;
            tweede = getal / 64;
            getal = getal % 64;
            derde = getal / 32;
            getal = getal % 32;
            vierde = getal / 16;
            getal = getal % 16;
            vijfde = getal / 8;
            getal = getal % 8;
            zesde = getal / 4;
            getal = getal % 4;
            zevende = getal / 2;
            getal = getal % 2;
            achtste = getal;
            String result = $"{eerste}{tweede}{derde}{vierde}  {vijfde}{zesde}{zevende}{achtste}";
            return result;

        }
    }
}
