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
using System.Windows.Shapes;

namespace Example1Exception
{
    /// <summary>
    /// Interaction logic for WindowInteger.xaml
    /// </summary>
    public partial class WindowInteger : Window
    {
        public WindowInteger()
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
                int res1 = number1 / number2;
                int res2 = number2 / number1;
                resultTextBlock.Text = $"Division A/B {res1} B/A {res2}";
            }
            catch (FormatException)
            {
                resultTextBlock.Text = "Numbers have to be integers";
            }
            //catch (OverflowException ex)
            //{
            //    resultTextBlock.Text = ex.Message;
            //    MessageBox.Show(ex.StackTrace);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    resultTextBlock.Text = ex.Message;
            //    MessageBox.Show(ex.StackTrace);
            //}
            catch (ArithmeticException ex)
            {
                resultTextBlock.Text = ex.Message;
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
