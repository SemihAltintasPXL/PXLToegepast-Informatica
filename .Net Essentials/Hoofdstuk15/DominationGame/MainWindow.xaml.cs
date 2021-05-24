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

namespace DominationGame
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const int NumberOfrows = 8;
        public const int Margin = 10;
        private Player _currentPlayer;

        private Board _board;
        private double sizeBlock;
        public MainWindow()
        {
            InitializeComponent();
            sizeBlock = (int)(gameCanvas.Width - 2 * Margin) / NumberOfrows;
            _board = new Board(sizeBlock);
            _board.DisplayOn(gameCanvas);
        }

        private void startAGameMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("startes game");
            Random rnd = new Random();
            _currentPlayer = (Player)rnd.Next(0, 2);
        }

        private void movesMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void gameCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Point positionMouse = e.GetPosition(gameCanvas);
            xCoordinateLabel.Content = $"X Coordinate {positionMouse.X}";
            yCoordinateLabel.Content = $"Y Coordinate {positionMouse.Y}";

            int _row = (int)((positionMouse.Y - Margin) / sizeBlock);
            int _column =  (int)((positionMouse.X - Margin) / sizeBlock);
            cellLabel.Content = $"({_row}, {_column})";


            try
            {// hier moet je nakijken of het blockje waarop je geklikt hebt nog vrij is
                // methode ClaimBlocks gebruiken . Het controleren of er nog iets aangeklikt kan worden moet
                // je doen nadat je weet dat de huidige speler zijn zet kan doen. Dan controleer je of de andere
                // nog iets kan doen => indien niet winnaar gekend
                // onderstaande code moet je wat aanpassen

                if (_board.HasMoveLeftFor(_currentPlayer))
                {
                    _board.ClaimBlocks(_row, _column, _currentPlayer);
                    
                    _currentPlayer = _currentPlayer == Player.red ? Player.blue : Player.red;
                }
                else
                {

                    if (_currentPlayer == Player.red)
                    {
                        MessageBox.Show("speler Blue heeft gewonnen!");
                    }
                    else
                    {
                        MessageBox.Show("speler Red heeft gewonnen!");
                    }
                    this.Close();
                }
            }
            catch (DominationException ex)
            {
                MessageBox.Show(ex.Message);
                // indien de zet niet geplaatst kan worden lijkt het me logsich dat de huidige speler zijn beurt
                // vooorbij ziet gaan
            }
        }
    }
}
