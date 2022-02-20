using System;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace DomineeringGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private Board _gameBoard = new Board();
        private int _player = 1; //1 FOR PLAYER 1, 2 FOR PLAYER 2
        private int _row;
        private int _column;
        private const int NumberOfRowsAndColumns = 8;

        public MainWindow()
        {
            InitializeComponent();

            //FIRST THINGS TO DO
            _gameBoard.CreateRoster(gameCanvas, NumberOfRowsAndColumns);
        }

        private void startAGameMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ResetGame();
            //ENABLE MOVES
            gameCanvas.MouseDown -= GameCanvas_OnMouseDown;
            gameCanvas.MouseDown += GameCanvas_OnMouseDown;
            //DISPLAY PLAYER
            _player = 1;
            DisplayPlayer();
        }

        private void ResetGame()
        {
            gameCanvas.Children.Clear();
            _gameBoard = null;
            _gameBoard = new Board();
            _gameBoard.CreateRoster(gameCanvas, NumberOfRowsAndColumns);
            movesMenuItem.IsEnabled = false;

            //EMPTY FILE
            string destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string file = System.IO.Path.Combine(destination, "domineering.txt");
            StreamWriter s = File.CreateText(file);
            s.Close();
        }

        private void DisplayPlayer()
        {
            playerTurnLabel.Content = $"It's Player {_player}'s Turn.";
        }

        private void SwitchPlayer()
        {
            _player = _player == 1 ? 2 : 1;
        }

        private void movesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MovesWindow movesWindow = new MovesWindow();
            movesWindow.FillOutput();
            movesWindow.Show();
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void UIElement_OnMouseMove(object sender, MouseEventArgs e)
        {
            //COORDINATE LABELS
            Point positionMouse = e.GetPosition(gameCanvas);
            xCoordinateLabel.Content = $"X Coordinate {positionMouse.X}";
            yCoordinateLabel.Content = $"Y Coordinate {positionMouse.Y}";
            //ROW & COLUMN LABEL
            _row = (int) ((positionMouse.Y / (gameCanvas.Height / NumberOfRowsAndColumns)) + 0.80 + (positionMouse.Y * 0.0015));
            _column = (int) ((positionMouse.X / (gameCanvas.Width / NumberOfRowsAndColumns)) + 0.80 + (positionMouse.X * 0.0015));
            positionLabel.Content = $"({_row}, {_column})";
        }

        private void GameCanvas_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                //DO MOVE
                _gameBoard.ColorBlock(_row - 1, _column - 1, _player);
                //SWITCH AND DISPLAY PLAYER
                SwitchPlayer();
                DisplayPlayer();
                //CHECK IF WINNER
                if (!_gameBoard.IsAnyMovePossible(_player))
                {
                    gameCanvas.MouseDown -= GameCanvas_OnMouseDown;
                    movesMenuItem.IsEnabled = true;
                    SwitchPlayer();
                    MessageBox.Show($"Game over, player {_player} won the game!");

                }
            }
            catch (DomineeringException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
