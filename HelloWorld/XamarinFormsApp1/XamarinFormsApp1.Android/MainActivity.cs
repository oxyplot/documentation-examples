namespace XamarinFormsApp1.Droid
{
    using Android.App;
    using Android.Content.PM;
    using Android.OS;

    using Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;

    [Activity(Label = "XamarinFormsApp1", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            OxyPlot.Xamarin.Forms.Platform.Android.Forms.Init();
            Forms.Init(this, bundle);
            this.LoadApplication(new App()); 
        }
    }
}

