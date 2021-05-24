using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Raindrops
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random randomNumber = new Random();
        private SolidColorBrush brush;
        private DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            
            gapLabel.Content = Convert.ToString(gapSlider.Value);
            brush = new SolidColorBrush(Colors.Blue);
            timer.Interval = TimeSpan.FromMilliseconds(gapSlider.Value);
            timer.Tick += timer_Tick;
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            paperCanvas.Children.Clear();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            double x = randomNumber.Next(0, Convert.ToInt32(paperCanvas.Width));
            double y = randomNumber.Next(0, Convert.ToInt32(paperCanvas.Height));
            double size = randomNumber.Next(1, 40);

            var ellipse = new Ellipse() // impliciet getypeerde variabele
            // kan een lokale variabele zijn en declaratie en aanmaken moet 
            // in 1 regel gebeuren
            {
                Width = size,
                Height = size,
                Stroke = brush,
                Fill = brush,
                Margin = new Thickness(x, y, 0, 0)
            };
            paperCanvas.Children.Add(ellipse);

        }

        private void gapSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            // set new interval for timer best hier en niet zoals in de boekcode staat in de timer eventhandler
            
            int ms = randomNumber.Next(1, Convert.ToInt32(gapSlider.Value));
            // minimale waarde van slide moet minstens 2 zijn !!!
            timer.Interval = TimeSpan.FromMilliseconds(ms);
      
            int timeGap = Convert.ToInt32(gapSlider.Value);
            gapLabel.Content = Convert.ToString(timeGap);
        }
    }
}
