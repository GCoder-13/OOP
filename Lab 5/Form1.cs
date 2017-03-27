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
    public partial class MainForm : Form
    {
        bool sw = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpKey(object sender, KeyEventArgs e)
        {
            CharLabel.ResetText();
            ValueLabel.ResetText();
            ShiftLabel.ResetText();
            UpdateKeyPanel();
            sw = false;
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void PressKey(object sender, KeyPressEventArgs e)
        {
            switch ((Keys)e.KeyChar)
            {
                case (Keys.Back):
                    ShiftLabel.Text = "BackSpace";
                    break;
                case (Keys.Enter):
                    ShiftLabel.Text = "Enter";
                    break;
                case (Keys.Escape):
                    ShiftLabel.Text = "Esc";
                    break;
                case (Keys.Space):
                    ShiftLabel.Text = "Space";
                    break;
                default:
                    CharLabel.Text = e.KeyChar.ToString();
                    break;
            }
            
            ValueLabel.Text = Convert.ToInt32(e.KeyChar).ToString();
        }

        private void DownKey(object sender, KeyEventArgs e)
        {
            switch ((Keys)e.KeyCode)
            {
                case (Keys.Delete):
                    ShiftLabel.Text = "Delete";
                    break;
                case (Keys.ShiftKey):
                    ShiftLabel.Text = "Shift";
                    break;
                case (Keys.ControlKey):
                    ShiftLabel.Text = "Control";
                    break;
                case ((Keys)18):
                    ShiftLabel.Text = "Alt";
                    break;
                case (Keys.Insert):
                    ShiftLabel.Text = "Insert";
                    break;
                case (Keys.Tab):
                    ShiftLabel.Text = "Tab";
                    break;
            }

            ValueLabel.Text = e.KeyValue.ToString();
            UpdateKeyPanel();

            DoubleKeys(e);
        }

        private void DoubleKeys(KeyEventArgs e)
        {
            if (e.Shift && !sw)
                sw = true;
            else if (sw && e.KeyCode == Keys.P)
            {
                if (this.Width > this.Height)
                    this.Height = this.Width;
                else this.Width = this.Height;
            }
        }

        private void UpdateKeyPanel()
        {
            CapsLockLabel.Enabled = IsKeyLocked(Keys.CapsLock);
            NumLockLabel.Enabled = IsKeyLocked(Keys.NumLock);
            ScrollLockLabel.Enabled = IsKeyLocked(Keys.Scroll);
            InsLabel.Enabled = IsKeyLocked(Keys.Insert);
        }

        private void Number(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == 'e' || e.KeyChar == 'E' || e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == ',' || (e.KeyChar >= '0' && e.KeyChar <= '9'))
                return;
            else if (e.KeyChar == '.')
                e.KeyChar = ',';
            else e.KeyChar = (char)0;
        }

        private void btnSumEx3_Click(object sender, EventArgs e)
        {
            textBoxValue2.BackColor = Color.Red;
            labelResEx3.Text = String.Format("{0:0.00e-0}", (Double.Parse(textBoxValue1.Text) + Double.Parse(textBoxValue2.Text)));
            //labelResEx3.Text = String.Format("{0:#.##e-0}", (Double.Parse(textBoxValue1.Text) + Double.Parse(textBoxValue2.Text)));
        }
    }
}
