using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrtanjeGrafovaZaRad
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            List<GraphPoint> points = PressureVolumeGraph.UpdateListOfPoints();
            PVGraph.DataSource = points;
            PVGraph.ChartAreas["P/VGraph"].AxisX.Title = "Volumen";
            PVGraph.ChartAreas["P/VGraph"].AxisY.Title = "Pritisak";

            PVGraph.Series["Pritisak/Volumen"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            PVGraph.Series["Pritisak/Volumen"].MarkerSize = 15;
            
            PVGraph.Series["Pritisak/Volumen"].XValueMember = "Volume";
            PVGraph.Series["Pritisak/Volumen"].YValueMembers = "Pressure";
        }
    }
}
