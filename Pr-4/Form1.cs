using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string text = this.textBoxInput.Text;
            if (!String.IsNullOrEmpty(text))
            {
                this.listBox1.Items.Add(text);
                this.textBoxInput.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index != -1)
                this.listBox1.Items.RemoveAt(index);
        }
    }
}
