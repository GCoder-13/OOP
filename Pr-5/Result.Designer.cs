namespace Pr_5
{
    partial class Result
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnozhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.resultToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(354, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlusToolStripMenuItem,
            this.MinusToolStripMenuItem,
            this.MnozhToolStripMenuItem,
            this.DilToolStripMenuItem});
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.resultToolStripMenuItem.Text = "Action";
            // 
            // PlusToolStripMenuItem
            // 
            this.PlusToolStripMenuItem.Name = "PlusToolStripMenuItem";
            this.PlusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PlusToolStripMenuItem.Text = "Додавання";
            this.PlusToolStripMenuItem.Click += new System.EventHandler(this.PlusToolStripMenuItem_Click);
            // 
            // MinusToolStripMenuItem
            // 
            this.MinusToolStripMenuItem.Name = "MinusToolStripMenuItem";
            this.MinusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.MinusToolStripMenuItem.Text = "Віднімання";
            this.MinusToolStripMenuItem.Click += new System.EventHandler(this.MinusToolStripMenuItem_Click);
            // 
            // MnozhToolStripMenuItem
            // 
            this.MnozhToolStripMenuItem.Name = "MnozhToolStripMenuItem";
            this.MnozhToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.MnozhToolStripMenuItem.Text = "Множення";
            this.MnozhToolStripMenuItem.Click += new System.EventHandler(this.MnozhToolStripMenuItem_Click);
            // 
            // DilToolStripMenuItem
            // 
            this.DilToolStripMenuItem.Name = "DilToolStripMenuItem";
            this.DilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DilToolStripMenuItem.Text = "Ділення";
            this.DilToolStripMenuItem.Click += new System.EventHandler(this.DilToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(109, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Результат";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Impact", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(12, 68);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(330, 135);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(113, 210);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 34);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 256);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Activated += new System.EventHandler(this.Result_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Result_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MinusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnozhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DilToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
    }
}