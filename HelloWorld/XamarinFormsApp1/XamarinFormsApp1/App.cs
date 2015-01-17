namespace XamarinFormsApp1
{
    using OxyPlot;
    using OxyPlot.Xamarin.Forms;

    using Xamarin.Forms;

    public class App : Application
    {
        public App()
        {
            this.MainPage = new ContentPage
            {
                Content = new PlotView
                {
                    Model = new PlotModel { Title = "Hello, Forms!" },
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
            };
        }
    }
}
