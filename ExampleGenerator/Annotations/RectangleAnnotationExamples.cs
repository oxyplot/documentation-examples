namespace ExampleGenerator.Annotations
{
    using OxyPlot;
    using OxyPlot.Annotations;
    using OxyPlot.Axes;

    public class RectangleAnnotationExamples
    {
        [Export("Annotations/RectangleAnnotation")]
        public static PlotModel RectangleAnnotation()
        {
            var model = new PlotModel { Title = nameof(RectangleAnnotation) };
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
            model.Annotations.Add(new RectangleAnnotation { MinimumX = 30, MaximumX = 70, MinimumY = 40, MaximumY = 60, Text = nameof(RectangleAnnotation) });
            return model;
        }
    }
}
