namespace ExampleGenerator {
	using System;

	using OxyPlot;
	using OxyPlot.Axes;

	public class DateTimeAxisExamples {
		[Export("Axes/DateTimeAxis")]
		public static PlotModel Default() {
			var model = new PlotModel { Title = "DateTimeAxis", PlotMargins = new OxyThickness(40, double.NaN, 40, double.NaN) };
			model.Axes.Add(new DateTimeAxis
			{
				Position = AxisPosition.Bottom,
				Minimum = DateTimeAxis.ToDouble(new DateTime(2015, 1, 1)),
				Maximum = DateTimeAxis.ToDouble(new DateTime(2016, 1, 1)),
				Title = "DateTimeAxis"
			});
			model.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
			return model;
		}
	}
}