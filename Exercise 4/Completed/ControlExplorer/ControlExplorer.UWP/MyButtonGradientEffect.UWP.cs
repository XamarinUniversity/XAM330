using ControlExplorer.UWP;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

//[assembly: ResolutionGroupName ("Xamarin")]
[assembly: ExportEffect (typeof (MyButtonGradientEffect), "ButtonGradientEffect")]
namespace ControlExplorer.UWP
{
	internal class MyButtonGradientEffect : PlatformEffect
	{
        Brush oldBrush;

        protected override void OnAttached()
        {
            if (Element is Button == false)
                return;

            //save the original brush
            var button = Control as FormsButton;
            oldBrush = button.BackgroundColor;

            SetGradient();
        }

        void SetGradient()
        { 
            var xfButton = Element as Button;

            var button = Control as FormsButton;

            var colorTop = xfButton.BackgroundColor;
            var colorBottom = Color.Black;

            button.BackgroundColor = Gradient.GetGradientBrush(GetWindowsColor(colorTop), GetWindowsColor(colorBottom));
        }

  		protected override void OnDetached()
		{
            if (oldBrush == null)
                return;

            var button = Control as FormsButton;

            button.BackgroundColor = oldBrush;
        }

        Windows.UI.Color GetWindowsColor (Color color)
        {
            return Windows.UI.Color.FromArgb((byte)(255 * color.A), (byte)(255 * color.R), (byte)(255 * color.G), (byte)(255 * color.B));
        }
	}
}