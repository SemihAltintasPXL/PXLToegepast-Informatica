using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BalloonApp
{
    public class Balloon
    {   // instantie eigenschappen 
        private int x = 50; // private => data hiding = incapsulation
        private int y = 50;
        private int diameter = 20;
        private Ellipse ellipse;
        private SolidColorBrush brush = new SolidColorBrush(Colors.Blue);
        // klasse eigenschappen => hoort bij de klasse niet bij een instantie
        // tellen hoe vaak de methode MoveRight werd opgeroepen
        //private static int countMoveRight;
        // opdracht xx: bij aanmaken van een balloon => eerste balloon de naam balloon01; 2de keer balloon02, ...
        private static int count;
        // getters en setters in Java = properties in C#
        // gebruik nooit een getter of een setter!!!
        public int X
        {
            get { return x; }
            set { x = value; UpdateEllipse(); }
        }

        public int Y
        {
            get => y; // idem als R21 lambdaoperator
            set { y = value; UpdateEllipse(); }
        }

        // Write only property => gebruiker in andere klasse kan de waarde van
        // deze property niet wijzigen
        public int Diameter
        {
            private get => diameter; // get kan alleen gebruikt worden
            // in deze klasse => hierdoor kan je de property diameter
            // in een andere methode wijzigen
            set { diameter = value; UpdateEllipse(); }
        }
        // Read only property gebruiken in andere klasse kan de waarde alleen maar opvragen
        public double Area
        {
            get => CalculateArea();
        }
        // kortere versie public double Area => CalculateArea();
        // write only property om de kleur te wijzigen
        public Color Color { set { brush.Color = value; } }

        // zoveel mogelijk gebruik maken van autoproperties
        //public string Name { get; set; }
        public string Name { get; } // bij opdracht xx read only property  waarde voor Name kan alleen in de constructor gegeven worden
        // klasse property voor het opvragen van countMoveRight
        // read only property
        //public static int CountMoveRight
        //{
        //    get { return countMoveRight; }
        //}
        // Kan je een read only autoproperty aanmaken voor CountMoveRight?
        public static int CountMoveRight
        {
            get; private set;
        }
        // constructor =  methode om een object aan te maken  
        // + het initialiseren van alle instantieeigenschappen
        // meerdere constructors in dezeflde klasse  = constructor overloading
        //public Balloon()
        //{
        //    CreateEllipse();
        //    UpdateEllipse();
        //}

        //public Balloon(int initialX) : this(initialX, 50, 20)
        //// in deze constructor een andere constructor oproepen
        //{

        //}

        //public Balloon(int initialX, int initialY)
        //{
        //    x = initialX;
        //    y = initialY;
        //    CreateEllipse();
        //    UpdateEllipse();
        //}

        //public Balloon(int initialX,
        //               int initialY,
        //               int initialDiameter)
        //{
        //    x = initialX;
        //    y = initialY;
        //    diameter = initialDiameter;

        //    CreateEllipse();
        //    UpdateEllipse();
        //} voorgaande is eigenlijk allemaal overbodige code je kan dit vervangen door 1 constructor
        // oplosing => optionele parameters gebruiken
        public Balloon(int initialX = 50,
                       int initialY = 50,
                       int initialDiameter = 20)
        {
            x = initialX;
            y = initialY;
            diameter = initialDiameter;
            count++;
            Name = $"balloon{count:D2}";
            CreateEllipse(); UpdateEllipse();


        }
        // methoden(altijd eerste de publi nadien de private methoden)
        public void ChangeColor(Color color)
        {
            brush.Color = color;
        }
        public void MoveRight(int xStep)
        {
            X += xStep;
            // UpdateEllipse(); overbodig zie definitie property X
            CountMoveRight++;
        }

        public void ChangeSize(int change)
        {
            Diameter += change;

        }

        public void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(ellipse);
        }


        private double CalculateArea()
        {
            double radius;
            radius = diameter / 2.0;
            return Math.PI * radius * radius;
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse()
            {
                Stroke = brush,
                StrokeThickness = 2
            };
        }

        private void UpdateEllipse()
        {
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Width = diameter;
            ellipse.Height = diameter;
        }

    }
}
