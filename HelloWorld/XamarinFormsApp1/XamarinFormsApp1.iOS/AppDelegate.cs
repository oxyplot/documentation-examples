using Foundation;
using UIKit;

using Xamarin.Forms;

namespace XamarinFormsApp1.iOS
{
    using Xamarin.Forms.Platform.iOS;

    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Foundation.Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            OxyPlot.Xamarin.Forms.Platform.iOS.Forms.Init();
            Forms.Init();
            this.LoadApplication(new App());
            return base.FinishedLaunching(app, options);
        }
    }
}
