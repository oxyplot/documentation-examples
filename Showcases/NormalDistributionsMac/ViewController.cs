using System;

using AppKit;
using CoreGraphics;
using Foundation;

using OxyPlot.Xamarin.Mac;

using NormalDistributions.Shared;

namespace NormalDistributionsMac
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var frame = new CGRect(10, 10, 600, 400);
            var plotView = new PlotView(frame);
            plotView.Model = NormalDistributionModel.Create();

            this.View = plotView;
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
