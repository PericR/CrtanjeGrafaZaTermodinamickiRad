namespace CrtanjeGrafovaZaRad
{
    partial class AddPoint
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
            this.PressureLabel = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.AddPointGroupBox = new System.Windows.Forms.GroupBox();
            this.VolumeTextBox = new System.Windows.Forms.TextBox();
            this.PressureTextBox = new System.Windows.Forms.TextBox();
            this.AddPointSubmitButton = new System.Windows.Forms.Button();
            this.AddPointGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.Location = new System.Drawing.Point(6, 32);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(62, 13);
            this.PressureLabel.TabIndex = 0;
            this.PressureLabel.Text = "Pritisak (pa)";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(6, 58);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(77, 13);
            this.VolumeLabel.TabIndex = 1;
            this.VolumeLabel.Text = "Volumen (cm3)";
            // 
            // AddPointGroupBox
            // 
            this.AddPointGroupBox.Controls.Add(this.VolumeTextBox);
            this.AddPointGroupBox.Controls.Add(this.PressureTextBox);
            this.AddPointGroupBox.Controls.Add(this.PressureLabel);
            this.AddPointGroupBox.Controls.Add(this.VolumeLabel);
            this.AddPointGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AddPointGroupBox.Name = "AddPointGroupBox";
            this.AddPointGroupBox.Size = new System.Drawing.Size(213, 104);
            this.AddPointGroupBox.TabIndex = 2;
            this.AddPointGroupBox.TabStop = false;
            this.AddPointGroupBox.Text = "Unos Podataka";
            // 
            // VolumeTextBox
            // 
            this.VolumeTextBox.Location = new System.Drawing.Point(94, 55);
            this.VolumeTextBox.Name = "VolumeTextBox";
            this.VolumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.VolumeTextBox.TabIndex = 3;
            // 
            // PressureTextBox
            // 
            this.PressureTextBox.Location = new System.Drawing.Point(94, 29);
            this.PressureTextBox.Name = "PressureTextBox";
            this.PressureTextBox.Size = new System.Drawing.Size(100, 20);
            this.PressureTextBox.TabIndex = 2;
            // 
            // AddPointSubmitButton
            // 
            this.AddPointSubmitButton.Location = new System.Drawing.Point(131, 132);
            this.AddPointSubmitButton.Name = "AddPointSubmitButton";
            this.AddPointSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.AddPointSubmitButton.TabIndex = 4;
            this.AddPointSubmitButton.Text = "OK";
            this.AddPointSubmitButton.UseVisualStyleBackColor = true;
            this.AddPointSubmitButton.Click += new System.EventHandler(this.AddPointSubmitButton_Click);
            // 
            // AddPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 183);
            this.Controls.Add(this.AddPointSubmitButton);
            this.Controls.Add(this.AddPointGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPoint";
            this.Text = "Dodaj Točku";
            this.AddPointGroupBox.ResumeLayout(false);
            this.AddPointGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.GroupBox AddPointGroupBox;
        private System.Windows.Forms.TextBox VolumeTextBox;
        private System.Windows.Forms.TextBox PressureTextBox;
        private System.Windows.Forms.Button AddPointSubmitButton;
    }
}