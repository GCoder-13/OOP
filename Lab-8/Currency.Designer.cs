namespace Lab_8
{
    partial class Currency
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
            this.radioBuy = new System.Windows.Forms.RadioButton();
            this.radioSell = new System.Windows.Forms.RadioButton();
            this.labelArrow = new System.Windows.Forms.Label();
            this.textBoxCursUSD = new System.Windows.Forms.TextBox();
            this.textBoxCursGRN = new System.Windows.Forms.TextBox();
            this.textBoxUSD = new System.Windows.Forms.TextBox();
            this.textBoxGRN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioBuy
            // 
            this.radioBuy.AutoSize = true;
            this.radioBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBuy.Location = new System.Drawing.Point(55, 28);
            this.radioBuy.Name = "radioBuy";
            this.radioBuy.Size = new System.Drawing.Size(76, 20);
            this.radioBuy.TabIndex = 0;
            this.radioBuy.Text = "Купівля";
            this.radioBuy.UseVisualStyleBackColor = true;
            this.radioBuy.CheckedChanged += new System.EventHandler(this.radioBuy_CheckedChanged);
            // 
            // radioSell
            // 
            this.radioSell.AutoSize = true;
            this.radioSell.Checked = true;
            this.radioSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioSell.Location = new System.Drawing.Point(276, 28);
            this.radioSell.Name = "radioSell";
            this.radioSell.Size = new System.Drawing.Size(77, 20);
            this.radioSell.TabIndex = 0;
            this.radioSell.TabStop = true;
            this.radioSell.Text = "Продаж";
            this.radioSell.UseVisualStyleBackColor = true;
            this.radioSell.CheckedChanged += new System.EventHandler(this.radioSell_CheckedChanged);
            // 
            // labelArrow
            // 
            this.labelArrow.AutoSize = true;
            this.labelArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelArrow.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArrow.Location = new System.Drawing.Point(178, 25);
            this.labelArrow.Name = "labelArrow";
            this.labelArrow.Size = new System.Drawing.Size(35, 23);
            this.labelArrow.TabIndex = 1;
            this.labelArrow.Text = "->";
            this.labelArrow.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCursUSD
            // 
            this.textBoxCursUSD.Enabled = false;
            this.textBoxCursUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCursUSD.Location = new System.Drawing.Point(31, 91);
            this.textBoxCursUSD.Name = "textBoxCursUSD";
            this.textBoxCursUSD.Size = new System.Drawing.Size(136, 22);
            this.textBoxCursUSD.TabIndex = 2;
            this.textBoxCursUSD.Text = "0";
            this.textBoxCursUSD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // textBoxCursGRN
            // 
            this.textBoxCursGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCursGRN.Location = new System.Drawing.Point(230, 91);
            this.textBoxCursGRN.Name = "textBoxCursGRN";
            this.textBoxCursGRN.Size = new System.Drawing.Size(137, 22);
            this.textBoxCursGRN.TabIndex = 2;
            this.textBoxCursGRN.Text = "0";
            this.textBoxCursGRN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // textBoxUSD
            // 
            this.textBoxUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUSD.Location = new System.Drawing.Point(31, 144);
            this.textBoxUSD.Name = "textBoxUSD";
            this.textBoxUSD.Size = new System.Drawing.Size(136, 22);
            this.textBoxUSD.TabIndex = 2;
            this.textBoxUSD.Text = "0";
            this.textBoxUSD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // textBoxGRN
            // 
            this.textBoxGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGRN.Location = new System.Drawing.Point(230, 144);
            this.textBoxGRN.Name = "textBoxGRN";
            this.textBoxGRN.ReadOnly = true;
            this.textBoxGRN.Size = new System.Drawing.Size(137, 22);
            this.textBoxGRN.TabIndex = 2;
            this.textBoxGRN.Text = "0";
            this.textBoxGRN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(31, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Обчислити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(150, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "Очислити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(269, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Кінець";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ГРН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Курс";
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxGRN);
            this.Controls.Add(this.textBoxUSD);
            this.Controls.Add(this.textBoxCursGRN);
            this.Controls.Add(this.textBoxCursUSD);
            this.Controls.Add(this.labelArrow);
            this.Controls.Add(this.radioSell);
            this.Controls.Add(this.radioBuy);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Currency";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Currency_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBuy;
        private System.Windows.Forms.RadioButton radioSell;
        private System.Windows.Forms.Label labelArrow;
        private System.Windows.Forms.TextBox textBoxCursUSD;
        private System.Windows.Forms.TextBox textBoxCursGRN;
        private System.Windows.Forms.TextBox textBoxUSD;
        private System.Windows.Forms.TextBox textBoxGRN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}