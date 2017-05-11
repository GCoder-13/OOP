using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class FormLab_5 : Form
    {
        private readonly string[] MEASURE =
        {
            "мм",
            "см",
            "дм",
            "м",
            "км",
            "миля",
            "фут",
            "ярд"
        };
        private double standartMeasure = default(double);

        public FormLab_5()
        {
            InitializeComponent();
            this.comboBoxStartMeasure.Items.AddRange(MEASURE);
            this.comboBoxStartMeasure.SelectedIndex = 0;
            this.comboBoxFinishMeasure.Items.AddRange(MEASURE);
            this.comboBoxFinishMeasure.SelectedIndex = 1;
        }

        private void OnlyNumeric(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
                e.KeyChar = (char)0;
            else if (e.KeyChar == '.')
                e.KeyChar = ',';
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBoxStartMeasure.Text))
            {
                MessageBox.Show("Заповніть, будь ласка, всі поля",
                "Попередження!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            standartMeasure = Double.Parse(this.textBoxStartMeasure.Text);

            switch (this.comboBoxStartMeasure.SelectedIndex)
            {
                case 0:
                    standartMeasure /= 1000;
                    break;
                case 1:
                    standartMeasure /= 100;
                    break;
                case 2:
                    standartMeasure /= 10;
                    break;
                case 3:
                    break;
                case 4:
                    standartMeasure *= 1000;
                    break;
                case 5:
                    standartMeasure *= 1609;
                    break;
                case 6:
                    standartMeasure *= 0.305;
                    break;
                case 7:
                    standartMeasure *= 0.914;
                    break;
            }

            double result = default(double);

            switch (this.comboBoxFinishMeasure.SelectedIndex)
            {
                case 0:
                    result = standartMeasure * 1000;
                    break;
                case 1:
                    result = standartMeasure * 100;
                    break;
                case 2:
                    result = standartMeasure * 10;
                    break;
                case 3:
                    break;
                case 4:
                    result = standartMeasure / 1000;
                    break;
                case 5:
                    result = standartMeasure / 1609;
                    break;
                case 6:
                    result = standartMeasure / 0.305;
                    break;
                case 7:
                    result = standartMeasure / 0.914;
                    break;
            }
            this.textBoxResult.Text = result.ToString();
        }
    }
}
