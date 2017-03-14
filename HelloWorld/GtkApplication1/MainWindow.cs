using System;
using Gtk;
using OxyPlot;
using OxyPlot.GtkSharp;
using System.Linq;
using OxyPlot.Series;
using System.Collections.Generic;
using OxyPlot.Axes;

public partial class MainWindow: Gtk.Window {
	public MainWindow() : base(Gtk.WindowType.Toplevel) {
		Build();

		var plotView = new PlotView();
		this.Add(plotView);
		plotView.ShowAll();

		var myModel = new PlotModel { Title = "Example 1" };
		myModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
		plotView.Model = myModel;
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a) {
		Application.Quit();
		a.RetVal = true;
	}
}
