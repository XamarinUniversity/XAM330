using Android.App;
using Android.Content.PM;
using Android.OS;

namespace ControlExplorer.Droid
{
    //  [Activity(Label = "ControlExplorer", Icon = "@drawable/icon", Theme = "@android:style/Theme.Material.Light", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    [Activity(Label = "ControlExplorer", Icon = "@drawable/icon", Theme = "@style/MyCustomTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

