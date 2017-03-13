namespace ExampleGenerator {
	using System;

	using OxyPlot;
	using OxyPlot.Axes;

	public class TimeSpanAxisExamples {
		[Export("Axes/TimeSpanAxis")]
		public static PlotModel Default() {
			var model = new PlotModel { Title = "TimeSpanAxis" };
			model.Axes.Add(new TimeSpanAxis { Position = AxisPosition.Bottom, Maximum = TimeSpanAxis.ToDouble(TimeSpan.FromMinutes(15)) });
			model.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
			return model;
		}
	}
}