namespace ExampleGenerator
{
    using OxyPlot;
    using OxyPlot.Series;

    public class TwoColorLineSeriesExamples
    {
        [Export(@"Series\TwoColorLineSeries")]
        public static PlotModel TwoColorLineSeries()
        {
            var model = new PlotModel { Title = "TwoColorLineSeries" };
            var twoColorLineSeries = new TwoColorLineSeries
                                         {
                                             Color = OxyColors.Red,
                                             Color2 = OxyColors.Blue,
                                             LineStyle = LineStyle.Solid,
                                             LineStyle2 = LineStyle.Dot
                                         };
            twoColorLineSeries.Points.Add(new DataPoint(0, -6));
            twoColorLineSeries.Points.Add(new DataPoint(10, 4));
            twoColorLineSeries.Points.Add(new DataPoint(30, -2));
            twoColorLineSeries.Points.Add(new DataPoint(40, 8));
            model.Series.Add(twoColorLineSeries);
            return model;
        }
    }
}