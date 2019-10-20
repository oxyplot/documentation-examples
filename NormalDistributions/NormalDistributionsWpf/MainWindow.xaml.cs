namespace NormalDistributionsWpf
{
    using NormalDistributions.Shared;
    using OxyPlot;

    public partial class MainWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.Model = NormalDistributionModel.Create();
            this.DataContext = this;
        }

        public PlotModel Model { get; set; }
    }
}
