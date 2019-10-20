namespace ConsoleApp1
{
    using OxyPlot;
    using OxyPlot.Core.Drawing;
    using OxyPlot.Series;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var pm = new PlotModel { Title = "Hello world from C#" };
            pm.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 100));
            PngExporter.Export(pm, "HelloWorld.png", 600, 300, OxyColors.White);
        }
    }
}
