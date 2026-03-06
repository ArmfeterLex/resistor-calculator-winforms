namespace wf324
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label lblResistor1;
        private System.Windows.Forms.Label lblResistor2;
        private System.Windows.Forms.RadioButton radioButtonSequential;
        private System.Windows.Forms.RadioButton radioButtonParallel;
        private System.Windows.Forms.Label lblTotalResistance;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            lblResistor1 = new Label();
            lblResistor2 = new Label();
            radioButtonSequential = new RadioButton();
            radioButtonParallel = new RadioButton();
            lblTotalResistance = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(122, 12);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(318, 56);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 10;
            trackBar1.Scroll += TrackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(122, 58);
            trackBar2.Maximum = 100;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(318, 56);
            trackBar2.TabIndex = 1;
            trackBar2.Value = 10;
            trackBar2.Scroll += TrackBar2_Scroll;
            // 
            // lblResistor1
            // 
            lblResistor1.AutoSize = true;
            lblResistor1.Location = new Point(33, 19);
            lblResistor1.Name = "lblResistor1";
            lblResistor1.Size = new Size(40, 20);
            lblResistor1.TabIndex = 2;
            lblResistor1.Text = "R1 =";
            // 
            // lblResistor2
            // 
            lblResistor2.AutoSize = true;
            lblResistor2.Location = new Point(33, 65);
            lblResistor2.Name = "lblResistor2";
            lblResistor2.Size = new Size(40, 20);
            lblResistor2.TabIndex = 3;
            lblResistor2.Text = "R2 =";
            // 
            // radioButtonSequential
            // 
            radioButtonSequential.AutoSize = true;
            radioButtonSequential.Checked = true;
            radioButtonSequential.Location = new Point(88, 120);
            radioButtonSequential.Name = "radioButtonSequential";
            radioButtonSequential.Size = new Size(154, 24);
            radioButtonSequential.TabIndex = 4;
            radioButtonSequential.TabStop = true;
            radioButtonSequential.Text = "Последовательно";
            radioButtonSequential.CheckedChanged += RadioButtonSequential_CheckedChanged;
            // 
            // radioButtonParallel
            // 
            radioButtonParallel.AutoSize = true;
            radioButtonParallel.Location = new Point(248, 120);
            radioButtonParallel.Name = "radioButtonParallel";
            radioButtonParallel.Size = new Size(124, 24);
            radioButtonParallel.TabIndex = 5;
            radioButtonParallel.Text = "Параллельно";
            radioButtonParallel.CheckedChanged += RadioButtonParallel_CheckedChanged;
            // 
            // lblTotalResistance
            // 
            lblTotalResistance.AutoSize = true;
            lblTotalResistance.BackColor = SystemColors.Control;
            lblTotalResistance.Font = new Font("Segoe UI", 20F);
            lblTotalResistance.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotalResistance.Location = new Point(185, 159);
            lblTotalResistance.Name = "lblTotalResistance";
            lblTotalResistance.Size = new Size(81, 46);
            lblTotalResistance.TabIndex = 6;
            lblTotalResistance.Text = "R = ";
            // 
            // Form1
            // 
            ClientSize = new Size(462, 227);
            Controls.Add(trackBar1);
            Controls.Add(trackBar2);
            Controls.Add(lblResistor1);
            Controls.Add(lblResistor2);
            Controls.Add(radioButtonSequential);
            Controls.Add(radioButtonParallel);
            Controls.Add(lblTotalResistance);
            Name = "Form1";
            Text = "Расчет сопротивления";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}