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
    public partial class Lab_5_Ex_2 : Form
    {
        private MainForm formMenu;
        public Lab_5_Ex_2(MainForm main)
        {
            this.formMenu = main;
            InitializeComponent();
        }

        private void Lab_5_Ex_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.formMenu.Visible = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int stHour = (int)this.numUpDownStHour.Value * 3600;
            int stMinute = (int)this.numUpDownStMinute.Value * 60;
            int stSecond = (int)this.numUpDownStSecond.Value;
            int stTime = stHour + stMinute + stSecond;

            int fnHour = (int)this.numUpDownFnHour.Value * 3600;
            int fnMinute = (int)this.numUpDownFnMinute.Value * 60;
            int fnSecond = (int)this.numUpDownFnSecond.Value;
            int fnTime = fnHour + fnMinute + fnSecond;

            int result;

            if(stTime <= fnTime)
            {
                result = fnTime - stTime;
            }
            else
            {
                result = stTime - fnTime + 86400;
            }

            this.textBoxResult.Text = result.ToString();
        }
    }
}
