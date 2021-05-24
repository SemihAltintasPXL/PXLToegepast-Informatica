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

namespace FirstExample
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

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            Rectangle upperRectangle = new Rectangle
            {
                Width = 100,
                Height = 50,
                Margin = new Thickness(10, 10, 0, 0),//plaats op canvas
                Stroke = new SolidColorBrush(Colors.Black), //kleur van de rand
                StrokeThickness = 3, //dikte van de lijn
                Fill = new SolidColorBrush(Colors.Red) //opvulkleur
            };
            paperCanvas.Children.Add(upperRectangle);

            //wat hier onder staat is zelfde als boven enkel rechtermuisknop op new endan die lampje
            Rectangle lowerRectangle = new Rectangle();
            lowerRectangle.Width = 100;
            lowerRectangle.Height = 100;
            lowerRectangle.Margin = new Thickness(10, 75, 0, 0);
            lowerRectangle.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(lowerRectangle);



        }
    }
}
