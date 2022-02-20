using System.Windows.Controls;
using System.Windows.Media;

namespace oefPreyPredator.Contracts
{
    public interface IDisplayable
    {
        void DisplayOn(Canvas canvas, Color color);
        void StopDisplaying();
        void UpdateDisplay();
    }
}
