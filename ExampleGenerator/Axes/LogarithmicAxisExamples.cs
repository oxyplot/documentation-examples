namespace ExampleGenerator
{
    using OxyPlot;
    using OxyPlot.Axes;

    public class LogarithmicAxisExamples
    {
        [Export("Axes/LogarithmicAxis")]
        public static PlotModel LogarithmicAxis()
        {
            var model = new PlotModel { Title = "LogarithmicAxis" };
            model.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Bottom, Minimum = 1e0, Maximum = 1e3 });
            model.Axes.Add(new LogarithmicAxis { Position = AxisPosition.Left, Minimum = 1e-4, Maximum = 1e-1 });
            return model;
        }
    }
}