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
    public partial class ListEditor : Form
    {
        private MainForm mainForm;
        public ListEditor(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.labelCount.Text = this.listBoxData.Items.Count.ToString();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            (this.listBoxData.SelectedItem as DataRowView).Row.Delete();
            this.labelCount.Text = this.listBoxData.Items.Count.ToString();
            if (this.listBoxData.Items.Count == 0)
                this.btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.textBoxName.Text))
            {
                DataRow newDrink = this.localDBDataSet.Drinks.NewRow();
                newDrink["name"] = this.textBoxName.Text;
                this.localDBDataSet.Drinks.Rows.Add(newDrink);

                this.labelCount.Text = this.listBoxData.Items.Count.ToString();
                this.btnDelete.Enabled = true;
            }
            this.textBoxName.Clear();
        }

        private void ListEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.drinksTableAdapter.Update(this.localDBDataSet.Drinks);
            this.mainForm.Visible = true;
        }
    }
}
