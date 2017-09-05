using ControlExplorer.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;

//[assembly: ResolutionGroupName ("Xamarin")]
[assembly: ExportEffect (typeof (MyButtonGradientEffect), "ButtonGradientEffect")]
namespace ControlExplorer.Droid
{
	internal class MyButtonGradientEffect : PlatformEffect
	{
        Drawable oldDrawable;
        protected override void OnAttached()
        {
            if (Element is Button == false)
                return;

            oldDrawable = Control.Background;

            SetGradient();
        }

        void SetGradient()
        { 
            var xfButton = Element as Button;

            var colorTop = xfButton.BackgroundColor;
            var colorBottom = Color.Black;

            Control.SetBackground(Gradient.GetGradientDrawable(colorTop.ToAndroid(), colorBottom.ToAndroid()));
        }

		protected override void OnDetached()
		{
            if (oldDrawable != null)
                Control.Background = oldDrawable;
        }
	}
}