using Xamarin.Forms;

namespace ControlExplorer
{
	public class ButtonGradientEffect : RoutingEffect
	{
		public static readonly BindableProperty GradientColorProperty 
			= BindableProperty.CreateAttached("GradientColor", typeof(Color), typeof(ButtonGradientEffect), Color.Black);

		public static void SetGradientColor(VisualElement view, Color color) 
		{ 
			view.SetValue(GradientColorProperty, color); 
		}

		public static Color GetGradientColor(VisualElement view) 
		{ 
			return (Color) view.GetValue(GradientColorProperty); 
		}

		public ButtonGradientEffect () : base ("Xamarin.ButtonGradientEffect") 
		{}
	}
}