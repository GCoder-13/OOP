namespace Lab_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureEx1 = new System.Windows.Forms.PictureBox();
            this.btnHomePhoto = new System.Windows.Forms.Button();
            this.btnArtPhoto = new System.Windows.Forms.Button();
            this.btnPortretPhoto = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbBorn = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbForm = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureEx2 = new System.Windows.Forms.PictureBox();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            this.btnEditPhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelNamePhoto = new System.Windows.Forms.Label();
            this.pictureEx3 = new System.Windows.Forms.PictureBox();
            this.btnTakePhotoEx3 = new System.Windows.Forms.Button();
            this.btnPortretPhotoEx3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEx1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEx2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEx3)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(468, 394);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureEx1);
            this.tabPage1.Controls.Add(this.btnHomePhoto);
            this.tabPage1.Controls.Add(this.btnArtPhoto);
            this.tabPage1.Controls.Add(this.btnPortretPhoto);
            this.tabPage1.Controls.Add(this.lbAddress);
            this.tabPage1.Controls.Add(this.lbBorn);
            this.tabPage1.Controls.Add(this.lbName);
            this.tabPage1.Controls.Add(this.lbForm);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(460, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ex. 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureEx1
            // 
            this.pictureEx1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureEx1.Location = new System.Drawing.Point(251, 196);
            this.pictureEx1.Name = "pictureEx1";
            this.pictureEx1.Size = new System.Drawing.Size(165, 140);
            this.pictureEx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEx1.TabIndex = 15;
            this.pictureEx1.TabStop = false;
            // 
            // btnHomePhoto
            // 
            this.btnHomePhoto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePhoto.Location = new System.Drawing.Point(47, 306);
            this.btnHomePhoto.Name = "btnHomePhoto";
            this.btnHomePhoto.Size = new System.Drawing.Size(178, 33);
            this.btnHomePhoto.TabIndex = 14;
            this.btnHomePhoto.Text = "Фотографія будинку";
            this.btnHomePhoto.UseVisualStyleBackColor = true;
            this.btnHomePhoto.Click += new System.EventHandler(this.btnHomePhoto_Click);
            // 
            // btnArtPhoto
            // 
            this.btnArtPhoto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtPhoto.Location = new System.Drawing.Point(47, 251);
            this.btnArtPhoto.Name = "btnArtPhoto";
            this.btnArtPhoto.Size = new System.Drawing.Size(178, 33);
            this.btnArtPhoto.TabIndex = 13;
            this.btnArtPhoto.Text = "Художня фотографія";
            this.btnArtPhoto.UseVisualStyleBackColor = true;
            this.btnArtPhoto.Click += new System.EventHandler(this.btnArtPhoto_Click);
            // 
            // btnPortretPhoto
            // 
            this.btnPortretPhoto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortretPhoto.Location = new System.Drawing.Point(47, 196);
            this.btnPortretPhoto.Name = "btnPortretPhoto";
            this.btnPortretPhoto.Size = new System.Drawing.Size(178, 33);
            this.btnPortretPhoto.TabIndex = 12;
            this.btnPortretPhoto.Text = "Портретна фотографія";
            this.btnPortretPhoto.UseVisualStyleBackColor = true;
            this.btnPortretPhoto.Click += new System.EventHandler(this.btnPortretPhoto_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddress.ForeColor = System.Drawing.Color.Black;
            this.lbAddress.Location = new System.Drawing.Point(26, 146);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(409, 21);
            this.lbAddress.TabIndex = 11;
            this.lbAddress.Text = "Адреса: м.Коростень, вул. Маяковського 2, кв. 14";
            // 
            // lbBorn
            // 
            this.lbBorn.AutoSize = true;
            this.lbBorn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBorn.ForeColor = System.Drawing.Color.Black;
            this.lbBorn.Location = new System.Drawing.Point(26, 106);
            this.lbBorn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBorn.Name = "lbBorn";
            this.lbBorn.Size = new System.Drawing.Size(260, 21);
            this.lbBorn.TabIndex = 10;
            this.lbBorn.Text = "Дата народження: 13.12.1998 р.";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(26, 67);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(286, 21);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Хомутовський Андрій, група П-31";
            // 
            // lbForm
            // 
            this.lbForm.AutoSize = true;
            this.lbForm.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbForm.ForeColor = System.Drawing.Color.Purple;
            this.lbForm.Location = new System.Drawing.Point(148, 21);
            this.lbForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbForm.Name = "lbForm";
            this.lbForm.Size = new System.Drawing.Size(164, 24);
            this.lbForm.TabIndex = 8;
            this.lbForm.Text = "Анкета студента";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureEx2);
            this.tabPage2.Controls.Add(this.btnTakePhoto);
            this.tabPage2.Controls.Add(this.btnEditPhoto);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(460, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ex. 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureEx2
            // 
            this.pictureEx2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureEx2.Location = new System.Drawing.Point(251, 196);
            this.pictureEx2.Name = "pictureEx2";
            this.pictureEx2.Size = new System.Drawing.Size(165, 140);
            this.pictureEx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEx2.TabIndex = 23;
            this.pictureEx2.TabStop = false;
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePhoto.Location = new System.Drawing.Point(47, 251);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(178, 33);
            this.btnTakePhoto.TabIndex = 21;
            this.btnTakePhoto.Text = "Забрати фотографію";
            this.btnTakePhoto.UseVisualStyleBackColor = true;
            this.btnTakePhoto.Click += new System.EventHandler(this.btnTakePhoto_Click);
            // 
            // btnEditPhoto
            // 
            this.btnEditPhoto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPhoto.Location = new System.Drawing.Point(47, 196);
            this.btnEditPhoto.Name = "btnEditPhoto";
            this.btnEditPhoto.Size = new System.Drawing.Size(178, 33);
            this.btnEditPhoto.TabIndex = 20;
            this.btnEditPhoto.Text = "Змінити фотографію";
            this.btnEditPhoto.UseVisualStyleBackColor = true;
            this.btnEditPhoto.Click += new System.EventHandler(this.btnEditPhoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Адреса: м.Коростень, вул. Маяковського 2, кв. 14";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Дата народження: 13.12.1998 р.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Хомутовський Андрій, група П-31";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(148, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Анкета студента";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelNamePhoto);
            this.tabPage3.Controls.Add(this.pictureEx3);
            this.tabPage3.Controls.Add(this.btnTakePhotoEx3);
            this.tabPage3.Controls.Add(this.btnPortretPhotoEx3);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(460, 360);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ex. 3-4";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelNamePhoto
            // 
            this.labelNamePhoto.AutoSize = true;
            this.labelNamePhoto.Location = new System.Drawing.Point(43, 317);
            this.labelNamePhoto.Name = "labelNamePhoto";
            this.labelNamePhoto.Size = new System.Drawing.Size(0, 21);
            this.labelNamePhoto.TabIndex = 31;
            // 
            // pictureEx3
            // 
            this.pictureEx3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureEx3.Location = new System.Drawing.Point(251, 198);
            this.pictureEx3.Name = "pictureEx3";
            this.pictureEx3.Size = new System.Drawing.Size(165, 140);
            this.pictureEx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEx3.TabIndex = 30;
            this.pictureEx3.TabStop = false;
            // 
            // btnTakePhotoEx3
            // 
            this.btnTakePhotoEx3.Enabled = false;
            this.btnTakePhotoEx3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePhotoEx3.Location = new System.Drawing.Point(47, 253);
            this.btnTakePhotoEx3.Name = "btnTakePhotoEx3";
            this.btnTakePhotoEx3.Size = new System.Drawing.Size(178, 33);
            this.btnTakePhotoEx3.TabIndex = 29;
            this.btnTakePhotoEx3.Text = "Забрати фотографію";
            this.btnTakePhotoEx3.UseVisualStyleBackColor = true;
            this.btnTakePhotoEx3.Click += new System.EventHandler(this.btnTakePhotoEx3_Click);
            // 
            // btnPortretPhotoEx3
            // 
            this.btnPortretPhotoEx3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortretPhotoEx3.Location = new System.Drawing.Point(47, 198);
            this.btnPortretPhotoEx3.Name = "btnPortretPhotoEx3";
            this.btnPortretPhotoEx3.Size = new System.Drawing.Size(178, 33);
            this.btnPortretPhotoEx3.TabIndex = 28;
            this.btnPortretPhotoEx3.Text = "Портретна фотографія";
            this.btnPortretPhotoEx3.UseVisualStyleBackColor = true;
            this.btnPortretPhotoEx3.Click += new System.EventHandler(this.btnPortretPhotoEx3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(409, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Адреса: м.Коростень, вул. Маяковського 2, кв. 14";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Дата народження: 13.12.1998 р.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(26, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Хомутовський Андрій, група П-31";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(148, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Анкета студента";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(468, 394);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEx1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEx2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEx3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureEx1;
        private System.Windows.Forms.Button btnHomePhoto;
        private System.Windows.Forms.Button btnArtPhoto;
        private System.Windows.Forms.Button btnPortretPhoto;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbBorn;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbForm;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureEx2;
        private System.Windows.Forms.Button btnTakePhoto;
        private System.Windows.Forms.Button btnEditPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureEx3;
        private System.Windows.Forms.Button btnTakePhotoEx3;
        private System.Windows.Forms.Button btnPortretPhotoEx3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelNamePhoto;
    }
}

