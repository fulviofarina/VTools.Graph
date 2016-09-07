using System.Data;
using System.Drawing;
using System.Windows.Forms;
using NPlot;
using Rsx.Math;

namespace VTools
{
    public partial class Graph : UserControl
    {
        private PointPlot plot2;

        public Graph()
        {
            InitializeComponent();

            // AuxiliarForm form = new AuxiliarForm();
            // form.Populate(this);
            // form.Text = Title;
            // form.Show();

            Legend legend = new Legend();
            plot.Legend = legend;
        }

        public void SetGraph(ref DataColumn X, double powerX, bool logX, double logXbase, ref DataColumn Y, double powerY, bool logY, double logYbase, string label)
        {
            plot.Clear();
            plot2 = new PointPlot(new Marker(Marker.MarkerType.Circle, 2, new Pen(Color.Green, 2)));
            plot2.OrdinateData = MyMath.ListFrom(Y, powerY, logY, logYbase);
            plot2.AbscissaData = MyMath.ListFrom(X, powerX, logX, logXbase);
            plot2.ShowInLegend = true;
            plot2.Label = label;
            plot.Title = label;
            plot.Add(plot2);
            plot.Refresh();
        }
    }
}