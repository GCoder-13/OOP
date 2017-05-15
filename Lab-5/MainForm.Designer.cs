namespace Lab_5
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEx_1 = new System.Windows.Forms.Button();
            this.btnEx_2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnEx_1
            // 
            this.btnEx_1.Location = new System.Drawing.Point(55, 77);
            this.btnEx_1.Name = "btnEx_1";
            this.btnEx_1.Size = new System.Drawing.Size(169, 45);
            this.btnEx_1.TabIndex = 1;
            this.btnEx_1.Text = "Ex-1";
            this.btnEx_1.UseVisualStyleBackColor = true;
            this.btnEx_1.Click += new System.EventHandler(this.btnEx_1_Click);
            // 
            // btnEx_2
            // 
            this.btnEx_2.Location = new System.Drawing.Point(55, 141);
            this.btnEx_2.Name = "btnEx_2";
            this.btnEx_2.Size = new System.Drawing.Size(169, 45);
            this.btnEx_2.TabIndex = 2;
            this.btnEx_2.Text = "Ex2";
            this.btnEx_2.UseVisualStyleBackColor = true;
            this.btnEx_2.Click += new System.EventHandler(this.btnEx_2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(55, 205);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(169, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEx_2);
            this.Controls.Add(this.btnEx_1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEx_1;
        private System.Windows.Forms.Button btnEx_2;
        private System.Windows.Forms.Button btnClose;
    }
}