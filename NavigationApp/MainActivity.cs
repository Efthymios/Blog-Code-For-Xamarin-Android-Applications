using Android.App;
using Android.OS;
using Android.Widget;

namespace NavigationApp
{
    [Activity(Label = "Navigation App", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var btnNavigate = FindViewById<Button>(Resource.Id.btnNavigate);
            btnNavigate.Click += BtnNavigate_Click;
        }

        private void BtnNavigate_Click(object sender, System.EventArgs e)
        {
            // Simple option
            StartActivity(typeof(SecondActivity));
        }
    }
}

