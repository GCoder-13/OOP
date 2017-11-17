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
        double cursUSD => Double.Parse(this.textBoxCursUSD.Text);
        double cursGRN => Double.Parse(this.textBoxCursGRN.Text);
        double USD => Double.Parse(this.textBoxUSD.Text);
        double GRN => Double.Parse(this.textBoxGRN.Text);
        public Currency(App form)
        {
            mainForm = form;
            InitializeComponent();
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)8)
                e.KeyChar = (char)0;
            else if (e.KeyChar == '.')
                e.KeyChar = ',';
        }

        private void Currency_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (this.radioSell.Checked)
            {
                this.radioBuy.Checked = true;
            }
            else
            {
                this.radioSell.Checked = true;
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

        private void radioBuy_CheckedChanged(object sender, EventArgs e)
        {
            this.labelArrow.Text = "<-";
            this.textBoxCursUSD.Enabled = true;
            this.textBoxCursGRN.Enabled = false;
        }

        private void radioSell_CheckedChanged(object sender, EventArgs e)
        {
            this.labelArrow.Text = "->";
            this.textBoxCursUSD.Enabled = false;
            this.textBoxCursGRN.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioBuy.Checked)
            {
                this.textBoxGRN.Text = (cursUSD * USD).ToString();
            }
            else
            {
                this.textBoxGRN.Text = (cursGRN * USD).ToString();
            }
        }
    }
}
