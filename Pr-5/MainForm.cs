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
    public partial class MainForm : Form
    {
        public Action actionForm = default(Action);
        public Result resultForm = default(Result);

        public MainForm()
        {
            InitializeComponent();
            this.actionForm = new Action(this);
            this.resultForm = new Result(this);
        }

        private void labelPlus_Click(object sender, EventArgs e)
        {
            this.actionForm.operation = "+";
            this.actionForm.Show();
            this.Visible = false;
        }

        private void labelMinus_Click(object sender, EventArgs e)
        {
            this.actionForm.operation = "-";
            this.actionForm.Show();
            this.Visible = false;
        }

        private void labelMnozh_Click(object sender, EventArgs e)
        {
            this.actionForm.operation = "*";
            this.actionForm.Show();
            this.Visible = false;
        }

        private void labelDil_Click(object sender, EventArgs e)
        {
            this.actionForm.operation = "/";
            this.actionForm.Show();
            this.Visible = false;
        }
    }
}
