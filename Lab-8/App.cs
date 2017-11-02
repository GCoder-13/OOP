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
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void labelCurrency_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Currency formCurrency = new Currency(this);
            formCurrency.Show();
        }

        private void labelConverter_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Converter formConverter = new Converter(this);
            formConverter.Show();
        }
    }
}
