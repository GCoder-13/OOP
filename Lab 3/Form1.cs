using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)8)
                e.KeyChar = (char)0;
            else if (e.KeyChar == '.')
                e.KeyChar = ',';
        }

        private void Calculate(object sender, EventArgs e)
        {
            if(textBoxSum.Text == "" || textBoxTime.Text == "" || textBoxRate.Text == "")
            {
                MessageBox.Show("Заповніть всі поля", "Помилка!");
                return;
            }
            double sum = Double.Parse(textBoxSum.Text);
            int time = Int32.Parse(textBoxTime.Text);
            double rate = Double.Parse(textBoxRate.Text);
            double depositAmount = sum;

            for (int i = 1; i <= time; i++)
                depositAmount += depositAmount * rate / 100;
            textBoxDepositAmount.Text = Convert.ToString(Math.Round(depositAmount, 2));
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (textBoxPrice.Text == "" || textBoxConsumption.Text == "" || textBoxDistance.Text == "")
            {
                MessageBox.Show("Заповніть всі поля", "Помилка!");
                return;
            }
            double price = Double.Parse(textBoxPrice.Text);
            double consumption = Double.Parse(textBoxConsumption.Text);
            double distance = Double.Parse(textBoxDistance.Text);
            double cost = (consumption / 100) * price * distance;
            textBoxCost.Text = Convert.ToString(Math.Round(cost, 2));
        }
    }
}
