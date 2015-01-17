namespace XamarinFormsApp1.WinPhone
{
    using Microsoft.Phone.Controls;

    using Xamarin.Forms;
    using Xamarin.Forms.Platform.WinPhone;

    public partial class MainPage : FormsApplicationPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            OxyPlot.Xamarin.Forms.Platform.WinPhone.Forms.Init();
            Forms.Init();
            this.LoadApplication(new XamarinFormsApp1.App());
        }
    }
}
