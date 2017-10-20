namespace Lab_6
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.listBoxLoved = new System.Windows.Forms.ListBox();
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.contextMenuDataList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDBDataSet = new Lab_6.LocalDBDataSet();
            this.listBoxUnloved = new System.Windows.Forms.ListBox();
            this.btnToUnloved = new System.Windows.Forms.Button();
            this.btnToDataRigth = new System.Windows.Forms.Button();
            this.btnToLoved = new System.Windows.Forms.Button();
            this.btnToDataLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drinksTableAdapter = new Lab_6.LocalDBDataSetTableAdapters.DrinksTableAdapter();
            this.contextMenuDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxLoved
            // 
            this.listBoxLoved.FormattingEnabled = true;
            this.listBoxLoved.Location = new System.Drawing.Point(12, 44);
            this.listBoxLoved.Name = "listBoxLoved";
            this.listBoxLoved.Size = new System.Drawing.Size(150, 277);
            this.listBoxLoved.TabIndex = 0;
            // 
            // listBoxMain
            // 
            this.listBoxMain.ContextMenuStrip = this.contextMenuDataList;
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.Location = new System.Drawing.Point(217, 44);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(150, 277);
            this.listBoxMain.TabIndex = 0;
            // 
            // contextMenuDataList
            // 
            this.contextMenuDataList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listEditorToolStripMenuItem});
            this.contextMenuDataList.Name = "contextMenuStrip1";
            this.contextMenuDataList.ShowImageMargin = false;
            this.contextMenuDataList.Size = new System.Drawing.Size(102, 26);
            // 
            // listEditorToolStripMenuItem
            // 
            this.listEditorToolStripMenuItem.Name = "listEditorToolStripMenuItem";
            this.listEditorToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.listEditorToolStripMenuItem.Text = "List editor";
            this.listEditorToolStripMenuItem.Click += new System.EventHandler(this.listEditorToolStripMenuItem_Click);
            // 
            // localDBDataSet
            // 
            this.localDBDataSet.DataSetName = "LocalDBDataSet";
            this.localDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.localDBDataSet.Initialized += new System.EventHandler(this.localDBDataSet_Initialized);
            // 
            // listBoxUnloved
            // 
            this.listBoxUnloved.FormattingEnabled = true;
            this.listBoxUnloved.Location = new System.Drawing.Point(422, 44);
            this.listBoxUnloved.Name = "listBoxUnloved";
            this.listBoxUnloved.Size = new System.Drawing.Size(150, 277);
            this.listBoxUnloved.TabIndex = 0;
            // 
            // btnToUnloved
            // 
            this.btnToUnloved.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToUnloved.Location = new System.Drawing.Point(378, 143);
            this.btnToUnloved.Name = "btnToUnloved";
            this.btnToUnloved.Size = new System.Drawing.Size(35, 35);
            this.btnToUnloved.TabIndex = 1;
            this.btnToUnloved.Text = ">";
            this.btnToUnloved.UseVisualStyleBackColor = true;
            this.btnToUnloved.Click += new System.EventHandler(this.btnToUnloved_Click);
            // 
            // btnToDataRigth
            // 
            this.btnToDataRigth.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToDataRigth.Location = new System.Drawing.Point(378, 184);
            this.btnToDataRigth.Name = "btnToDataRigth";
            this.btnToDataRigth.Size = new System.Drawing.Size(35, 35);
            this.btnToDataRigth.TabIndex = 1;
            this.btnToDataRigth.Text = "<";
            this.btnToDataRigth.UseVisualStyleBackColor = true;
            this.btnToDataRigth.Click += new System.EventHandler(this.btnToDataRigth_Click);
            // 
            // btnToLoved
            // 
            this.btnToLoved.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToLoved.Location = new System.Drawing.Point(172, 143);
            this.btnToLoved.Name = "btnToLoved";
            this.btnToLoved.Size = new System.Drawing.Size(35, 35);
            this.btnToLoved.TabIndex = 1;
            this.btnToLoved.Text = "<";
            this.btnToLoved.UseVisualStyleBackColor = true;
            this.btnToLoved.Click += new System.EventHandler(this.btnToLoved_Click);
            // 
            // btnToDataLeft
            // 
            this.btnToDataLeft.Font = new System.Drawing.Font("Imprint MT Shadow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToDataLeft.Location = new System.Drawing.Point(172, 184);
            this.btnToDataLeft.Name = "btnToDataLeft";
            this.btnToDataLeft.Size = new System.Drawing.Size(35, 35);
            this.btnToDataLeft.TabIndex = 1;
            this.btnToDataLeft.Text = ">";
            this.btnToDataLeft.UseVisualStyleBackColor = true;
            this.btnToDataLeft.Click += new System.EventHandler(this.btnToDataLeft_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loved";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(419, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unloved";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinksTableAdapter
            // 
            this.drinksTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToDataLeft);
            this.Controls.Add(this.btnToLoved);
            this.Controls.Add(this.btnToDataRigth);
            this.Controls.Add(this.btnToUnloved);
            this.Controls.Add(this.listBoxUnloved);
            this.Controls.Add(this.listBoxMain);
            this.Controls.Add(this.listBoxLoved);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab-6";
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.contextMenuDataList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.localDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLoved;
        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.ListBox listBoxUnloved;
        private System.Windows.Forms.Button btnToUnloved;
        private System.Windows.Forms.Button btnToDataRigth;
        private System.Windows.Forms.Button btnToLoved;
        private System.Windows.Forms.Button btnToDataLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuDataList;
        private System.Windows.Forms.ToolStripMenuItem listEditorToolStripMenuItem;
        private LocalDBDataSet localDBDataSet;
        private LocalDBDataSetTableAdapters.DrinksTableAdapter drinksTableAdapter;
    }
}

