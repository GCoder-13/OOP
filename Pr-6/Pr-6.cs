using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_6
{
    public partial class Pr_6 : Form
    {
        bool canDot = true;
        double value = 0;
        string action;
        bool switchAction = false;

        public Pr_6()
        {
            InitializeComponent();
            Activate();
        }

        private void OnlyNumeric(object sender, KeyPressEventArgs e)
        {
            string text = this.textBoxResult.Text;
            if (this.textBoxResult.Text == "0")
                this.textBoxResult.Clear();
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
            {
                Button btn = new Button();
                btn.Text = e.KeyChar.ToString();
                operator_Click(btn, e);
            }
            else if(e.KeyChar == '=' || e.KeyChar == (char)Keys.Enter)
            {
                btnEqual_Click(sender, e);
            }

            if (canDot && e.KeyChar == ',')
            {
                canDot = false;
            }
            else if (e.KeyChar == (char)Keys.Back && !String.IsNullOrEmpty(text) && text.Last() == ',')
            {
                canDot = true;
            }
            else if((e.KeyChar < '0' || e.KeyChar >'9') && e.KeyChar != (char)Keys.Back)
            {
                e.KeyChar = (char)0;
            }
        }

        private void btnNumeric_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if (this.textBoxResult.Text == "0")
            {
                this.textBoxResult.Clear();
            }
                
            this.textBoxResult.Text += btn.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (this.canDot)
            {
                this.textBoxResult.Text += ',';
            }
            this.canDot = false;
        }

        private void btnBackspase_Click(object sender, EventArgs e)
        {
            string text = this.textBoxResult.Text;
            if (!String.IsNullOrEmpty(text))
            {
                if (text.Last() == ',')
                {
                    canDot = true;
                }
                this.textBoxResult.Text = text = text.Remove(text.Length - 1);
            }
            if (String.IsNullOrEmpty(text))
            {
                this.textBoxResult.Text = "0";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.textBoxResult.Text = "0";
            this.canDot = true;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            this.action = btn.Text;
            this.value = Double.Parse(this.textBoxResult.Text);

            if (this.switchAction)
            {
                this.value = Double.Parse(this.labelValue1.Text.Remove(this.labelValue1.Text.Length - 1));
            }
            
            this.labelValue1.Text = this.value + this.action;
            this.textBoxResult.Text = "0";
            this.switchAction = true;
            this.canDot = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.labelValue1.Text))
            {
                return;
            }
            double value2 = Double.Parse(this.textBoxResult.Text);
            double result = 0;
            this.labelValue1.ResetText();

            switch (action)
            {
                case "+":
                    result = value + value2;
                    break;
                case "-":
                    result = value - value2;
                    break;
                case "*":
                    result = value * value2;
                    break;
                case "/":
                    result = value / value2;
                    break;
                default:
                    break;
            }

            this.action = "";
            this.textBoxResult.Text = result.ToString();
            this.switchAction = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBoxResult.Text = "0";
            this.labelValue1.Text = "";
            this.value = 0;
            this.action = "";
            this.switchAction = false;
        }
    }
}
