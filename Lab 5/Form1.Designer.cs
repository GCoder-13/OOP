namespace Lab_5
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ShiftLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.CharLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCloseEx2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.InsLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ScrollLockLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NumLockLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CapsLockLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCloseEx3 = new System.Windows.Forms.Button();
            this.btnSumEx3 = new System.Windows.Forms.Button();
            this.labelSumEx3 = new System.Windows.Forms.Label();
            this.labelResEx3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxValue2 = new System.Windows.Forms.TextBox();
            this.textBoxValue1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 375);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.BtnClose);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ShiftLabel);
            this.tabPage1.Controls.Add(this.ValueLabel);
            this.tabPage1.Controls.Add(this.CharLabel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ex.1";
            // 
            // BtnClose
            // 
            this.BtnClose.CausesValidation = false;
            this.BtnClose.Location = new System.Drawing.Point(396, 251);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(301, 77);
            this.BtnClose.TabIndex = 15;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.Close);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(371, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(342, 201);
            this.label7.TabIndex = 14;
            this.label7.Text = "Press any key and hold down SHIFT, ALT and CTRL keys to see their ASCII and virtu" +
    "al key values";
            // 
            // ShiftLabel
            // 
            this.ShiftLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ShiftLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShiftLabel.Location = new System.Drawing.Point(167, 252);
            this.ShiftLabel.Name = "ShiftLabel";
            this.ShiftLabel.Size = new System.Drawing.Size(180, 87);
            this.ShiftLabel.TabIndex = 13;
            this.ShiftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValueLabel
            // 
            this.ValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ValueLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueLabel.Location = new System.Drawing.Point(167, 126);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(180, 87);
            this.ValueLabel.TabIndex = 12;
            this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharLabel
            // 
            this.CharLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CharLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharLabel.Location = new System.Drawing.Point(167, 9);
            this.CharLabel.Name = "CharLabel";
            this.CharLabel.Size = new System.Drawing.Size(180, 87);
            this.CharLabel.TabIndex = 11;
            this.CharLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(24, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 87);
            this.label3.TabIndex = 10;
            this.label3.Text = "Key down shift";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(24, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 87);
            this.label2.TabIndex = 9;
            this.label2.Text = "Key down value";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 87);
            this.label1.TabIndex = 8;
            this.label1.Text = "Keypress character";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btnCloseEx2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ex.2";
            // 
            // btnCloseEx2
            // 
            this.btnCloseEx2.Location = new System.Drawing.Point(500, 74);
            this.btnCloseEx2.Name = "btnCloseEx2";
            this.btnCloseEx2.Size = new System.Drawing.Size(161, 63);
            this.btnCloseEx2.TabIndex = 2;
            this.btnCloseEx2.TabStop = false;
            this.btnCloseEx2.Text = "Close";
            this.btnCloseEx2.UseVisualStyleBackColor = true;
            this.btnCloseEx2.Click += new System.EventHandler(this.Close);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(38, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 90);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.InsLabel);
            this.panel5.Location = new System.Drawing.Point(473, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(138, 54);
            this.panel5.TabIndex = 1;
            // 
            // InsLabel
            // 
            this.InsLabel.AutoSize = true;
            this.InsLabel.Enabled = false;
            this.InsLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsLabel.Location = new System.Drawing.Point(31, 14);
            this.InsLabel.Name = "InsLabel";
            this.InsLabel.Size = new System.Drawing.Size(76, 23);
            this.InsLabel.TabIndex = 2;
            this.InsLabel.Text = "Insert";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.ScrollLockLabel);
            this.panel4.Location = new System.Drawing.Point(329, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 54);
            this.panel4.TabIndex = 1;
            // 
            // ScrollLockLabel
            // 
            this.ScrollLockLabel.AutoSize = true;
            this.ScrollLockLabel.Enabled = false;
            this.ScrollLockLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScrollLockLabel.Location = new System.Drawing.Point(7, 14);
            this.ScrollLockLabel.Name = "ScrollLockLabel";
            this.ScrollLockLabel.Size = new System.Drawing.Size(120, 23);
            this.ScrollLockLabel.TabIndex = 1;
            this.ScrollLockLabel.Text = "ScrollLock";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.NumLockLabel);
            this.panel3.Location = new System.Drawing.Point(185, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 54);
            this.panel3.TabIndex = 1;
            // 
            // NumLockLabel
            // 
            this.NumLockLabel.AutoSize = true;
            this.NumLockLabel.Enabled = false;
            this.NumLockLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumLockLabel.Location = new System.Drawing.Point(14, 14);
            this.NumLockLabel.Name = "NumLockLabel";
            this.NumLockLabel.Size = new System.Drawing.Size(109, 23);
            this.NumLockLabel.TabIndex = 0;
            this.NumLockLabel.Text = "NumLock";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.CapsLockLabel);
            this.panel2.Location = new System.Drawing.Point(41, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 54);
            this.panel2.TabIndex = 0;
            // 
            // CapsLockLabel
            // 
            this.CapsLockLabel.AutoSize = true;
            this.CapsLockLabel.Enabled = false;
            this.CapsLockLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CapsLockLabel.Location = new System.Drawing.Point(12, 14);
            this.CapsLockLabel.Name = "CapsLockLabel";
            this.CapsLockLabel.Size = new System.Drawing.Size(110, 23);
            this.CapsLockLabel.TabIndex = 0;
            this.CapsLockLabel.Text = "CapsLock";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(53, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 153);
            this.label4.TabIndex = 0;
            this.label4.Text = "Press the CapsLock, NumLock, ScrollLock and Ins keys";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.btnCloseEx3);
            this.tabPage3.Controls.Add(this.btnSumEx3);
            this.tabPage3.Controls.Add(this.labelSumEx3);
            this.tabPage3.Controls.Add(this.labelResEx3);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.textBoxValue2);
            this.tabPage3.Controls.Add(this.textBoxValue1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(736, 349);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ex.3";
            // 
            // btnCloseEx3
            // 
            this.btnCloseEx3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseEx3.Location = new System.Drawing.Point(421, 250);
            this.btnCloseEx3.Name = "btnCloseEx3";
            this.btnCloseEx3.Size = new System.Drawing.Size(139, 38);
            this.btnCloseEx3.TabIndex = 7;
            this.btnCloseEx3.TabStop = false;
            this.btnCloseEx3.Text = "Close";
            this.btnCloseEx3.UseVisualStyleBackColor = true;
            this.btnCloseEx3.Click += new System.EventHandler(this.Close);
            // 
            // btnSumEx3
            // 
            this.btnSumEx3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSumEx3.Location = new System.Drawing.Point(122, 250);
            this.btnSumEx3.Name = "btnSumEx3";
            this.btnSumEx3.Size = new System.Drawing.Size(139, 38);
            this.btnSumEx3.TabIndex = 6;
            this.btnSumEx3.Text = "Sum";
            this.btnSumEx3.UseVisualStyleBackColor = true;
            this.btnSumEx3.Click += new System.EventHandler(this.btnSumEx3_Click);
            // 
            // labelSumEx3
            // 
            this.labelSumEx3.AutoSize = true;
            this.labelSumEx3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumEx3.Location = new System.Drawing.Point(206, 162);
            this.labelSumEx3.Name = "labelSumEx3";
            this.labelSumEx3.Size = new System.Drawing.Size(58, 23);
            this.labelSumEx3.TabIndex = 5;
            this.labelSumEx3.Text = "Sum";
            // 
            // labelResEx3
            // 
            this.labelResEx3.BackColor = System.Drawing.Color.White;
            this.labelResEx3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResEx3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResEx3.Location = new System.Drawing.Point(289, 148);
            this.labelResEx3.Name = "labelResEx3";
            this.labelResEx3.Size = new System.Drawing.Size(226, 50);
            this.labelResEx3.TabIndex = 4;
            this.labelResEx3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(415, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Value 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Value 1";
            // 
            // textBoxValue2
            // 
            this.textBoxValue2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxValue2.Location = new System.Drawing.Point(519, 65);
            this.textBoxValue2.Name = "textBoxValue2";
            this.textBoxValue2.Size = new System.Drawing.Size(165, 31);
            this.textBoxValue2.TabIndex = 1;
            this.textBoxValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxValue2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // textBoxValue1
            // 
            this.textBoxValue1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxValue1.Location = new System.Drawing.Point(148, 64);
            this.textBoxValue1.Name = "textBoxValue1";
            this.textBoxValue1.Size = new System.Drawing.Size(165, 31);
            this.textBoxValue1.TabIndex = 0;
            this.textBoxValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxValue1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 375);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 5";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DownKey);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressKey);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UpKey);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ShiftLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label CharLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCloseEx2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CapsLockLabel;
        private System.Windows.Forms.Label ScrollLockLabel;
        private System.Windows.Forms.Label NumLockLabel;
        private System.Windows.Forms.Label InsLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCloseEx3;
        private System.Windows.Forms.Button btnSumEx3;
        private System.Windows.Forms.Label labelSumEx3;
        private System.Windows.Forms.Label labelResEx3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxValue2;
        private System.Windows.Forms.TextBox textBoxValue1;
    }
}

