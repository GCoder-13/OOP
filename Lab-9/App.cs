using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class App : Form
    {
        double leftBorder
        {
            get
            {
                return Double.Parse(this.textBoxLeft.Text);
            }
        }
        double rightBorder
        {
            get
            {
                return Double.Parse(this.textBoxRight.Text);
            }
        }
        double step
        {
            get
            {
                return Double.Parse(this.textBoxStep.Text);
            }
        }
        double[] rez
        {
            get
            {
                int n = Convert.ToInt32((this.rightBorder - this.leftBorder) / this.step);
                double[] arr = new double[n];
                // TODO: tabulate y = sin(x) + 1;
                for (double i = this.leftBorder; i < n; i += this.step)
                {

                }
                return arr;
            }
            set
            {
                this.rez = value;
            }
        }
        double[] rezDerivative { get; set; }

        public App()
        {
            InitializeComponent();
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)8)
                e.KeyChar = (char)0;
            else if (e.KeyChar == '.')
                e.KeyChar = ',';
        }

        private void clearFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxOutput.ResetText();
        }

        private void tabulateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.textBoxLeft.Text) && String.IsNullOrWhiteSpace(this.textBoxRight.Text) && String.IsNullOrWhiteSpace(this.textBoxStep.Text))
            {
                MessageBox.Show("Заповніть всі поля.", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show($"{this.leftBorder}");
        }
    }
}
