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
{
    public abstract class Animal : IAnimal
    {
        private static Random _randomGenerator = new Random();
        private Canvas _canvas;
        private int maxleeftijd;
        private SolidColorBrush _brush;
        private Position _position;
        private Ellipse _body;
        private double _widthCanvas;
        private double _heightCanvas;

        public int Leeftijd { get; set; }
        public Position position => _position;
        public bool IsDead { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public int Maxleeftijd { get => maxleeftijd; set => maxleeftijd = value; }
        public SolidColorBrush Brush { private get => _brush; set { _brush = value; } }

        public Animal()
        {

        }
        public Animal(int maxLeeftijd, Color kleur)
        {
            Maxleeftijd = maxLeeftijd;
            kleur = Colors.Black;
            _position = new Position(_randomGenerator.Next(0, 15), _randomGenerator.Next(0, 15));
            DisplayOn(_canvas, kleur);
        }


        public Animal(int maxLeeftijd, Color kleur, Position position)
        {

            //specifieke positie geven
        }

        public void DisplayOn(Canvas canvas, Color color)
        {
            _widthCanvas = canvas.Width;
            _heightCanvas = canvas.Height;
            _body = new Ellipse
            {
                Stroke = new SolidColorBrush(color),
                Fill = new SolidColorBrush(color),
                Height = 5,
                Width = 5,
                Margin = new Thickness(position.X * _widthCanvas / 15.0, position.Y * _heightCanvas / 15.0, 0, 0)
            };
            canvas.Children.Add(_body);
        }

        public void Move()
        {
            Leeftijd = 1;
            Leeftijd++;
            if (Leeftijd > Maxleeftijd)
            {
                IsDead = true;
            }
            Random random = new Random();
            int keuze = random.Next(1, 4);
            //gaat ook met een if
            switch (keuze)
            {
                case 1:
                    position.MoveForward();
                    break;
                case 2:
                    position.MoveBack();
                    break;
                case 3:
                    position.MoveLeft();
                    break;
                case 4:
                    position.MoveRight();
                    break;
            }
            UpdateDisplay();
        }

        public void StopDisplaying()
        {
            _body = null;
            
        }

        public abstract IAnimal TryBreed();


        public void UpdateDisplay()
        {
            _body.Margin = new Thickness(position.X * _widthCanvas / 15.0, position.Y * _heightCanvas / 15.0, 0, 0);
        }


    }
}
