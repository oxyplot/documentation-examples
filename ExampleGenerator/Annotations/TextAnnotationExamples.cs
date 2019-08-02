namespace ExampleGenerator.Annotations
{
    using OxyPlot;
    using OxyPlot.Annotations;
    using OxyPlot.Axes;

    public class TextAnnotationExamples
    {
        [Export("Annotations/TextAnnotation")]
        public static PlotModel TextAnnotation()
        {
            var model = new PlotModel { Title = nameof(TextAnnotation) };
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
            model.Annotations.Add(new TextAnnotation { TextPosition = new DataPoint(50,50),  Text = nameof(TextAnnotation) });
            return model;
        }
    }
}
