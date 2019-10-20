namespace ExampleGenerator
{
    using System;

    using OxyPlot;
    using OxyPlot.Axes;
    using OxyPlot.Series;

    public class AreaSeriesExamples
    {
        [Export("Series/AreaSeries")]
        public static PlotModel AreaSeries()
        {
            var model = new PlotModel { Title = "AreaSeries" };
            model.Axes.Add(new LinearAxis() { Title = "Day", Position = AxisPosition.Bottom });
            model.Axes.Add(new LinearAxis() { Title = "Output", Position = AxisPosition.Left });

            var areaSeries = new AreaSeries() { Color2 = OxyColors.Transparent };

            var r = new Random(1);
            var dailyOutput = 10;
            for (int i = 0; i <= 100; i++)
            {
                areaSeries.Points.Add(new DataPoint(i, dailyOutput));
                //areaSeries.Points2.Add(new DataPoint(i, 0));

                dailyOutput = Math.Max(0, dailyOutput + r.Next(-2, 3));
            }

            model.Series.Add(areaSeries);
            return model;
        }
    }
}