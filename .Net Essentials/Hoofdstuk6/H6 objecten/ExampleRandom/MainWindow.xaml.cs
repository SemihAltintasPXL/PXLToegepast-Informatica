using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ExampleRandom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ellipse circle;
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            CreateCircle();
        }

        private void CreateCircle()
        {
            circle = new Ellipse
            {
                Stroke = new SolidColorBrush(Colors.Black), // zwarte randkleur
                Fill = new SolidColorBrush(Colors.Blue), // blauw opgevuld
                Visibility = Visibility.Hidden
            };
            paperCanvas.Children.Add(circle);
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
              UpdateCircle();
            circle.Visibility = Visibility.Visible;
        }

        private void UpdateCircle()
        {
            // random x
            int x = random.Next(0, Convert.ToInt32(paperCanvas.Width));
            // random y
            int y = random.Next(0, Convert.ToInt32(paperCanvas.Height));
            // random straal >=1 en <=100
            int diameter = random.Next(1, 101) * 2;
            circle.Margin = new Thickness(x, y, 0, 0);
            circle.Width = diameter;
            circle.Height = diameter;
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            circle.Visibility = Visibility.Hidden;

        }
    }
}
