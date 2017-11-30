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
        double[] rez { get; set; }
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
            int n = Convert.ToInt32((this.rightBorder - this.leftBorder) / this.step);
            double value = this.leftBorder;
            this.richTextBoxOutput.ResetText();
            this.chart1.Series["Y"].ResetIsValueShownAsLabel();
            this.chart1.Series["dY"].ResetIsValueShownAsLabel();
            if (this.checkBox1.Checked && !this.checkBox3.Checked)
            {
                this.richTextBoxOutput.Text = "X \t Y \n";
            }
            if (this.checkBox3.Checked)
            {
                this.richTextBoxOutput.Text = "X \t Y \t Y\'\n";
            }
            for (int i = 0; i < n; i++)
            {
                double y = Math.Sin(value) + 1;
                double dy = -Math.Cos(value);
                if (this.checkBox1.Checked && !this.checkBox3.Checked)
                {
                    this.richTextBoxOutput.Text += $"{value} \t {Math.Round(y, 2)}\n";
                }
                if(this.checkBox1.Checked)
                {
                    this.chart1.Series["Y"].Points.AddXY(value, y);
                }
                if (this.checkBox3.Checked)
                {
                    this.chart1.Series["dY"].Points.AddXY(value, dy);
                    this.richTextBoxOutput.Text += $"{value} \t {Math.Round(y, 2)} \t {Math.Round(dy, 2)}\n";
                }
                value += this.step;
            }
            if (this.checkBox2.Checked && this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.richTextBoxOutput.SaveFile(this.saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                GC.Collect();
            }
        }
    }
}
