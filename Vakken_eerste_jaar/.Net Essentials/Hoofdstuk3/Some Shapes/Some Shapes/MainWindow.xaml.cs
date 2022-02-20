using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Some_Shapes
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
            Rectangle upperLeftRectangle = new Rectangle();
            upperLeftRectangle.Width = 100;
            upperLeftRectangle.Height = 50;
            upperLeftRectangle.Margin = new Thickness(10, 10, 0, 0);
            upperLeftRectangle.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(upperLeftRectangle);

            Line lineInRectangle = new Line();
            lineInRectangle.X1 = 10; lineInRectangle.Y1 = 10;
            lineInRectangle.X2 = 110; lineInRectangle.Y2 = 60;
            lineInRectangle.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(lineInRectangle);

            Rectangle middleLeftRectangle = new Rectangle();
            middleLeftRectangle.Width = 100;
            middleLeftRectangle.Height = 50;
            middleLeftRectangle.Margin = new Thickness(10, 80, 0, 0);
            middleLeftRectangle.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(middleLeftRectangle);

            Ellipse ellipseInRectangle = new Ellipse();
            ellipseInRectangle.Width = 100;
            ellipseInRectangle.Height = 50;
            ellipseInRectangle.Margin = new Thickness(10, 80, 0, 0);
            ellipseInRectangle.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(ellipseInRectangle);

            Ellipse lowerLeftEllipse = new Ellipse();
            lowerLeftEllipse.Width = 100;
            lowerLeftEllipse.Height = 50;
            lowerLeftEllipse.Margin = new Thickness(10, 150, 0, 0);
            lowerLeftEllipse.Fill = new SolidColorBrush(Colors.Gray);
            paperCanvas.Children.Add(lowerLeftEllipse);

            BitmapImage demoBitmapImage = new BitmapImage();
            demoBitmapImage.BeginInit();
            demoBitmapImage.UriSource = new Uri("logo_pxl_digital.png", UriKind.RelativeOrAbsolute);
            //demoBitmapImage.UriSource = new Uri(@"C:\Users\MMsem\net essentials\Hoofdstuk3\Some Shapeslogo_pxl_digital.png",
            //                   UriKind.RelativeOrAbsolute); //gebruik nooit een absoluut adres op examen
            demoBitmapImage.EndInit();
            Image rightImage = new Image();
            rightImage.Source = demoBitmapImage;
            rightImage.Margin = new Thickness(120, 10, 0, 0);
            rightImage.Width = 150;
            rightImage.Height = 150;
            paperCanvas.Children.Add(rightImage);
            //testvraag 3.2 cirkel op plaats (10,10) met straal = 50
            Ellipse circle = new Ellipse
            {
                Width = 100,
                Height = 100,
                Margin = new Thickness(10, 10, 0, 0),
                Stroke = new SolidColorBrush(Colors.Black),
                Fill = new SolidColorBrush(Colors.Red)
            };
            paperCanvas.Children.Add(circle);
            //dit is een "default constructor"
            //testvraag 3.3
            Line horizontalLine = new Line
            {
                X1 = 10,
                Y1 = 210,
                X2 = 110,
                Y2 = 210,
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 3
            };
            paperCanvas.Children.Add(horizontalLine);
            Line verticalLine = new Line
            {
                X1 = 60,
                Y1 = 210,
                X2 = 60,
                Y2 = 260,
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 3
            };
            paperCanvas.Children.Add(verticalLine);

        }
    }
}
