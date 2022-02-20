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

namespace Example1Exception
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Oefening 17.1 uit handboek
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            resultTextBlock.Text = "";
        }

        private void computeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int number1 = Convert.ToInt32(numberATextBox.Text);
                int number2 = Int32.Parse(numberBTextBox.Text);
                double res1 = (double)number1 / number2;
                double res2 = (double)number2 / number1;
                resultTextBlock.Text = $"Division A/B {res1:F2} B/A {res2:0.00}";
            }
            catch (FormatException)
            {
                resultTextBlock.Text = "Numbers have to be integers";
            }
            catch (OverflowException ex)
            {
                resultTextBlock.Text = ex.Message;
                MessageBox.Show(ex.StackTrace);
            }

        }
    }
}
