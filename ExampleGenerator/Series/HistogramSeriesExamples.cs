namespace ExampleGenerator
{
    using System;
    using System.Collections.Generic;
    using OxyPlot;
    using OxyPlot.Axes;
    using OxyPlot.Series;

    public class HistogramSeriesExamples
    {
        [Export("Series/HistogramSeries")]
        public static PlotModel HistogramSeries()
        {
            // prepare the model
            var model = new PlotModel()
            {
                Title = "Cubic Distribution",
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = LegendPosition.TopCenter,
                LegendOrientation = LegendOrientation.Horizontal
            };

            // add two linear axes
            model.Axes.Add(new LinearAxis() { Title = "Observation", Position = AxisPosition.Bottom });
            model.Axes.Add(new LinearAxis() { Title = "Frequency", Position = AxisPosition.Left });

            // generate random samples from a polynomial distribution
            double power = 3;
            double max = 10.0;
            int sampleCount = 1000;

            double integral = Math.Pow(max, power + 1) / (power + 1);

            var rnd = new Random(0);
            List<double> samples = new List<double>();
            for (int i = 0; i < sampleCount; i++)
            {
                samples.Add(Math.Pow(rnd.NextDouble() * (power + 1) * integral, 1.0 / (power + 1)));
            }

            // plot histogram of samples
            var histogramSeries = new HistogramSeries()
            {
                Title = $"Empirical Distribution",
                FillColor = OxyColors.Green,
                StrokeColor = OxyColors.Black,
                StrokeThickness = 2
            };

            var bins = HistogramHelpers.CreateUniformBins(0, max, 20);
            var binningOptions = new BinningOptions(BinningOutlierMode.RejectOutliers, BinningIntervalType.InclusiveLowerBound, BinningExtremeValueMode.IncludeExtremeValues);
            var items = HistogramHelpers.Collect(samples, bins, binningOptions);

            histogramSeries.Items.AddRange(items);
            model.Series.Add(histogramSeries);

            // plot ideal line for comparison
            var functionSeries = new FunctionSeries(x => Math.Pow(x, power) / integral, 0, max, 1000)
            {
                Title = "Ideal Distribution",
                Color = OxyColors.Red
            };
            model.Series.Add(functionSeries);

            return model;
        }

        [Export("Series/HistogramSeriesLabelPlacement")]
        public static PlotModel HistogramSeriesLabelPlacement()
        {
            // prepare the model
            var model = new PlotModel()
            {
                Title = "Histogram Label Position",
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = LegendPosition.TopCenter,
                LegendOrientation = LegendOrientation.Horizontal
            };

            // add two linear axes
            model.Axes.Add(new LinearAxis() { Title = "Observation", Position = AxisPosition.Bottom });
            model.Axes.Add(new LinearAxis() { Title = "Frequency", Position = AxisPosition.Left, Maximum = 1.5 });

            // add a histogram for each type of label placement
            double x = 0.0;
            foreach (var placement in new[] { LabelPlacement.Base, LabelPlacement.Middle, LabelPlacement.Inside, LabelPlacement.Outside })
            {
                var histogramSeries = new HistogramSeries()
                {
                    Title = placement.ToString(),
                    LabelFormatString = "{0}",
                    LabelPlacement = placement,
                    StrokeThickness = 2,
                };
                histogramSeries.Items.Add(new HistogramItem(x + 0.0, x + 0.5, 0.4, 4));
                histogramSeries.Items.Add(new HistogramItem(x + 0.5, x + 1.0, 0.6, 6));
                model.Series.Add(histogramSeries);

                x += 2.0;
            }

            return model;
        }
    }
}