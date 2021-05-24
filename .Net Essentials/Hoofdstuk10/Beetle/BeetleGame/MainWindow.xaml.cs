using System;

using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace BeetleGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Beetle _beetle;
        private DateTime _startTime;
        private int _xStart;
        private int _yStart;
        private DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            GenerateStartPosition();
            InitializeBeetle();
            sizeSlider.Value = 10;
            sizeSlider.ValueChanged += sizeSlider_ValueChanged;
            speedSlider.ValueChanged += speedSlider_ValueChanged;
            speedSlider.Value = 0.5;
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromMilliseconds(100 / speedSlider.Value * sizeSlider.Value / 10);

        }
        

        private double computeDistance(int x1, int x2, int y1, int y2) // waar gebruik je deze methode?
        {  // formule die je dient te gebruiken
            double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            // de formule die je hieronder gebruikt doet hetzelfde maar om deze te begrijpen heb je 
            // normaal gezien meer wiskunde nodig dan dat je in het middelbaar ehad hebt
            Point p = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            double dist = Point.Subtract(p2, p).Length;
            //double distance = 0;   ??? heeft hier niets mee te maken
            //return distance = _beetle.ComputeDistance(_startTime, DateTime.Now); // ??? heeft hier niets mee te maken
            return dist;
        }

        private void GenerateStartPosition()
        {
            bool noFaults = false;
            Random random = new Random();  
            while (!noFaults)
            {
                _xStart = random.Next(31,Convert.ToInt32(paperCanvas.Width - 30));
                _yStart = random.Next(31, Convert.ToInt32(paperCanvas.Height - 30));
                int distance = Convert.ToInt32(Math.Sqrt(Math.Pow((_xStart - paperCanvas.Width / 2), 2) + Math.Pow((_yStart - paperCanvas.Height / 2), 2)));
                // als je de methode R35 definieert zou ik deze ook in voorgaande regel gebruiken
                if (distance > 100)
                {
                    noFaults = true;
                }
            }
        }

        private void InitializeBeetle()
        {
            _beetle = new Beetle(paperCanvas, _xStart, _yStart, (int)sizeSlider.Value);
            _beetle.Speed = speedSlider.Value;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _beetle.ChangePosition();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            if (startButton.Content.Equals("Start"))
            {
                startButton.Content = "Stop";
                _beetle.IsVisible = true;
                sizeSlider.IsEnabled = false;
                speedSlider.IsEnabled = false;
                timer.Start();
                // starttime instellen
            }
            else
            {
                startButton.Content = "Start";
                //afstand tonen
                // hier methode ComputeDistance gebruiken van de klasse beetle. De distance heeft temaken met de totale
                // tijd die de beetle heeft bewogen
                string output = $"The total distance in meter {computeDistance(_xStart, _yStart, _beetle.X, _beetle.Y)}";
                messageLabel.Content = output;
                sizeSlider.IsEnabled = true;
                speedSlider.IsEnabled = true;
                timer.Stop();
            }
            
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            sizeSlider.Value = sizeSlider.Minimum; // speedlabel, sizelabel  aanpassen
            speedSlider.Value = speedSlider.Minimum;
            _beetle.Up = true;
            _beetle.Right = true;
            _beetle.IsVisible = false;
            messageLabel.Content = "";
            startButton.Content = "Start"; // nieuwe startpositie genereren
        }

        private void upButton_Click(object sender, RoutedEventArgs e)
        {
            _beetle.Up = true;
           // _beetle.Right = false; moet weg heeft niets met Up te maken
        }

        private void leftButton_Click(object sender, RoutedEventArgs e)
        {
            //  _beetle.Up = false; moet weg heeft niets met left te maken
            _beetle.Right = false;
        }

        private void rightButton_Click(object sender, RoutedEventArgs e)
        {
            // _beetle.Up = false; moet weg heeft niets met left te maken
            _beetle.Right = true;
        }

        private void donwButton_Click(object sender, RoutedEventArgs e)
        {
            _beetle.Up = false;
            //_beetle.Right = false; moet weg heeft niets met down te maken
        }

        private void speedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            speedLabel.Content = speedSlider.Value;
            _beetle.Speed = speedSlider.Value;
            timer.Interval = TimeSpan.FromMilliseconds(100 / speedSlider.Value * sizeSlider.Value / 10);

        }

        private void sizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sizeLabel.Content = sizeSlider.Value;
            _beetle.Size = (int)sizeSlider.Value;
            timer.Interval = TimeSpan.FromMilliseconds(100 / speedSlider.Value * sizeSlider.Value / 10);
        }
    }
};

