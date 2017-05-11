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
    public partial class FormPr_4 : Form
    {
        public event EventHandler<Actions> SwRestore;
        Stack<Restore> history = new Stack<Restore>();

        public FormPr_4()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Текстові файли(*.txt)|*.txt|Всі файли(*.*)|*.*";
            saveFileDialog1.Filter = "Текстові файли(*.txt)|*.txt|Всі файли(*.*)|*.*";
            new Restore(ref listBox1);

            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (FontFamily font in fonts.Families)
            {
                this.listBoxFonts.Items.Add(font.Name);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string text = this.textBoxInput.Text;
            if (String.IsNullOrEmpty(text))
                return;

            SwRestore = Form1_SwRestore;
            if (SwRestore != null)
                SwRestore(this.listBox1.Items.Count, Actions.Set);

            this.listBox1.Items.Add(text);
            this.textBoxInput.Clear();
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            SwRestore = Form1_SwRestore;
            if (SwRestore != null)
                SwRestore(this, Actions.Clear);

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
            if (index == -1)
            {
                MessageBox.Show("Елемент для видалення не виброний",
                "Помилка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            SwRestore = Form1_SwRestore;
            if (SwRestore != null)
                SwRestore(index, Actions.Delete);
            this.listBox1.Items.RemoveAt(index);
            this.listBox1.ClearSelected();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string text = this.textBoxInput.Text;
            int index = this.listBox1.SelectedIndex;

            if (String.IsNullOrEmpty(text) && index != -1)
            {
                MessageBox.Show("Відсутній текст, або не вибраний елемент",
                "Помилка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            SwRestore = Form1_SwRestore;
            if (SwRestore != null)
                SwRestore(index, Actions.Insert);

            this.listBox1.Items.Insert(index, text);
            this.textBoxInput.Clear();
            this.listBox1.ClearSelected();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;

            SwRestore = Form1_SwRestore;
            if (SwRestore != null)
                SwRestore(filename, Actions.Save);

            File.WriteAllLines(filename, ListToStringArr(listBox1));
            MessageBox.Show("Файл збережений");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            SwRestore = Form1_SwRestore;
            if (SwRestore != null)
                SwRestore(ListToStringArr(this.listBox1), Actions.Read);

            string filename = openFileDialog1.FileName;
            string[] list = File.ReadAllLines(filename);
            if (this.listBox1.Items.Count != 0)
                this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(list);
            MessageBox.Show("Файл відкритий");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            history.Pop().StartRestore();
            if (history.Count == 0)
                btnRestore.Enabled = false;
        }

        private void Form1_SwRestore(object sender, Actions e)
        {
            Restore restore = null;
            switch (e)
            {
                case Actions.Set:
                    restore = new Restore(e, sender);
                    break;
                case Actions.Delete:
                    restore = new Restore(e, sender, this.listBox1.Items[(int)sender]);
                    break;
                case Actions.Clear:
                    restore = new Restore(e, ListToStringArr(this.listBox1));
                    break;
                case Actions.Insert:
                    restore = new Restore(e, sender);
                    break;
                case Actions.Read:
                    restore = new Restore(e, sender);
                    break;
                case Actions.Save:
                    string file = sender as string;
                    if (!File.Exists(file))
                    {
                        restore = new Restore(e, file);
                        break;
                    }
                    
                    string[] list = File.ReadAllLines(file);
                    restore = new Restore(e, file, list);
                    break;
            }
            history.Push(restore);
            btnRestore.Enabled = true;
            return;
        }

        private void listBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ListBox).SelectedIndex;
            float size = (float)this.fontSize.Value;
            this.labelFontName.Text = (sender as ListBox).Items[index].ToString();
            try
            {
                this.labelFont.Font = new Font((sender as ListBox).Items[index].ToString(), size);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void fontSize_ValueChanged(object sender, EventArgs e)
        {
            float size = (float)(sender as NumericUpDown).Value;
            string name = this.labelFontName.Text;
            if (!String.IsNullOrEmpty(name))
                this.labelFont.Font = new Font(name, size);
        }
    }

    public enum Actions
    {
        Set,
        Insert,
        Delete,
        Clear,
        Save,
        Read
    }

    public class Restore
    {
        public static ListBox list { get; private set; }
        public Actions action { get; private set; }
        public object obj1 { get; private set; }
        public object obj2 { get; private set; }

        public Restore(ref ListBox listBox)
        {
            list = listBox;
        }

        public Restore(Actions action, object obj)
        {
            this.action = action;
            this.obj1 = obj;
        }

        public Restore(Actions action, object obj1, object obj2)
        {
            this.action = action;
            this.obj1 = obj1;
            this.obj2 = obj2;
        }

        public void StartRestore()
        {
            switch (action)
            {
                case Actions.Set:
                    list.Items.RemoveAt((int)obj1);
                    break;
                case Actions.Delete:
                    list.Items.Insert((int)obj1, obj2);
                    break;
                case Actions.Clear:
                    list.Items.AddRange(obj1 as string[]);
                    break;
                case Actions.Insert:
                    list.Items.RemoveAt((int)obj1);
                    break;
                case Actions.Read:
                    list.Items.Clear();
                    MessageBox.Show("Файл закритий");
                    list.Items.AddRange((string[])obj1);
                    break;
                case Actions.Save:
                    if (obj2 == null)
                    {
                        File.Delete(obj1 as string);
                        MessageBox.Show("Файл видалено");
                    }
                    else
                    {
                        File.WriteAllLines(obj1 as string, (string[])obj2);
                        MessageBox.Show("Файл відновлено");
                    }
                    break;
                default: break;
            }
        }
    }
}
