using System.ComponentModel;
using CoreAnimation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using ControlExplorer.iOS;

//[assembly: ResolutionGroupName ("Xamarin")]
[assembly: ExportEffect (typeof (MyButtonGradientEffect), "ButtonGradientEffect")]
namespace ControlExplorer.iOS
{
	public class MyButtonGradientEffect : PlatformEffect
	{
		CAGradientLayer gradLayer;

		protected override void OnAttached()
		{
            if (Element is Button == false)
                return;

            SetGradient();
		}		

		protected override void OnDetached()
		{
			gradLayer?.RemoveFromSuperLayer ();
		}

		protected override void OnElementPropertyChanged(PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(e);

            if (Element is Button == false)
                return;

			if (e.PropertyName == ButtonGradientEffect.GradientColorProperty.PropertyName
			    || e.PropertyName == VisualElement.WidthProperty.PropertyName
			   || e.PropertyName == VisualElement.HeightProperty.PropertyName)
			{
				SetGradient();
			}
		}

		void SetGradient()
		{
            gradLayer?.RemoveFromSuperLayer();

			var xfButton = Element as Button;

			var colorTop = xfButton.BackgroundColor;
			var colorBottom = ButtonGradientEffect.GetGradientColor(xfButton);

			gradLayer = Gradient.GetGradientLayer(colorTop.ToCGColor(), colorBottom.ToCGColor(), (float)xfButton.Width, (float)xfButton.Height);

			Control.Layer.InsertSublayer(gradLayer, 0);
		}
	}
}