namespace ExampleGenerator
{
    using OxyPlot;
    using OxyPlot.Axes;

    public class PolarPlotExamples
    {
        [Export(@"Axes\AngleAndMagnitudeAxis")]
        public static PlotModel Default()
        {
            var model = new PlotModel { Title = "AngleAxis and MagnitudeAxis", PlotType = PlotType.Polar };
            model.Axes.Add(new AngleAxis { Title = "Angle" });
            model.Axes.Add(new MagnitudeAxis { Title = "Magnitude" });
            return model;
        }
    }
}