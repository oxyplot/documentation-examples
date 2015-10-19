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
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = -1, Maximum = 1 });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = -10, Maximum = 10 });
            return model;
        }
    }
}