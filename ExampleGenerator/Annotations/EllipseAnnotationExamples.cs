namespace ExampleGenerator.Annotations
{
    using OxyPlot;
    using OxyPlot.Annotations;
    using OxyPlot.Axes;

    public class EllipseAnnotationExamples
    {
        [Export("Annotations/EllipseAnnotation")]
        public static PlotModel EllipseAnnotation()
        {
            var model = new PlotModel { Title = nameof(EllipseAnnotation) };
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
            model.Annotations.Add(new EllipseAnnotation { X = 50, Y = 50, Height= 30 , Width = 30,  Text = nameof(EllipseAnnotation) });
            return model;
        }
    }
}
