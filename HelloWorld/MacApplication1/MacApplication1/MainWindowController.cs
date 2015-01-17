namespace MacApplication1
{
    using System;

    using AppKit;
    using CoreGraphics;
    using Foundation;

    using OxyPlot;
    using OxyPlot.Axes;
    using OxyPlot.Series;
    using OxyPlot.Xamarin.Mac;

    public partial class MainWindowController : NSWindowController
    {
        public MainWindowController (IntPtr handle) : base (handle)
        {
        }

        [Export ("initWithCoder:")]
        public MainWindowController (NSCoder coder) : base (coder)
        {
        }

        public MainWindowController () : base ("MainWindow")
        {
        }

        public override void AwakeFromNib ()
        {
            base.AwakeFromNib ();
        }

        public new MainWindow Window {
            get { return (MainWindow)base.Window; }
        }

        public override void WindowDidLoad ()
        {
            base.WindowDidLoad ();
            var frame = new CGRect (10, 10, 300, 300);
            var plotView = new PlotView (frame);
            var model = new PlotModel{ Title = "Hello World!" };
            model.Axes.Add (new LinearAxis { Position = AxisPosition.Bottom });
            model.Axes.Add (new LinearAxis { Position = AxisPosition.Left });
            model.Series.Add (new FunctionSeries (x => Math.Sin(x) / x, -20, 20, 800));
            plotView.Model = model;
            Window.ContentView = plotView;
            Window.Title = "OxyPlot on Xamarin.Mac (Unified API)";
        }
    }
}
