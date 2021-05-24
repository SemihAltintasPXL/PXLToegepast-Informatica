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

namespace Example2Polymorfisme
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// vertrekkend van Example1Interfaces => bijkomende button voorzien voor een image
    /// nodige aanpassingen doen zodat je zo weinig mogelijk moet aanpassen in de mainwindow
    /// => interface aanmaken!!!
    public partial class MainWindow : Window
    {
        private IDrawable [] things = new IDrawable[5]; // ploymorfisme
        private bool[] onCanvas = new bool[5];
        private Random random = new Random();
     
        public MainWindow()
        {
            InitializeComponent();
            CreateShapes();
            LinkHandlers();
        }
        private void CreateShapes()
        {
          
            things[0] = new Sphere(50, 50, 60);
            // koppeling gebeurt tijdens de uitvoering =  late binding =  dynamic dispatch
            things[1] = new ColoredSphere(100, 100, new SolidColorBrush(Colors.Red));
            things[2] = new Square()
            {
                X = 15,
                Y = 15,
                Height = 20
            };
            things[3] = new Triangle()
            {
                X = 150,
                Y = 150,
                Height = 60,
                Width = 50
            };
            things[4] = new Picture
            {
                X = 20,
                Y = 100,
                Height = 30,
                Width = 70
            };
                
        }
        private void LinkHandlers()
        {
            _0sphereButton.Click += Button_Click;
            _1coloredSphereButton.Click += Button_Click;
            _2squareButton.Click += Button_Click;
            _3triangleButton.Click += Button_Click;
            _4imageButton.Click += Button_Click;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender; // of sender as Button
            int place = Convert.ToInt32(button.Name.Substring(1, 1));
            if (onCanvas[place])
            {
                double factor = random.Next(5, 20) / 10.0;
                things[place].Scale(factor);
                if (things[place] is Sphere) // Java instanceof
                {
                    ((Sphere)things[place]).Move();
                   // of  (shapes[place] as Sphere).Move();
                }
                else
                {// van de square de hoogte met 10 vermeerderen
                    if (things[place] is Square)
                    {
                        things[place].Height += 10;
                    }
                    things[place].MoveRight();
                }
               
            } else
            { 
                things[place].DisplayOnCanvas(paperCanvas);
                onCanvas[place] = true;
            }
            outputTextBlock.Text = things[place].ToString();
        }

       
               
          
    }
}
