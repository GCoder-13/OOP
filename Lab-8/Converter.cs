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
    public partial class Converter : Form
    {
        App mainForm = default(App);
        public Converter(App form)
        {
            mainForm = form;
            InitializeComponent();
        }

        private void Converter_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void radioButtonRight_CheckedChanged(object sender, EventArgs e)
        {
            this.labelArrow.Text = "->";
            this.textBox1.Enabled = true;
            this.textBox2.Enabled = false;
            foreach (TextBox item in this.Controls.OfType<TextBox>())
            {
                item.Text = "0";
            }
        }

        private void radioButtonLeft_CheckedChanged(object sender, EventArgs e)
        {
            this.labelArrow.Text = "<-";
            this.textBox1.Enabled = false;
            this.textBox2.Enabled = true;
            foreach (TextBox item in this.Controls.OfType<TextBox>())
            {
                item.Text = "0";
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
                item.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.textBox2.Text = Convert.ToString(Double.Parse(this.textBox1.Text) * 1.609344);
            }
            else if (this.radioButton2.Checked)
            {
                this.textBox2.Text = Convert.ToString(Double.Parse(this.textBox1.Text) * 1.852);
            }
            else if (this.radioButton3.Checked)
            {
                this.textBox1.Text = Convert.ToString(Double.Parse(this.textBox2.Text) / 1.609344);
            }
            else if (this.radioButton4.Checked)
            {
                this.textBox1.Text = Convert.ToString(Double.Parse(this.textBox2.Text) / 1.852);
            }
        }
    }
}
