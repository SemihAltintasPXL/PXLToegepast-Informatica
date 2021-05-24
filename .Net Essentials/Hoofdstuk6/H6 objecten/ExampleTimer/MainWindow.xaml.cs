using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ExampleTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ellipse circle;
        private Random random = new Random();
        private DispatcherTimer timer;
        private int count; // als je het aantal seconden wil weten tussen start en stop

        public MainWindow()
        {
            InitializeComponent();
            CreateCircle();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1); // snelheid 1 tik per seconde
            //timer.Interval = TimeSpan.FromMilliseconds(100); // 10 ticks per seconde
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateCircle();
            count++;
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

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            
            circle.Visibility = Visibility.Visible;
            timer.Start();
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

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            circle.Visibility = Visibility.Hidden;
            timer.Stop();
            MessageBox.Show($"het aantal seconden tussen starten en stoppen {count}.")
            count = 0;
        }
    }
}
