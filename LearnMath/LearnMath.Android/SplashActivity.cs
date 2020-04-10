using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;
using System.Threading.Tasks;
using Xamarin.Forms;
using static Android.Content.Res.Resources;

namespace LearnMath.Droid
{
    [Activity(Label = "LearnMath", Icon = "@drawable/logo", Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : AppCompatActivity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
        }

        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        public override void OnBackPressed() { }

        async void SimulateStartup()
        {
            await Task.Delay(2000); 
            StartActivity(new Intent(this, typeof(MainActivity)));
        }
    }
}