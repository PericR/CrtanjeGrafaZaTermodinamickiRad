namespace CrtanjeGrafovaZaRad
{
    partial class Graph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.PVGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.PVGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // PVGraph
            // 
            chartArea1.Name = "P/VGraph";
            this.PVGraph.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "P/VGraph";
            legend1.Name = "Legend1";
            this.PVGraph.Legends.Add(legend1);
            this.PVGraph.Location = new System.Drawing.Point(12, 12);
            this.PVGraph.Name = "PVGraph";
            this.PVGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.PVGraph.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Maroon};
            series1.BorderWidth = 4;
            series1.ChartArea = "P/VGraph";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Maroon;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 0;
            series1.Name = "Pritisak/Volumen";
            series1.YValuesPerPoint = 6;
            this.PVGraph.Series.Add(series1);
            this.PVGraph.Size = new System.Drawing.Size(688, 571);
            this.PVGraph.TabIndex = 0;
            this.PVGraph.Text = "chart1";
            title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            title1.Name = "Graf rada";
            title1.Text = "Graf Rada";
            this.PVGraph.Titles.Add(title1);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 595);
            this.Controls.Add(this.PVGraph);
            this.Name = "Graph";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PVGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PVGraph;
    }
}