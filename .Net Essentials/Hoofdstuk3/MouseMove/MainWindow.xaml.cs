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

namespace MouseMove
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

        private void paperCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            // positie opvragen van waar de muis zich bevindt relatief tov het Canvas 
            // canvas moet een achtergrondkleur hebben
            Point position = e.GetPosition(paperCanvas);
            // X en Y coördinaat in textblock plaatsen
            outputTextBlock.Text = "X: " + position.X + " Y: " + position.Y;
            // positie tov mainwindow?
            Point positionWindow = e.GetPosition(this);
            outputWindowTextBlock.Text = "X: " + positionWindow.X + " Y: " + positionWindow.Y;
        }
    }
}
