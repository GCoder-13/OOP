using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Текстові файли(*.txt)|*.txt|Всі файли(*.*)|*.*";
            saveFileDialog1.Filter = "Текстові файли(*.txt)|*.txt|Всі файли(*.*)|*.*";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string text = this.textBoxInput.Text;
            if (!String.IsNullOrEmpty(text))
            {
                this.listBox1.Items.Add(text);
                this.textBoxInput.Clear();
            }
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
        }

        private string[] ListToStringArr(ListBox listBox)
        {
            string[] list = default(string[]);
            if (listBox.Items.Count != 0)
            {
                list = new string[listBox.Items.Count];
                listBox.Items.CopyTo(list, 0);
            }
            return list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index != -1)
                this.listBox1.Items.RemoveAt(index);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string text = this.textBoxInput.Text;
            int index = this.listBox1.SelectedIndex;

            if (!String.IsNullOrEmpty(text) && index != -1)
            {
                this.listBox1.Items.Insert(index, text);
                this.textBoxInput.Clear();
            }
            else MessageBox.Show("Відсутній текст, або не вибраний елемент", 
                "Помилка!", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Warning);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllLines(filename, ListToStringArr(listBox1));
            MessageBox.Show("Файл збережений");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string[] list = File.ReadAllLines(filename);
            if (this.listBox1.Items.Count != 0)
                this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(list);
            MessageBox.Show("Файл відкритий");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

        }
    }
}
