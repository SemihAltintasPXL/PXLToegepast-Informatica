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

namespace Triangle
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
        //hoe code leesbaarder maken?
        //zinvolle namen
        //commentaar
        // gebruik maken van functies/methodes
        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brushToUse = new SolidColorBrush(Colors.Black);
            DrawTriangle(paperCanvas, brushToUse, 20, 80, 70, 10, 120, 80);
        }
        private void DrawTriangle(Canvas canvas, SolidColorBrush brush, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            /* draw a triangle
             first line */
            DrawLine(paperCanvas, brush, x1, y1, x2, y2);
            // second line
            DrawLine(paperCanvas, brush, x2, y2, x3, y3);
            // third line
            DrawLine(paperCanvas, brush, x3, y3, x1, y1);
        }
        private void DrawLine(Canvas canvas, SolidColorBrush brush, int x1, int y1, int x2, int y2)
        {
            Line line = new Line

            {
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2,
                Stroke = brush
            };
            canvas.Children.Add(line);
        }
    }
}
