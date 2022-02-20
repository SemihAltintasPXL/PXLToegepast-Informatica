using System;
using System.Windows;
using System.Windows.Controls;

namespace Exercise07
{
    public partial class MainWindow : Window
    {

        private string vorigeOperator = "";
        private int vorigGetal = 0;
        private Boolean vorigeactieOperator = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void nummerButton_Click(object sender, RoutedEventArgs e)
        {
            if (outputTextBlock.Text.Equals("0"))
            {
                outputTextBlock.Text = outputTextBlock.Text.Substring(1);
            }
            if (vorigeactieOperator)
            {
                outputTextBlock.Text = "";
            }
            outputTextBlock.Text += ((Button)sender).Content;
            vorigeactieOperator = false;
        }

        private void operatorButton_Click(object sender, RoutedEventArgs e)
        {
            if (vorigeOperator == "")
            {
                vorigeOperator = Convert.ToString(((Button)sender).Content);
                vorigGetal = Convert.ToInt32(outputTextBlock.Text);
            } else
            {
                switch (vorigeOperator)
                {
                    case "+":
                        outputTextBlock.Text = Convert.ToString(vorigGetal + Convert.ToInt32(outputTextBlock.Text));
                        vorigeOperator = Convert.ToString(((Button)sender).Content);
                        vorigGetal = Convert.ToInt32(outputTextBlock.Text);
                        break;
                    case "-":
                        outputTextBlock.Text = Convert.ToString(vorigGetal - Convert.ToInt32(outputTextBlock.Text));
                        vorigeOperator = Convert.ToString(((Button)sender).Content);
                        vorigGetal = Convert.ToInt32(outputTextBlock.Text);
                        break;
                }
            }
            if (Convert.ToString(((Button)sender).Content) == "=")
            {
                vorigeOperator = "";
                vorigGetal = 0;
                vorigeactieOperator = false;
            }
            vorigeactieOperator = true;
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            vorigeOperator = "";
            vorigGetal = 0;
            outputTextBlock.Text = "0";
            vorigeactieOperator = false;
        }
    }
}
