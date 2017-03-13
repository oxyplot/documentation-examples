namespace ExampleGenerator
{
    using OxyPlot;

    public static class BindingExamples
    {
        [Export("BindingExamples/Example1")]
        public static PlotModel Example1()
        {
            return new PlotModel { Title = "TODO" };
        }
    }
}