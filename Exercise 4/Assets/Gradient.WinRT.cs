using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace ControlExplorer.Windows
{
    public static class Gradient
    {
        public static Brush GetGradientBrush (Color colorTop, Color colorBottom)
        {
            var gradBrush = new LinearGradientBrush()
            {
                StartPoint = new Point(0, 0),
                EndPoint = new Point(0, 1)
            };

            gradBrush.GradientStops.Add(new GradientStop() { Color = colorTop, Offset = 0 });
            gradBrush.GradientStops.Add(new GradientStop() { Color = colorBottom, Offset = 1 });

            return gradBrush;
        }
    }
}