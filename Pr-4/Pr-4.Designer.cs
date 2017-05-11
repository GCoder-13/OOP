namespace Pr_4
{
    partial class FormPr_4
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelFontName = new System.Windows.Forms.Label();
            this.btnEx_2Close = new System.Windows.Forms.Button();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.labelTextSelected = new System.Windows.Forms.Label();
            this.labelTextSize = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.listBoxFonts = new System.Windows.Forms.ListBox();
            this.labelTextFonts = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnRestore);
            this.tabPage1.Controls.Add(this.btnRead);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnInsert);
            this.tabPage1.Controls.Add(this.btnSet);
            this.tabPage1.Controls.Add(this.textBoxInput);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ex.1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(425, 288);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 29);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestore.Location = new System.Drawing.Point(425, 223);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(108, 29);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRead.Location = new System.Drawing.Point(425, 188);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(108, 29);
            this.btnRead.TabIndex = 10;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(425, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(425, 118);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 29);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(425, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 29);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.Location = new System.Drawing.Point(425, 48);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(108, 29);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSet.Location = new System.Drawing.Point(425, 13);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(108, 29);
            this.btnSet.TabIndex = 15;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(55, 13);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(174, 20);
            this.textBoxInput.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "List Box:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "String:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(401, 251);
            this.listBox1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelFontName);
            this.tabPage2.Controls.Add(this.btnEx_2Close);
            this.tabPage2.Controls.Add(this.fontSize);
            this.tabPage2.Controls.Add(this.labelTextSelected);
            this.tabPage2.Controls.Add(this.labelTextSize);
            this.tabPage2.Controls.Add(this.labelFont);
            this.tabPage2.Controls.Add(this.listBoxFonts);
            this.tabPage2.Controls.Add(this.labelTextFonts);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ex.2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelFontName
            // 
            this.labelFontName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFontName.Location = new System.Drawing.Point(344, 113);
            this.labelFontName.Name = "labelFontName";
            this.labelFontName.Size = new System.Drawing.Size(179, 30);
            this.labelFontName.TabIndex = 10;
            this.labelFontName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEx_2Close
            // 
            this.btnEx_2Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEx_2Close.Location = new System.Drawing.Point(424, 283);
            this.btnEx_2Close.Name = "btnEx_2Close";
            this.btnEx_2Close.Size = new System.Drawing.Size(108, 29);
            this.btnEx_2Close.TabIndex = 9;
            this.btnEx_2Close.Text = "Close";
            this.btnEx_2Close.UseVisualStyleBackColor = true;
            this.btnEx_2Close.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(400, 34);
            this.fontSize.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.fontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(70, 22);
            this.fontSize.TabIndex = 5;
            this.fontSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fontSize.ValueChanged += new System.EventHandler(this.fontSize_ValueChanged);
            // 
            // labelTextSelected
            // 
            this.labelTextSelected.AutoSize = true;
            this.labelTextSelected.Location = new System.Drawing.Point(344, 94);
            this.labelTextSelected.Name = "labelTextSelected";
            this.labelTextSelected.Size = new System.Drawing.Size(88, 16);
            this.labelTextSelected.TabIndex = 4;
            this.labelTextSelected.Text = "Selected font:";
            // 
            // labelTextSize
            // 
            this.labelTextSize.AutoSize = true;
            this.labelTextSize.Location = new System.Drawing.Point(344, 36);
            this.labelTextSize.Name = "labelTextSize";
            this.labelTextSize.Size = new System.Drawing.Size(38, 16);
            this.labelTextSize.TabIndex = 3;
            this.labelTextSize.Text = "Size:";
            // 
            // labelFont
            // 
            this.labelFont.Location = new System.Drawing.Point(29, 247);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(275, 65);
            this.labelFont.TabIndex = 2;
            this.labelFont.Text = "A B C – 1 2 3 !";
            this.labelFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxFonts
            // 
            this.listBoxFonts.FormattingEnabled = true;
            this.listBoxFonts.ItemHeight = 16;
            this.listBoxFonts.Location = new System.Drawing.Point(13, 33);
            this.listBoxFonts.Name = "listBoxFonts";
            this.listBoxFonts.Size = new System.Drawing.Size(307, 196);
            this.listBoxFonts.TabIndex = 1;
            this.listBoxFonts.SelectedIndexChanged += new System.EventHandler(this.listBoxFonts_SelectedIndexChanged);
            // 
            // labelTextFonts
            // 
            this.labelTextFonts.AutoSize = true;
            this.labelTextFonts.Location = new System.Drawing.Point(15, 13);
            this.labelTextFonts.Name = "labelTextFonts";
            this.labelTextFonts.Size = new System.Drawing.Size(45, 16);
            this.labelTextFonts.TabIndex = 0;
            this.labelTextFonts.Text = "Fonts:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPr_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 354);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPr_4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pr-4";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelTextFonts;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.ListBox listBoxFonts;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label labelTextSelected;
        private System.Windows.Forms.Label labelTextSize;
        private System.Windows.Forms.Button btnEx_2Close;
        private System.Windows.Forms.Label labelFontName;
    }
}

