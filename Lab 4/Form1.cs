using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        private double[] price = { 369, 349, 189, 179, 299, 149, 199 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Chacked(object sender, EventArgs e)
        {
            CheckBox sw = (CheckBox)sender;
            int index = 0;
            switch(sw.Name.Last<char>())
            {
                case '1':
                    index = 0;
                    break;
                case '2':
                    index = 1;
                    break;
                case '3':
                    index = 2;
                    break;
                case '4':
                    index = 3;
                    break;
                case '5':
                    index = 4;
                    break;
                case '6':
                    index = 5;
                    break;
                case '7':
                    index = 6;
                    break;
            }
            if(sw.Checked)
            {
                double temp = Double.Parse(tBPrice.Text);
                tBPrice.Text = Math.Round((temp + price[index]), 2).ToString();
            }
            else
            {
                double temp = Double.Parse(tBPrice.Text);
                tBPrice.Text = Math.Round((temp - price[index]),2).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;

        }
    }
}
