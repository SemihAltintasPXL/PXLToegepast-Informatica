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
using System.Windows.Threading;

namespace oefening6._6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rectangle rectangle;
        private Rectangle rectangle2;
        private DispatcherTimer timer;
        private int count;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(200);
            timer.Tick += Timer_Tick;
            timer.Start();
            //rectangle.MaxWidth = 60;
            CreateRectangleSeconds();
            CreateRectangleMinutes();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateRectangle();
            count++;
        }

        private void CreateRectangleSeconds()
        {
            rectangle = new Rectangle
            {
                Width = 0,
                Height = 50,
                Fill = new SolidColorBrush(Colors.Black),
                Margin = new Thickness(0, 150, 0, 0)
            };
            paperCanvas.Children.Add(rectangle);
        }
        private void CreateRectangleMinutes()
        {
            rectangle2 = new Rectangle
            {
                Width = 0,
                Height = 50,
                Fill = new SolidColorBrush(Colors.Black),
                Margin = new Thickness(0, 50, 0, 0)
            };
            paperCanvas.Children.Add(rectangle2);
        }
        private void UpdateRectangle()
        {
            rectangle.Width = count + 10;
            if (rectangle.Width == 60)
            {
                rectangle2.Width += 10;
                rectangle.Width = 0;
                count = 0;
            }
        }
    }
}
