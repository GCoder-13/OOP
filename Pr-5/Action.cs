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
    public partial class Action : Form
    {
        MainForm mainForm = default(MainForm);
        public string operation { set; get; } = default(string);

        public Action(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void Action_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainForm.Visible = true;
            this.mainForm.actionForm = new Action(this.mainForm);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.textBox1.Text) || String.IsNullOrEmpty(this.textBox2.Text))
            {
                MessageBox.Show(
                    "Заповніть, будь ласка, всі поля.",
                    "Попередження!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation
                    );
                return;
            }
            double value1 = Double.Parse(this.textBox1.Text);
            double value2 = Double.Parse(this.textBox2.Text);
            switch (this.operation)
            {
                case "+":
                    this.mainForm.resultForm.result = value1 + value2;
                    break;
                case "-":
                    this.mainForm.resultForm.result = value1 - value2;
                    break;
                case "*":
                    this.mainForm.resultForm.result = value1 * value2;
                    break;
                case "/":
                    this.mainForm.resultForm.result = value1 / value2;
                    break;
            }
            this.mainForm.resultForm.Show();
            this.Visible = false;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainForm.Visible = true;
            this.Close();
            this.mainForm.actionForm = new Action(this.mainForm);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
