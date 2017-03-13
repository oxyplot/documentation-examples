namespace ExampleGenerator {
	using System;
	using OxyPlot;
	using OxyPlot.Axes;
	using OxyPlot.Series;

	public class StemSeriesExamples {

		[Export("Series/StemSeries")]
		public static PlotModel StemSeries() {
			var model = new PlotModel{ Title = "Trigonometric functions" };

			var start = -Math.PI;
			var end = Math.PI;
			var step = 0.1;
			int steps = (int)((Math.Abs(start) + Math.Abs(end)) / step);

			//generate points for functions
			var sinData = new DataPoint[steps];
			for(int i = 0; i < steps; ++i) {
				var x = (start + step * i);
				sinData[i] = new DataPoint(x, Math.Sin(x));
			}

			//sin(x)
			var sinStemSeries = new StemSeries
			{
				MarkerStroke = OxyColors.Green,
				MarkerType = MarkerType.Circle
			};
			sinStemSeries.Points.AddRange(sinData);

			model.Series.Add(sinStemSeries);

			return model;
		}

	}
}
