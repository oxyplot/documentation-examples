namespace ExampleGenerator
{
    using System;
    using System.Globalization;

    using OxyPlot;
    using OxyPlot.Axes;
    using OxyPlot.Series;

    public static class Showcases
    {
        [Export(@"Showcases\NormalDistribution")]
        public static PlotModel LineSeries()
        {
            // http://en.wikipedia.org/wiki/Normal_distribution
            var plot = new PlotModel
                           {
                               Title = "Normal distribution",
                               Subtitle = "Probability density function",
                               DefaultFont = "Arial",
                               Culture = CultureInfo.InvariantCulture
                           };

            plot.Axes.Add(
                new LinearAxis
                    {
                        Position = AxisPosition.Left,
                        Minimum = -0.05,
                        Maximum = 1.05,
                        MajorStep = 0.2,
                        MinorStep = 0.05,
                        TickStyle = TickStyle.Inside
                    });
            plot.Axes.Add(
                new LinearAxis
                    {
                        Position = AxisPosition.Bottom,
                        Minimum = -5.25,
                        Maximum = 5.25,
                        MajorStep = 1,
                        MinorStep = 0.25,
                        TickStyle = TickStyle.Inside
                    });
            plot.Series.Add(CreateNormalDistributionSeries(-5, 5, 0, 0.2));
            plot.Series.Add(CreateNormalDistributionSeries(-5, 5, 0, 1));
            plot.Series.Add(CreateNormalDistributionSeries(-5, 5, 0, 5));
            plot.Series.Add(CreateNormalDistributionSeries(-5, 5, -2, 0.5));
            return plot;
        }

        private static DataPointSeries CreateNormalDistributionSeries(double x0, double x1, double mean, double variance, int n = 1001)
        {
            var ls = new LineSeries { Title = string.Format(CultureInfo.InvariantCulture, "N({0},{1})", mean, variance) };

            for (int i = 0; i < n; i++)
            {
                double x = x0 + ((x1 - x0) * i / (n - 1));
                double f = 1.0 / Math.Sqrt(2 * Math.PI * variance) * Math.Exp(-(x - mean) * (x - mean) / 2 / variance);
                ls.Points.Add(new DataPoint(x, f));
            }

            return ls;
        }
    }
}