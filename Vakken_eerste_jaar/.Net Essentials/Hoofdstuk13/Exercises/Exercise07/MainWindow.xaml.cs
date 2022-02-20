using System;
using System.Collections.Generic;
using System.Windows;

namespace Exercise07
{
    public partial class MainWindow : Window
    {
        private List<string> months = new List<string> {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

        public MainWindow()
        {
            InitializeComponent();
        }        

        private void lookupButton_Click(object sender, RoutedEventArgs e)
        {
            

            int index = Convert.ToInt32(monthNumberTextBox.Text);
            monthNameTextBox.Text = months[index - 1];
        }
    }
}
