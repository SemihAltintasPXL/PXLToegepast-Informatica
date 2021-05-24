using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SecondDrawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rectangle upperRectangle;
        private Rectangle lowerRectangle;

        public MainWindow()
        {
            InitializeComponent();
            upperRectangle = new Rectangle
            {
                Width = 100,
                Height = 50,
                Margin = new Thickness(10, 10, 0, 0),//plaats op canvas
                Stroke = new SolidColorBrush(Colors.Black), //kleur van de rand
                StrokeThickness = 3, //dikte van de lijn
                Fill = new SolidColorBrush(Colors.Red), //opvulkleur
                Visibility = Visibility.Hidden
            };
            paperCanvas.Children.Add(upperRectangle);

            lowerRectangle = new Rectangle
            {
                Width = 100,
                Height = 100,
                Margin = new Thickness(10, 75, 0, 0),
                Stroke = new SolidColorBrush(Colors.Black),
                Visibility = Visibility.Hidden

            };
            paperCanvas.Children.Add(lowerRectangle);
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            upperRectangle.Visibility = Visibility.Visible;
            lowerRectangle.Visibility = Visibility.Visible;

        }

        private void dissapearButton_Click(object sender, RoutedEventArgs e)
        {
            upperRectangle.Visibility = Visibility.Hidden;
            lowerRectangle.Visibility = Visibility.Hidden;
        }
    }
}
