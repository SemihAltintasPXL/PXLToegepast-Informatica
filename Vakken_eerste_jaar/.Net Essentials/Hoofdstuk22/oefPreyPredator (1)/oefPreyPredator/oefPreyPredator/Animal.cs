using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace oefPreyPredator.Contracts
{// mag niet in de folder Contracts
    public abstract class Animal : IAnimal
    {
        private static Random _randomGenerator = new Random();
        private Canvas _canvas;
        private int maxleeftijd; // in het Engels + ovrbodig
        //private SolidColorBrush _brush; 
        private Color _color;
        private Position _position; // is overbodig je kan dit oplossen met een autoproperty
        private Ellipse _body;
        private double _widthCanvas; //???
        private double _heightCanvas; // ???

        public int Leeftijd { get; set; } // moet in het Engels
       // public Position position => _position;
       public Position Position { get; }
        // public bool IsDead { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsDead { get; set; }

        public int Maxleeftijd { get => maxleeftijd; set => maxleeftijd = value; } // kan een autoproperty zijn

     

        // public SolidColorBrush Brush { private get => _brush; set { _brush = value; } } // overbodige property

        //public Animal()
        //{

        //}
        public Animal(int maxLeeftijd, Color kleur): this(maxLeeftijd, kleur, new Position(_randomGenerator.Next(0, 16), _randomGenerator.Next(0, 16)))
            // in het Engels constructor op protected
        {
            //Maxleeftijd = maxLeeftijd;
            //_color = kleur;
            ////_position = new Position(_randomGenerator.Next(0, 15), _randomGenerator.Next(0, 15));
            //Position = new Position(_randomGenerator.Next(0, 16), _randomGenerator.Next(0, 16));
            ////DisplayOn(_canvas, kleur);
         
        }


        public Animal(int maxLeeftijd, Color kleur, Position position) // constructor op protected
        {
            Maxleeftijd = maxLeeftijd;
            _color = kleur;
            Position = position;
            //specifieke positie geven
        }

        public void DisplayOn(Canvas canvas)
        {
          //  _widthCanvas = canvas.Width;
          //  _heightCanvas = canvas.Height;
            _canvas = canvas;
            _body = new Ellipse
            {
                Stroke = new SolidColorBrush(_color),
                Fill = new SolidColorBrush(_color),
                Height = 5,
                Width = 5,
                Margin = new Thickness(Position.X * 10,  Position.Y * 10, 0, 0)
            };
            canvas.Children.Add(_body);
        }

        public void Move()
        {
            //Leeftijd = 1;
            Leeftijd++;
            if (Leeftijd > Maxleeftijd)
            {
                IsDead = true;
            }
            //Random random = new Random();
            int keuze = _randomGenerator.Next(1, 4); // in het Engels
            //gaat ook met een if
            switch (keuze)
            {
                case 1:
                    Position.MoveForward();
                    break;
                case 2:
                    Position.MoveBack();
                    break;
                case 3:
                    Position.MoveLeft();
                    break;
                case 4:
                    Position.MoveRight();
                    break;
            }
            UpdateDisplay();
        }

        public void StopDisplaying()
        {
            //_body = null;
            _canvas.Children.Remove(_body);
        }

        public abstract IAnimal TryBreed();


        public void UpdateDisplay()
        {
            _body.Margin = new Thickness(Position.X * 10, Position.Y * 10, 0, 0);
        }


    }
}
