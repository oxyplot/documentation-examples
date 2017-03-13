namespace ExampleGenerator
{
    using OxyPlot;
    using OxyPlot.Axes;

    public class AxisExamples
    {
        [Export("Axes/Position")]
        public static PlotModel Position()
        {
            var model = new PlotModel { Title = "Position" };
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "Bottom" });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "Left" });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Top, Title = "Top" });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Right, Title = "Right" });
            return model;
        }

        [Export("Axes/MinimumMaximum")]
        public static PlotModel MinimumMaximum()
        {
            var model = new PlotModel { Title = "Minimum and Maximum" };
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = -1, Maximum = 1 });
            return model;
        }

        [Export("Axes/MajorStep")]
        public static PlotModel MajorStep()
        {
            var model = new PlotModel { Title = "MajorStep" };
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0, Maximum = 10, MajorStep = 2 });
            return model;
        }

        [Export("Axes/MinorStep")]
        public static PlotModel MinorStep()
        {
            var model = new PlotModel { Title = "MinorStep" };
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0, Maximum = 10, MajorStep = 1, MinorStep = 0.2 });
            return model;
        }

        [Export("Axes/PositionTier")]
        public static PlotModel PositionTier()
        {
            var model = new PlotModel { Title = "PositionTier" };
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, PositionTier = 0, Title = "PositionTier = 0" });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, PositionTier = 1, Minimum = 0, Maximum = 1, Title = "PositionTier = 1" });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, PositionTier = 0, Title = "PositionTier = 0" });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, PositionTier = 1, Minimum = 0, Maximum = 10, Title = "PositionTier = 1" });
            return model;
        }

        [Export("Axes/Reversed")]
        public static PlotModel StartEndPositionReversed()
        {
            var model = new PlotModel { Title = "Reversed axes" };
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, StartPosition = 1, EndPosition = 0 });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, StartPosition = 1, EndPosition = 0 });
            return model;
        }

        [Export("Axes/StartEndPosition")]
        public static PlotModel StartEndPosition()
        {
            var model = new PlotModel { Title = "StartPosition and EndPosition" };
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, StartPosition = 0, EndPosition = 0.45, Title = "First" });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, StartPosition = 0.55, EndPosition = 1, Title = "Second" });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
            return model;
        }
    }
}