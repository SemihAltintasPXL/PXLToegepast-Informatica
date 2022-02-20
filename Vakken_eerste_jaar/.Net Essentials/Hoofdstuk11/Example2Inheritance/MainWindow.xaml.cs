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

namespace Example2inheritance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Sphere sphere;
        private ColoredSphere coloredSphere;
        private Square square;
        private Triangle triangle;
        public MainWindow()
        {
            InitializeComponent();
        }
        // bij 1ste klik sphere aanmaken + op canvas zetten
        // volgende kliks sphere verplaatsen
        private void sphereButton_Click(object sender, RoutedEventArgs e)
        {
            if (sphere == null)
            {
                sphere = new Sphere(50, 50, 60);
                sphere.DisplayOnCanvas(paperCanvas);
            } else
            {
                sphere.Move();
            }
            outputTextBlock.Text = sphere.ToString();
        }
        // 1ste klik aanmaken en op canvas zetten
        // volgende kliks verplaatsen 
        private void ColoredSphereButton_Click(object sender, RoutedEventArgs e)
        {    if (coloredSphere == null)
            {
                coloredSphere = new ColoredSphere(100, 100, new SolidColorBrush(Colors.Red));
                coloredSphere.DisplayOnCanvas(paperCanvas);
            } else
            {
                coloredSphere.Move();
            }
            outputTextBlock.Text = coloredSphere.ToString();
        }
        // 1ste klik aanmaken en op canvas zetten
        // volgende kliks verplaatsen  + vergroot met 10 pixels
        private void squareButton_Click(object sender, RoutedEventArgs e)
        {
            if (square == null)
            {
                square = new Square()
                {
                    X = 15,
                    Y = 15,
                    Height = 20
                };
                square.DisplayOnCanvas(paperCanvas);
            }
            else
            {
                square.MoveRight();
                square.Height += 10;
            }
            outputTextBlock.Text = square.ToString();
        }
        // 1ste klik aanmaken en op canvas zetten
        // volgende kliks verplaatsen 
        private void triangleButton_Click(object sender, RoutedEventArgs e)
        {
            if (triangle == null)
            {
                triangle = new Triangle()
                {
                    X = 150,
                    Y = 150,
                    Height = 60,
                    Width = 50
                };
                triangle.DisplayOnCanvas(paperCanvas);
            } else
            {
                triangle.MoveRight();
            }
            outputTextBlock.Text = triangle.ToString();
        }
    }
}
