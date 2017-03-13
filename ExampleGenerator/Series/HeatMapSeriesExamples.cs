namespace ExampleGenerator {
	using System;

	using OxyPlot;
	using OxyPlot.Axes;
	using OxyPlot.Series;

	public class HeatMapSeriesExamples {
		[Export("Series/HeatMapSeries")]
		public static PlotModel HeatMapSeries() {
			var model = new PlotModel { Title = "HeatMapSeries" };
			double x0 = -3.1;
			double x1 = 3.1;
			double y0 = -3;
			double y1 = 3;
			Func<double, double, double> peaks = (x, y) => 3 * (1 - x) * (1 - x) * Math.Exp(-(x * x) - (y + 1) * (y + 1)) - 10 * (x / 5 - x * x * x - y * y * y * y * y) * Math.Exp(-x * x - y * y) - 1.0 / 3 * Math.Exp(-(x + 1) * (x + 1) - y * y);
			var xx = ArrayBuilder.CreateVector(x0, x1, 100);
			var yy = ArrayBuilder.CreateVector(y0, y1, 100);
			var peaksData = ArrayBuilder.Evaluate(peaks, xx, yy);

			model.Axes.Add(new LinearColorAxis { Position = AxisPosition.Right, Palette = OxyPalettes.Jet(500), HighColor = OxyColors.Gray, LowColor = OxyColors.Black });

			var hms = new HeatMapSeries { X0 = x0, X1 = x1, Y0 = y0, Y1 = y1, Data = peaksData };
			model.Series.Add(hms);

			return model;
		}

		[Export("Series/HeatMapSeries_linear")]
		public static PlotModel LinearHeatMap() {
			var model = new PlotModel { Title = "Heatmap" };

			// Color axis (the X and Y axes are generated automatically)
			model.Axes.Add(new LinearColorAxis
			{
				Palette = OxyPalettes.Rainbow(100)
			});

			// generate 1d normal distribution
			var singleData = new double[100];
			for(int x = 0; x < 100; ++x) {
				singleData[x] = Math.Exp((-1.0 / 2.0) * Math.Pow(((double)x - 50.0) / 20.0, 2.0));
			}

			// generate 2d normal distribution
			var data = new double[100, 100];
			for(int x = 0; x < 100; ++x) {
				for(int y = 0; y < 100; ++y) {
					data[y, x] = singleData[x] * singleData[(y + 30) % 100] * 100;
				}
			}

			var heatMapSeries = new HeatMapSeries
			{
				X0 = 0,
				X1 = 99,
				Y0 = 0,
				Y1 = 99,
				Interpolate = true,
				RenderMethod = HeatMapRenderMethod.Bitmap,
				Data = data
			};

			model.Series.Add(heatMapSeries);

			return model;
		}

		[Export("Series/HeatMapSeries_categorized")]
		public static PlotModel CategorizedHeatMap() {
			var model = new PlotModel { Title = "Cakes per Weekday" };

			// Weekday axis (horizontal)
			model.Axes.Add(new CategoryAxis
			{
				Position = AxisPosition.Bottom,

				// Key used for specifying this axis in the HeatMapSeries
				Key = "WeekdayAxis",

				// Array of Categories (see above), mapped to one of the coordinates of the 2D-data array
				ItemsSource = new[]
				{
					"Monday",
					"Tuesday",
					"Wednesday",
					"Thursday",
					"Friday",
					"Saturday",
					"Sunday"
				}
			});

			// Cake type axis (vertical)
			model.Axes.Add(new CategoryAxis
			{
				Position = AxisPosition.Left,
				Key = "CakeAxis",
				ItemsSource = new[]
				{
					"Apple cake",
					"Baumkuchen",
					"Bundt cake",
					"Chocolate cake",
					"Carrot cake"
				}
			});

			// Color axis
			model.Axes.Add(new LinearColorAxis
			{
				Palette = OxyPalettes.Hot(200)
			});

			var rand = new Random();
			var data = new double[7, 5];
			for(int x = 0; x < 5; ++x) {
				for(int y = 0; y < 7; ++y) {
					data[y, x] = rand.Next(0, 200) * (0.13 * (y + 1));
				}
			}

			var heatMapSeries = new HeatMapSeries
			{
				X0 = 0,
				X1 = 6,
				Y0 = 0,
				Y1 = 4,
				XAxisKey = "WeekdayAxis",
				YAxisKey = "CakeAxis",
				RenderMethod = HeatMapRenderMethod.Rectangles,
				LabelFontSize = 0.2, // neccessary to display the label
				Data = data
			};

			model.Series.Add(heatMapSeries);
			return model;
		}
	}
}