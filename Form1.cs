using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wf324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            lblResistor1.Text = "R1 = " + trackBar1.Value + " ";
            CalculateTotalResistance();
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            lblResistor2.Text = "R2 = " + trackBar2.Value + " ";
            CalculateTotalResistance();
        }

        private void RadioButtonSequential_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalResistance();
        }

        private void RadioButtonParallel_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalResistance();
        }

        private void CalculateTotalResistance()
        {
            double r1 = trackBar1.Value;
            double r2 = trackBar2.Value;
            double totalResistance;

            if (radioButtonSequential.Checked)
            {
                totalResistance = r1 + r2;
            }
            else
            {
                if (r1 == 0 || r2 == 0)
                {
                    totalResistance = 0;
                }
                else
                {
                    totalResistance = 1 / (1 / r1 + 1 / r2);
                }
            }

            lblTotalResistance.Text = "R =  " + Math.Round(totalResistance, 2) + " ";
        }
    }
}