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
    public partial class AddPoint : Form
    {
        public AddPoint()
        {
            InitializeComponent();
        }

        private void AddPointSubmitButton_Click(object sender, EventArgs e)
        {
            if (PressureVolumeGraph.AddPoint(PressureTextBox.Text, VolumeTextBox.Text))
            {                
                this.Close();
            }
            else
            {
                MessageBox.Show("Svi podatci moraju biti unijeti kao brojevi");
            }
        }
    }
}
