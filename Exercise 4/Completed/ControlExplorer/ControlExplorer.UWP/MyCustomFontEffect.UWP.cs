using CustomFont.UWP;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(MyCustomFontEffect), "CustomFontEffect")]
namespace CustomFont.UWP
{
    class MyCustomFontEffect : PlatformEffect
    {
        Windows.UI.Xaml.Media.FontFamily oldFontFamily;
        protected override void OnAttached()
        {
            if (Element is Label == false)
                return;

            TextBlock tb = Control as TextBlock;

            oldFontFamily = tb.FontFamily;

            tb.FontFamily = new Windows.UI.Xaml.Media.FontFamily(@"/Assets/Pacifico.ttf#Pacifico");
        }

        protected override void OnDetached()
        {
            if (oldFontFamily != null)
            {
                TextBlock tb = Control as TextBlock;
                tb.FontFamily = oldFontFamily;
            }
        }
    }
}
