using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SecondDrawingBis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            upperRectangle.Visibility = Visibility.Hidden;
            lowerRectangle.Visibility = Visibility.Hidden;
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            upperRectangle.Visibility = Visibility.Visible;
            lowerRectangle.Visibility = Visibility.Visible;
            logoImage.Visibility = Visibility.Visible;

        }

        private void dissapearButton_Click(object sender, RoutedEventArgs e)
        {
            upperRectangle.Visibility = Visibility.Hidden;
            lowerRectangle.Visibility = Visibility.Hidden;
            logoImage.Visibility = Visibility.Hidden;
        }
    }
}
