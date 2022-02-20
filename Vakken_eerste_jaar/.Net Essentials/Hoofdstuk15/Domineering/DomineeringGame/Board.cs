using System;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DomineeringGame
{
    internal class Board
    {
        private static readonly SolidColorBrush BlackBrush = new SolidColorBrush(Colors.Black);
        private static readonly SolidColorBrush RedBrush = new SolidColorBrush(Colors.Red);
        private static readonly SolidColorBrush BlueBrush = new SolidColorBrush(Colors.Blue);
        private Block[,] _blocks;
        private static double _widthAndHeigtOfOnSquare;
        private int _numberOfRowsAndColumns;

        public void CreateRoster(Canvas canvas, int numberOfRowsAndColumns)
        {
            double margin = canvas.Width - 14;
            _numberOfRowsAndColumns = numberOfRowsAndColumns;
            _blocks = new Block[numberOfRowsAndColumns, numberOfRowsAndColumns];

            //Not needed, margin correction
            for (int i = 0; i < numberOfRowsAndColumns + 1; i++)
            {
                Line vertLine = new Line();
                vertLine.Stroke = BlackBrush;
                vertLine.StrokeThickness = 2;
                vertLine.X1 = (margin / numberOfRowsAndColumns * i) + 7;
                vertLine.X2 = vertLine.X1;
                vertLine.Y1 = 7;
                vertLine.Y2 = canvas.Height - 7;
                canvas.Children.Add(vertLine);
            }

            for (int i = 0; i < numberOfRowsAndColumns + 1; i++)
            {
                Line horiLine = new Line();
                horiLine.Stroke = BlackBrush;
                horiLine.StrokeThickness = 2;
                horiLine.Y1 = (margin / numberOfRowsAndColumns * i) + 7;
                horiLine.Y2 = horiLine.Y1;
                horiLine.X1 = 7;
                horiLine.X2 = canvas.Height - 7;
                canvas.Children.Add(horiLine);
            }

            _widthAndHeigtOfOnSquare = (canvas.Width - 14 - ((numberOfRowsAndColumns + 1) * 2)) / numberOfRowsAndColumns;
            CreateBlocks(canvas);
        }

        private void CreateBlocks(Canvas canvas)
        {
            for (int i = 0; i < _blocks.GetLength(0); i++)
            {
                for (int j = 0; j < _blocks.GetLength(1); j++)
                {
                    _blocks[i, j] = new Block(i, j, _widthAndHeigtOfOnSquare);
                    canvas.Children.Add(_blocks[i, j].Rect);
                }
            }
        }

        public void ColorBlock(int row, int col, int player)
        {
            //CHECK CORRECT INPUT
            if (row < 0 || row > _numberOfRowsAndColumns - 1 || col < 0 || col > _numberOfRowsAndColumns - 1)
            {
                throw new DomineeringException("Click inside a valid part of the gameboard, please try again!");
            }

            //IF CORRECT, TEST IF PLACEMENT IS POSSIBLE
            if (IsCurrectMovePossible(row, col, player))
            {
                //PRESTEPS TO WRITE
                string destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string file = System.IO.Path.Combine(destination, "domineering.txt");
                StreamWriter s = File.AppendText(file);
                //COLOR BLOCK
                if (player == 1)
                {
                    ChangeColor(row, col, RedBrush);
                    ChangeColor(row + 1, col, RedBrush);
                    //WRITE
                    s.WriteLine($"Player {player} ({row},{col}) ({row + 1},{col})");
                }
                else
                {
                    ChangeColor(row, col, BlueBrush);
                    ChangeColor(row, col + 1, BlueBrush);
                    //WRITE
                    s.WriteLine($"Player {player} ({row},{col}) ({row},{col + 1})");
                }
                //IMPORTANT CLOSE!
                s.Close();
            }
            else
            {
                throw new DomineeringException("This move is not possible, please try another rectangle!");
            }

        }

        private void ChangeColor(int row, int col, SolidColorBrush brush)
        {
            _blocks[col, row].Rect.Fill = brush;
            _blocks[col, row].Rect.Stroke = brush;
        }

        //CHECKS EACH ROUND IF GAME IS OVER
        public bool IsAnyMovePossible(int player)
        {
            bool foundOpenSpace = false;
            if (player == 1)
            {
                //SEARCH FOR VERTICAL OPEN SPACES OF 2 LONG
                for (int j = 0; j < _blocks.GetLength(1) - 1; j++)
                {
                    for (int i = 0; i < _blocks.GetLength(0); i++)
                    {
                        if (!_blocks[i, j].IsUsedOnBoard && !_blocks[i, j + 1].IsUsedOnBoard)
                        {
                            foundOpenSpace = true;
                        }
                    }
                }
            }
            else
            {
                //SEARCH FOR HORIZONTAL OPEN SPACES OF 2 LONG
                for (int i = 0; i < _blocks.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < _blocks.GetLength(1); j++)
                    {
                        if (!_blocks[i, j].IsUsedOnBoard && !_blocks[i + 1, j].IsUsedOnBoard)
                        {
                            foundOpenSpace = true;
                        }
                    }
                }
            }

            if (foundOpenSpace)
            {
                return true;
            }

            return false;
        }

        public bool IsCurrectMovePossible(int row, int col, int player)
        {
            if (player == 1)
            {
                if (row == _numberOfRowsAndColumns - 1)
                {
                    //RETURN NOW OTHERWISE AN OUT-OF-BOUND-EXCEPTION WILL OCCUR
                    return false;
                }
                if (!_blocks[col, row].IsUsedOnBoard && !_blocks[col, row + 1].IsUsedOnBoard)
                {
                    //MOVE IS VALID SO MAKE BLOCKS USED AND OWNED
                    _blocks[col, row].IsUsedOnBoard = true;
                    _blocks[col, row].OwnedByPlayer = 1;
                    _blocks[col, row + 1].IsUsedOnBoard = true;
                    _blocks[col, row + 1].OwnedByPlayer = 1;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (col == _numberOfRowsAndColumns - 1)
                {
                    //RETURN NOW OTHERWISE A OUT-OF-BOUND-EXCEPTION WILL OCCUR
                    return false;
                }
                if (!_blocks[col, row].IsUsedOnBoard && !_blocks[col + 1, row].IsUsedOnBoard)
                {
                    //MOVE IS VALID SO MAKE BLOCKS USED AND OWNED
                    _blocks[col, row].IsUsedOnBoard = true;
                    _blocks[col, row].OwnedByPlayer = 2;
                    _blocks[col + 1, row].IsUsedOnBoard = true;
                    _blocks[col + 1, row].OwnedByPlayer = 2;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}