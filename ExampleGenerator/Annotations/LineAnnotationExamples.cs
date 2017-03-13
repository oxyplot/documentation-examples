namespace ExampleGenerator
{
    using OxyPlot;
    using OxyPlot.Annotations;
    using OxyPlot.Axes;

    public class LineAnnotationExamples
    {
        [Export("Annotations/LineAnnotation")]
        public static PlotModel LineAnnotation()
        {
            var model = new PlotModel { Title = "LineAnnotation" };
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
            model.Annotations.Add(new LineAnnotation { X = 50, Type = LineAnnotationType.Vertical, Text = "Vertical LineAnnotation" });
            return model;
        }
    }
}