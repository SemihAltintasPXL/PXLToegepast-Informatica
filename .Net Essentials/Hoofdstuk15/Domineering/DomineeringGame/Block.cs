using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DomineeringGame
{
    class Block
    {
        public bool IsUsedOnBoard { get; set; } = false;
        public int OwnedByPlayer { get; set; } //0 = not owned, 1 = player 1, 2 = player 2
        public Rectangle Rect = new Rectangle();
        private static readonly SolidColorBrush WhiteBrush = new SolidColorBrush(Colors.White);

        public Block(int row, int col, double widthAndHeigtOfOnSquare)
        {
            double marginX = 7 + ((row + 1) * 2) + (row * widthAndHeigtOfOnSquare);
            double marginY = 7 + ((col + 1) * 2) + (col * widthAndHeigtOfOnSquare);
            Rect.Width = widthAndHeigtOfOnSquare;
            Rect.Height = widthAndHeigtOfOnSquare;
            Rect.Fill = WhiteBrush;
            Rect.Stroke = WhiteBrush;
            //Rect.Stroke = new SolidColorBrush(Colors.Black);
            Rect.Margin = new Thickness(marginX, marginY, 0, 0);
        }
    }
}
