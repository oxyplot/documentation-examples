using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleGenerator.Series
{
    using OxyPlot;
    using OxyPlot.Axes;
    using OxyPlot.Series;

    public class StairStepSeriesExamples
    {
        [Export("Series/StairStepSeries")]
        public static PlotModel StairStepSeries()
        {   
            // prepare the model
            var model = new PlotModel()
            {
                Title = "Gillespie Simulation",
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = LegendPosition.TopCenter,
                LegendOrientation = LegendOrientation.Horizontal
            };

            // add two linear axes
            model.Axes.Add(new LinearAxis() { Title = "Time (hours)", Position = AxisPosition.Bottom });
            model.Axes.Add(new LinearAxis() { Title = "Count", Position = AxisPosition.Left });

            // initialise series
            var stairStepSeries1 = new StairStepSeries() { Title = "Species 1" };
            model.Series.Add(stairStepSeries1);
            var stairStepSeries2 = new StairStepSeries() { Title = "Species 2" };
            model.Series.Add(stairStepSeries2);

            // perform simple Gillespie simulation
            var rnd = new Random(0);
            double sampleExponentialDistribution(double λ) => System.Math.Log(1 - rnd.NextDouble()) / -λ;
            int s1 = 10;
            int s2 = 0;

            double t = 0;
            while (true)
            {
                // add data-points to series
                stairStepSeries1.Points.Add(new DataPoint(t, s1));
                stairStepSeries2.Points.Add(new DataPoint(t, s2));

                if (s1 + s2 == 0)
                {
                    break;
                }

                var r1 = 0.2 * s1;
                var r2 = 0.1 * s2;
                t += sampleExponentialDistribution(r1 + r2);
                if (rnd.NextDouble() * (r1 + r2) < r1)
                {
                    s1--;
                    s2++;
                }
                else
                {
                    s2--;
                }
            }

            return model;
        }
    }
}
