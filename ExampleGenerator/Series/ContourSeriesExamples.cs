namespace ExampleGenerator {
	using System;

	using OxyPlot;
	using OxyPlot.Series;

	[Export("Series/ContourSeries")]
	public class ContourSeriesExamples {
		public static PlotModel ContourSeries() {
			var model = new PlotModel { Title = "ContourSeries" };
			double x0 = -3.1;
			double x1 = 3.1;
			double y0 = -3;
			double y1 = 3;
			Func<double, double, double> peaks = (x, y) => 3 * (1 - x) * (1 - x) * Math.Exp(-(x * x) - (y + 1) * (y + 1)) - 10 * (x / 5 - x * x * x - y * y * y * y * y) * Math.Exp(-x * x - y * y) - 1.0 / 3 * Math.Exp(-(x + 1) * (x + 1) - y * y);
			var xx = ArrayBuilder.CreateVector(x0, x1, 100);
			var yy = ArrayBuilder.CreateVector(y0, y1, 100);
			var peaksData = ArrayBuilder.Evaluate(peaks, xx, yy);

			var cs = new ContourSeries
			{
				Color = OxyColors.Black,
				LabelBackground = OxyColors.White,
				ColumnCoordinates = yy,
				RowCoordinates = xx,
				Data = peaksData
			};
			model.Series.Add(cs);

			return model;
		}
	}
}