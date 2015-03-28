namespace ExampleGenerator
{
    using OxyPlot;
    using OxyPlot.Axes;

    public class LinearAxisExamples
    {
        [Export(@"Axes\LinearAxis")]
        public static PlotModel LinearAxis()
        {
            var model = new PlotModel { Title = "LinearAxis" };

            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "Bottom axis" });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "Left axis" });
            return model;
        }
    }
}