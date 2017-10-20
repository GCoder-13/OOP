using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void localDBDataSet_Initialized(object sender, EventArgs e)
        {
            try
            {
                this.drinksTableAdapter.Fill(this.localDBDataSet.Drinks);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListEditor listEditor = new ListEditor(this);
            this.Visible = false;
            listEditor.Show();
        }

        private void btnToUnloved_Click(object sender, EventArgs e)
        {
            object select = this.listBoxMain.SelectedItem;
            if (select != null)
            {
                this.listBoxUnloved.Items.Add(select);
                this.listBoxMain.Items.Remove(select);
            }
            else
            {
                MessageBox.Show("Don\'t select item!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnToDataRigth_Click(object sender, EventArgs e)
        {
            object select = this.listBoxMain.SelectedItem;
            if (select != null)
            {
                this.listBoxMain.Items.Add(select);
                this.listBoxUnloved.Items.Remove(select);
            }
            else
            {
                MessageBox.Show("Don\'t select item!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnToLoved_Click(object sender, EventArgs e)
        {
            object select = this.listBoxMain.SelectedItem;
            if (select != null)
            {
                this.listBoxLoved.Items.Add(select);
                this.listBoxMain.Items.Remove(select);
            }
            else
            {
                MessageBox.Show("Don\'t select item!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnToDataLeft_Click(object sender, EventArgs e)
        {
            object select = this.listBoxLoved.SelectedItem;
            if (select != null)
            {
                this.listBoxMain.Items.Add(select);
                this.listBoxLoved.Items.Remove(select);
            }
            else
            {
                MessageBox.Show("Don\'t select item!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            this.localDBDataSet.Clear();
            this.drinksTableAdapter.Fill(this.localDBDataSet.Drinks);

            DataRowCollection rows = this.localDBDataSet.Drinks.Rows;
            string[] drinks = new string[rows.Count];
            for (int i = 0; i < drinks.Length; i++)
            {
                drinks[i] = rows[i]["name"].ToString();
            }

            this.listBoxMain.Items.Clear();
            this.listBoxLoved.Items.Clear();
            this.listBoxUnloved.Items.Clear();
            this.listBoxMain.Items.AddRange(drinks);
        }
    }
}
