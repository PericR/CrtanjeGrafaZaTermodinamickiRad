namespace CrtanjeGrafovaZaRad
{
    partial class MainForm
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
            this.NewPointButton = new System.Windows.Forms.Button();
            this.DrawGraphButton = new System.Windows.Forms.Button();
            this.PointsDataGridView = new System.Windows.Forms.DataGridView();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PointsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NewPointButton
            // 
            this.NewPointButton.Location = new System.Drawing.Point(12, 37);
            this.NewPointButton.Name = "NewPointButton";
            this.NewPointButton.Size = new System.Drawing.Size(75, 23);
            this.NewPointButton.TabIndex = 0;
            this.NewPointButton.Text = "Nova Točka";
            this.NewPointButton.UseVisualStyleBackColor = true;
            this.NewPointButton.Click += new System.EventHandler(this.NewPointButton_Click);
            // 
            // DrawGraphButton
            // 
            this.DrawGraphButton.Location = new System.Drawing.Point(93, 37);
            this.DrawGraphButton.Name = "DrawGraphButton";
            this.DrawGraphButton.Size = new System.Drawing.Size(75, 23);
            this.DrawGraphButton.TabIndex = 1;
            this.DrawGraphButton.Text = "Nacrtaj Graf";
            this.DrawGraphButton.UseVisualStyleBackColor = true;
            this.DrawGraphButton.Click += new System.EventHandler(this.DrawGraphButton_Click);
            // 
            // PointsDataGridView
            // 
            this.PointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointsDataGridView.Location = new System.Drawing.Point(12, 115);
            this.PointsDataGridView.Name = "PointsDataGridView";
            this.PointsDataGridView.Size = new System.Drawing.Size(237, 110);
            this.PointsDataGridView.TabIndex = 3;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(174, 37);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Obriši Točke";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(267, 252);
            this.Controls.Add(this.PointsDataGridView);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.DrawGraphButton);
            this.Controls.Add(this.NewPointButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Crtanje Grafova Za Rad";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PointsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewPointButton;
        private System.Windows.Forms.Button DrawGraphButton;
        private System.Windows.Forms.DataGridView PointsDataGridView;
        private System.Windows.Forms.Button ResetButton;
    }
}

