using Android.OS;
using Android.App;
using Android.Content;
using Android.Support.V7.App;

namespace LEDControl.Views
{
    [Activity(Theme = "@style/MyTheme.Splash", Icon = "@drawable/logo", MainLauncher = true, NoHistory = true)]
    public class SplashScreenActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var intent = new Intent(this, typeof(ConnectionPageActivity));
            StartActivity(intent);
        }
    }
}