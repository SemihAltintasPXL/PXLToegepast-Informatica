using System.Windows.Controls;
using System.Windows.Media;

namespace oefPreyPredator.Contracts
{
    public interface IDisplayable
    {
        // void DisplayOn(Canvas canvas, Color color); niet volgens de opgave
        void DisplayOn(Canvas canvas);
        void StopDisplaying();
        void UpdateDisplay();
    }
}
