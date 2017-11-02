using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    int rez = 0;
                    for (int r = 0; r < 4; r++)
                    {
                        rez += Int32.Parse(panel1.Controls["a" + (i + 1).ToString() + (r + 1).ToString()].Text) * Int32.Parse(panel2.Controls["b" + (r + 1).ToString() + (j + 1).ToString()].Text);
                    }
                    panel3.Controls["c" + (i + 1).ToString() + (j + 1).ToString()].Text = rez.ToString();
                }

            }
        }
    }
}
