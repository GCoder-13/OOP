using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Currency : Form
    {
        App mainForm = default(App);
        public Currency(App form)
        {
            mainForm = form;
            InitializeComponent();
        }

        private void Currency_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (this.radioSell.Checked)
            {
                this.radioSell.Checked = false;
                this.radioBuy.Checked = true;
                this.labelArrow.Text = "<-";
            }
            else
            {
                this.radioSell.Checked = true;
                this.radioBuy.Checked = false;
                this.labelArrow.Text = "->";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(TextBox item in this.Controls.OfType<TextBox>())
            {
                item.ResetText();
            }
        }
    }
}
