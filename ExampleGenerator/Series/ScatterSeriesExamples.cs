namespace ExampleGenerator
{
    using System;

    using OxyPlot;
    using OxyPlot.Axes;
    using OxyPlot.Series;

    public class ScatterSeriesExamples
    {
        [Export(@"Series\ScatterSeries")]
        public static PlotModel ScatterSeries()
        {
            var model = new PlotModel { Title = "ScatterSeries" };
            var scatterSeries = new ScatterSeries { MarkerType = MarkerType.Circle };
            var r = new Random(314);
            for (int i = 0; i < 100; i++)
            {
                var x = r.NextDouble();
                var y = r.NextDouble();
                var size = r.Next(5, 15);
                var colorValue = r.Next(100, 1000);
                scatterSeries.Points.Add(new ScatterPoint(x, y, size, colorValue));
            }

            model.Series.Add(scatterSeries);
            model.Axes.Add(new LinearColorAxis { Position = AxisPosition.Right, Palette = OxyPalettes.Jet(200) });
            return model;
        }
    }
}