namespace Lab_6
{
    partial class ListEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.localDBDataSet = new Lab_6.LocalDBDataSet();
            this.drinksTableAdapter = new Lab_6.LocalDBDataSetTableAdapters.DrinksTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelTextCount = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelTextAdd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxData
            // 
            this.listBoxData.DataSource = this.localDBDataSet;
            this.listBoxData.DisplayMember = "Drinks.name";
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(13, 25);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(459, 238);
            this.listBoxData.TabIndex = 0;
            this.listBoxData.ValueMember = "Id";
            // 
            // localDBDataSet
            // 
            this.localDBDataSet.DataSetName = "LocalDBDataSet";
            this.localDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.localDBDataSet.Initialized += new System.EventHandler(this.localDBDataSet_Initialized);
            // 
            // drinksTableAdapter
            // 
            this.drinksTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(343, 278);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(19, 338);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(261, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(343, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelTextCount
            // 
            this.labelTextCount.AutoSize = true;
            this.labelTextCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextCount.Location = new System.Drawing.Point(19, 287);
            this.labelTextCount.Name = "labelTextCount";
            this.labelTextCount.Size = new System.Drawing.Size(97, 16);
            this.labelTextCount.TabIndex = 3;
            this.labelTextCount.Text = "Drinks count:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(115, 287);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(15, 16);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "0";
            // 
            // labelTextAdd
            // 
            this.labelTextAdd.AutoSize = true;
            this.labelTextAdd.Location = new System.Drawing.Point(19, 322);
            this.labelTextAdd.Name = "labelTextAdd";
            this.labelTextAdd.Size = new System.Drawing.Size(78, 13);
            this.labelTextAdd.TabIndex = 5;
            this.labelTextAdd.Text = "Add new drink:";
            // 
            // ListEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 382);
            this.Controls.Add(this.labelTextAdd);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelTextCount);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listBoxData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListEditor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListEditor_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxData;
        private LocalDBDataSet localDBDataSet;
        private LocalDBDataSetTableAdapters.DrinksTableAdapter drinksTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelTextCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelTextAdd;
    }
}