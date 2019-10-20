open OxyPlot
open OxyPlot.Series
open OxyPlot.Core.Drawing

let myModel = PlotModel()
do
    myModel.Title <- "Hello world from F#"
    myModel.Series.Add(FunctionSeries(cos, 0.0, 10.0, 0.1, "cos(x)"))

[<EntryPoint>]
let main argv =
    PngExporter.Export(myModel, "HelloWorld.png", 600, 300, OxyColors.White)
    0 // return an integer exit code
