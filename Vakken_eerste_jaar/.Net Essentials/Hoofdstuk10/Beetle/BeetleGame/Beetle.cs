using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BeetleGame
{
    public class Beetle
    {
        private Ellipse _body;
        private Canvas _canvas;


        private bool isVisible;  // deze instantievariabele is overbodig

        public bool IsVisible
        {
            private get { return isVisible; }
            set { isVisible = value; 
                if (IsVisible) // if (value) en dan de Visibility instellen
                {
                    _body.Visibility = Visibility.Visible;
                }
                else
                {
                    _body.Visibility = Visibility.Hidden;
                }
            }
        }

        public bool Right { get; set; }


        private int _size;
        public int Size
        {
            get { return _size; }
            set { _size = value; UpdateEllipse(); }
        }

        public double Speed { get; set; }
        public bool Up { get; set; }

        private int _x;
        public int X
        {
            get { return _x; }
            set { _x = value; UpdateEllipse(); }
        }

        private int _y;
        public int Y
        {
            get { return _y; }
            set { _y = value; UpdateEllipse(); }
        }

        public Beetle(Canvas canvas, int x, int y, int size)
        {
            CreateBeetle();
            _canvas = canvas;
            _canvas.Children.Add(_body);
            X = x;
            Y = y;
            Size = size;
            IsVisible = false;
            Up = true;
            Right = true;
        }

        public void CreateBeetle()
        {
            _body = new Ellipse
            {
                Fill = new SolidColorBrush(Colors.Red),
                Stroke = new SolidColorBrush(Colors.Red)
            };
        }
        private void ChangeDirection()
        {
            if (Y + (Size / 2) >= _canvas.Height)
            {
                Up = true;
            }
            else if (Y - (Size / 2) <= 0)
            {
                Up = false;
            }


            if (X + (Size / 2)  >= _canvas.Width)
            {
                Right = false;
            }
            else if (X - (Size / 2) <= 0)
            {
                Right = true;
            }
        }

        public void ChangePosition()
        {
            if (Speed > 0)
            {
                if (Up)
                {
                    Y -= 1;
                }
                else
                {
                    Y += 1;
                }

                if (Right)
                {
                    X += 1;
                }
                else
                {
                    X -= 1;
                }
                // waarom hieronder(R125 tem  R141)  niet vervangen door CHangeDirection? de testen die je hier doet
                // worden daar nogmaals uitgevoerd
                if (Y + (Size / 2) >= _canvas.Height)
                {
                    ChangeDirection();

                }
                else if (Y - (Size / 2) <= 0)
                {
                    ChangeDirection();
                }
                else if (X + (Size / 2) >= _canvas.Width)
                {
                    ChangeDirection();
                }
                else if (X - (Size / 2) <= 0)
                {
                    ChangeDirection();
                }
            }
           
        }

        public double ComputeDistance(DateTime time1, DateTime time2)
        { 
            double time = (time2 - time1).TotalSeconds;
            double distance = time * Speed / 100;
            return distance;
        }

        public void UpdateEllipse()
        {
            _body.Margin = new Thickness(X - (Size / 2), Y - (Size/2), 0, 0);
            _body.Height = Size;
            _body.Width = Size;
        }
    }
}
