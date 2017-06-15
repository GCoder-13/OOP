using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_5
{
    public partial class Result : Form
    {
        MainForm mainForm = default(MainForm);
        public double result { set; get; } = 0;
        
        public Result(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            colorDialog1.FullOpen = true;
            colorDialog1.Color = this.BackColor;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainForm.Visible = true;
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Result_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainForm.Visible = true;
            this.mainForm.resultForm = new Result(this.mainForm);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.mainForm.actionForm.Visible = true;
        }

        private void PlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainForm.actionForm.operation = "+";
            this.Visible = false;
            this.mainForm.actionForm.Visible = true;
        }

        private void MinusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainForm.actionForm.operation = "-";
            this.Visible = false;
            this.mainForm.actionForm.Visible = true;
        }

        private void MnozhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainForm.actionForm.operation = "*";
            this.Visible = false;
            this.mainForm.actionForm.Visible = true;
        }

        private void DilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainForm.actionForm.operation = "/";
            this.Visible = false;
            this.mainForm.actionForm.Visible = true;
        }

        private void Result_Activated(object sender, EventArgs e)
        {
            this.lblResult.Text = Math.Round(this.result, 5).ToString();
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            this.lblResult.ForeColor = colorDialog1.Color;
            this.label3.ForeColor = colorDialog1.Color;
        }
    }
}
