using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace OpdrachtHouse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush blackBrush = new SolidColorBrush(Colors.Black);
            DrawTriangle(paperCanvas, blackBrush, 100, 50, 80, 40);//rechterdriehoek
            DrawTriangle(paperCanvas, blackBrush, 100, 50, -80, 40);//linkerdriehoek
            DrawLogo(paperCanvas, blackBrush, 100, 90); //rechterkant
            DrawLogo(paperCanvas, blackBrush, 40, 90); //linkerkant
        }

        private void DrawTriangle(Canvas drawingArea,
                                  SolidColorBrush brushToUse,
                                  double topX,
                                  double topY,
                                  double width,
                                  double height)
        {
            DrawLine(drawingArea, brushToUse, topX, topY,
                     topX, topY + height);
            DrawLine(drawingArea, brushToUse, topX,
                     topY + height,
                     topX + width, topY + height);
            DrawLine(drawingArea, brushToUse, topX, topY,
                     topX + width, topY + height);
        }
        //2 methodes met dezelde naam in dezelfde klasse met een andere parameters = method overloading
        private void DrawTriangle(SolidColorBrush brush, Canvas paperCanvas, double height, double width, double leftX,  double leftY)
        {
            DrawLine(paperCanvas, brush, leftX, leftY, leftX, leftY - height);
            DrawLine(paperCanvas, brush, leftX, leftY, leftX + width, leftY);
            DrawLine(paperCanvas, brush, leftX, leftY - height, leftX + width, leftY);
        }

        private void DrawLine(Canvas drawingArea,
                              SolidColorBrush brushToUse,
                              double startX, double startY,
                              double endX, double endY)
        {
            Line theLine = new Line
            {
                X1 = startX,
                X2 = endX,
                Y1 = startY,
                Y2 = endY,
                Stroke = brushToUse,
                StrokeThickness = 1
            };
            drawingArea.Children.Add(theLine);
        }

        private void DrawLogo(Canvas drawingArea,
                              SolidColorBrush brushToUse,
                              double xPosition,
                              double yPosition)
        {
            DrawRectangle(drawingArea, brushToUse, xPosition, yPosition, 20);
            DrawRectangle(drawingArea, brushToUse, xPosition, yPosition, 40);
            DrawRectangle(drawingArea, brushToUse, xPosition, yPosition, 60);
        }

        private void DrawRectangle(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double xPosition,
                                   double yPosition,
                                   double size)
        {
            Rectangle theRectangle = new Rectangle
            {
                Width = size,
                Height = size,
                Margin = new Thickness(xPosition, yPosition, 0, 0),
                Stroke = brushToUse
            };
            drawingArea.Children.Add(theRectangle);
        }
    }
}
