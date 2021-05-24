using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Bouncing_Ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private Ellipse ball;
        private int xChange = 10;
        private int yChange = 4;

        private double x = 10;
        private double y = 10;
        private double diameter = 15;
        private int count = 0; // telt het aantal tikken


        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            // bal beweegt aan een snelhid van 2 tikken per seconde
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += Timer_Tick;
            DrawBall(x, y, diameter);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 200)
            {
                timer.Stop();
            } else
            {
                MoveBall();
            }
           
        }

        private void ballCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            timer.Start();
            DrawBall(x, y, diameter);
    
            ball.Visibility = Visibility.Visible;
        }

        private void MoveBall()
        {
            if ((x <= 0) || (x >= ballCanvas.Width))
            {
                xChange = -xChange;
            }
            if ((y <= 0) || (y >= ballCanvas.Height))
            {
                yChange = -yChange;
            }

            x = x + xChange;
            y = y + yChange;
            ball.Margin = new Thickness(x, y, 0, 0);
        }

        private void DrawBall(double x, double y, double diameter)
        {
            ball = new Ellipse()
            {
                Stroke = new SolidColorBrush(Colors.Blue),
                Width = diameter,
                Height = diameter,
                Margin = new Thickness(x, y, 0, 0),
                Visibility = Visibility.Hidden
            };
            ballCanvas.Children.Add(ball);
        }
    }
}
