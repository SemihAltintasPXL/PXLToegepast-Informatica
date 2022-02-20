using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ExampleTimer
{
   // vertrekkend van ExampleTimer uit H6
   // er moeten 25 cirkels verschijnen per seconde
   // Hoeveel tijd is er tussen het klikken op de start button en de stopButton?
   // uitgedrukt in ... sec en ... millisec  // uitgedrukt in /// miliseconds
   // manier1 => stopwatch gebruiken
   // manier2 => met DateTime
    public partial class MainWindow : Window
    {
        private Ellipse circle;
        private Random random = new Random();
        private DispatcherTimer timer;
        private Stopwatch stopwatch = new Stopwatch();
        private DateTime startTime;
       

        public MainWindow()
        {
            InitializeComponent();
            CreateCircle();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000/25); // 25 tiks per seconde
           
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateCircle();
          
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
            stopwatch.Start();
            startTime = DateTime.Now;

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
            DateTime endTime = DateTime.Now;
            TimeSpan duration2 = endTime - startTime;
            stopwatch.Stop();
            TimeSpan durationStopWatch = stopwatch.Elapsed;
            MessageBox.Show($"Stopwatch: {durationStopWatch.Seconds} sec {durationStopWatch.Milliseconds} millisec of in totaal {durationStopWatch.TotalMilliseconds} millsec");
            MessageBox.Show($"manier2 : {duration2.Seconds} sec {duration2.Milliseconds} millisec of in totaal {duration2.TotalMilliseconds} millsec"); 
        }
    }
}
