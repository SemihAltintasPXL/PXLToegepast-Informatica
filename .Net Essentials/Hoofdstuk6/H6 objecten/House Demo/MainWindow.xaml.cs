using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace House_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Line verticalLine;
        private Line horizontalLine;
        private Line otherLine;
        private Rectangle rectangle;

        public MainWindow()
        {
            InitializeComponent();
            // instellen van Maximum slider (min standaard op 0 max standaard op 10)
            //xSlider.Maximum = paperCanvas.Width - 50;
            //xSlider.Width = paperCanvas.Width - 50;
            // het huis moet 10 pixels van linkerrand en rechterrand afblijven
            xSlider.Minimum = 10; // dit zorgt ervoor dat de waarde van slider gewijzigd wordt => genereert dus een event
            // probleem want het huis is dan nog niet aangemaakt
            // oplossing eventhandler pas koppelen nadat minimum een waarde heeft gekregen
            xSlider.ValueChanged += xSlider_ValueChanged;
            xSlider.Maximum = paperCanvas.Width - 60;
            xSlider.Width = paperCanvas.Width - 60;

        }

 

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush blackBrush = new SolidColorBrush(Colors.Black);

            DrawHouse(paperCanvas, blackBrush, 60, 40, 50, 50);
            drawButton.IsEnabled = false;
            xSlider.IsEnabled = true;
            xSlider.Value = 60;
            positionXLabel.Content = "x position roof 60";
        }

        private void DrawHouse(Canvas drawingArea,
                               SolidColorBrush brushToUse,
                               double topRoofX,
                               double topRoofY,
                               double width,
                               double height)
        {
            DrawTriangle(drawingArea, brushToUse, topRoofX,
                         topRoofY, width, height);
            DrawRectangle(drawingArea, brushToUse, topRoofX,
                          topRoofY + height, width, height, out rectangle);
        }

        private void DrawTriangle(Canvas drawingArea,
                                  SolidColorBrush brushToUse,
                                  double topX,
                                  double topY,
                                  double width,
                                  double height)
        {
            DrawLine(drawingArea, brushToUse, topX, topY,
                     topX, topY + height, out verticalLine);
            DrawLine(drawingArea, brushToUse, topX,
                     topY + height,
                     topX + width, topY + height, out horizontalLine);
            DrawLine(drawingArea, brushToUse, topX, topY,
                     topX + width, topY + height, out otherLine);
        }

        private void DrawLine(Canvas drawingArea,
                              SolidColorBrush brushToUse,
                              double startX, double startY,
                              double endX, double endY, out Line theLine)
        {
            theLine = new Line();
            theLine.X1 = startX; theLine.X2 = endX;
            theLine.Y1 = startY; theLine.Y2 = endY;
            theLine.Stroke = brushToUse;
            theLine.StrokeThickness = 1;
            drawingArea.Children.Add(theLine);
        }

        private void DrawRectangle(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double topLeftX,
                                   double topLeftY,
                                   double width,
                                   double height, out Rectangle theRectangle)
        {
            theRectangle = new Rectangle();
            theRectangle.Width = width;
            theRectangle.Height = height;
            theRectangle.Margin = new Thickness(topLeftX, topLeftY, 0, 0);
            theRectangle.Stroke = brushToUse;
            drawingArea.Children.Add(theRectangle);
        }

        private void UpdateHouse(double topRoofX)
        {
            verticalLine.X1 = topRoofX; verticalLine.X2 = topRoofX;
            horizontalLine.X1 = topRoofX; horizontalLine.X2 = topRoofX + 50;
            otherLine.X1 = topRoofX; otherLine.X2 = topRoofX + 50;
            rectangle.Margin = new Thickness(topRoofX, 90, 0, 0);
        }

        private void xSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateHouse(xSlider.Value);
            positionXLabel.Content = $"x position of roof {xSlider.Value}";
        }
    }
}
