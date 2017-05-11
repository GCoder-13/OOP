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
    public partial class FormMain : Form
    {
        delegate bool IsEmpty(string str);
        enum Connection
        {
            Parallel,
            Consistent
        }

        IsEmpty isEmpty = String.IsNullOrEmpty;
        Connection swRadioButton;        

        public FormMain()
        {
            InitializeComponent();
        }

        private void OnlyNumeric(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
                e.KeyChar = (char)0;
            else if (e.KeyChar == '.')
                e.KeyChar = ',';
        }

        private bool TextBox_FillAll()
        {
            if (!(isEmpty(this.textBoxR1.Text) && isEmpty(this.textBoxR2.Text)))
                return true;
            MessageBox.Show("Заповніть, будь ласка, всі поля",
                "Попередження!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            return false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!TextBox_FillAll())
                return;

            double r1 = Double.Parse(this.textBoxR1.Text);
            double r2 = Double.Parse(this.textBoxR2.Text);

            switch (swRadioButton)
            {
                case Connection.Parallel:
                    textBoxResult.Text = Math.Round(((r1 * r2) / (r1 + r2)), 2).ToString();
                    break;
                case Connection.Consistent:
                    textBoxResult.Text = Math.Round((r1 + r2), 2).ToString();
                    break;
            }
        }

        private void SwitchRadioButton(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            swRadioButton = (btn.Equals(radioButtonConsistent)) ? Connection.Consistent : Connection.Parallel; 
        }
    }
}
