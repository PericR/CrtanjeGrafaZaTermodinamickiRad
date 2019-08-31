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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void NewPointButton_Click(object sender, EventArgs e)
        {
            AddPoint newPoint = new AddPoint();
            newPoint.ShowDialog();
            List<GraphPoint> points = PressureVolumeGraph.UpdateListOfPoints();
            PointsDataGridView.DataSource = points;
        }

        private void DrawGraphButton_Click(object sender, EventArgs e)
        {
            Graph newGraph = new Graph();
            newGraph.ShowDialog();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            PressureVolumeGraph.DeletePoints();
            List<GraphPoint> points = PressureVolumeGraph.UpdateListOfPoints();
            PointsDataGridView.DataSource = points;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<GraphPoint> points = PressureVolumeGraph.UpdateListOfPoints();
            PointsDataGridView.DataSource = points;
        }
    }
}
