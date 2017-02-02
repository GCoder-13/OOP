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
            this.lbForm = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbBorn = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.btnPortretPhoto = new System.Windows.Forms.Button();
            this.btnArtPhoto = new System.Windows.Forms.Button();
            this.btnHomePhoto = new System.Windows.Forms.Button();
            this.picturePortretPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePortretPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbForm
            // 
            this.lbForm.AutoSize = true;
            this.lbForm.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbForm.ForeColor = System.Drawing.Color.Purple;
            this.lbForm.Location = new System.Drawing.Point(133, 9);
            this.lbForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbForm.Name = "lbForm";
            this.lbForm.Size = new System.Drawing.Size(164, 24);
            this.lbForm.TabIndex = 0;
            this.lbForm.Text = "Анкета студента";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(11, 55);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(286, 21);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Хомутовський Андрій, група П-31";
            // 
            // lbBorn
            // 
            this.lbBorn.AutoSize = true;
            this.lbBorn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBorn.ForeColor = System.Drawing.Color.Black;
            this.lbBorn.Location = new System.Drawing.Point(11, 94);
            this.lbBorn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBorn.Name = "lbBorn";
            this.lbBorn.Size = new System.Drawing.Size(260, 21);
            this.lbBorn.TabIndex = 2;
            this.lbBorn.Text = "Дата народження: 13.12.1998 р.";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddress.ForeColor = System.Drawing.Color.Black;
            this.lbAddress.Location = new System.Drawing.Point(11, 134);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(409, 21);
            this.lbAddress.TabIndex = 3;
            this.lbAddress.Text = "Адреса: м.Коростень, вул. Маяковського 2, кв. 14";
            // 
            // btnPortretPhoto
            // 
            this.btnPortretPhoto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortretPhoto.Location = new System.Drawing.Point(32, 184);
            this.btnPortretPhoto.Name = "btnPortretPhoto";
            this.btnPortretPhoto.Size = new System.Drawing.Size(178, 33);
            this.btnPortretPhoto.TabIndex = 4;
            this.btnPortretPhoto.Text = "Портретна фотографія";
            this.btnPortretPhoto.UseVisualStyleBackColor = true;
            this.btnPortretPhoto.Click += new System.EventHandler(this.btnPortretPhoto_Click);
            // 
            // btnArtPhoto
            // 
            this.btnArtPhoto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtPhoto.Location = new System.Drawing.Point(32, 239);
            this.btnArtPhoto.Name = "btnArtPhoto";
            this.btnArtPhoto.Size = new System.Drawing.Size(178, 33);
            this.btnArtPhoto.TabIndex = 5;
            this.btnArtPhoto.Text = "Художня фотографія";
            this.btnArtPhoto.UseVisualStyleBackColor = true;
            this.btnArtPhoto.Click += new System.EventHandler(this.btnArtPhoto_Click);
            // 
            // btnHomePhoto
            // 
            this.btnHomePhoto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePhoto.Location = new System.Drawing.Point(32, 294);
            this.btnHomePhoto.Name = "btnHomePhoto";
            this.btnHomePhoto.Size = new System.Drawing.Size(178, 33);
            this.btnHomePhoto.TabIndex = 6;
            this.btnHomePhoto.Text = "Фотографія будинку";
            this.btnHomePhoto.UseVisualStyleBackColor = true;
            this.btnHomePhoto.Click += new System.EventHandler(this.btnHomePhoto_Click);
            // 
            // picturePortretPhoto
            // 
            this.picturePortretPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picturePortretPhoto.Location = new System.Drawing.Point(236, 184);
            this.picturePortretPhoto.Name = "picturePortretPhoto";
            this.picturePortretPhoto.Size = new System.Drawing.Size(165, 140);
            this.picturePortretPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePortretPhoto.TabIndex = 7;
            this.picturePortretPhoto.TabStop = false;
            this.picturePortretPhoto.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(431, 351);
            this.Controls.Add(this.picturePortretPhoto);
            this.Controls.Add(this.btnHomePhoto);
            this.Controls.Add(this.btnArtPhoto);
            this.Controls.Add(this.btnPortretPhoto);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbBorn);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbForm);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2";
            ((System.ComponentModel.ISupportInitialize)(this.picturePortretPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbForm;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbBorn;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Button btnPortretPhoto;
        private System.Windows.Forms.Button btnArtPhoto;
        private System.Windows.Forms.Button btnHomePhoto;
        private System.Windows.Forms.PictureBox picturePortretPhoto;
    }
}

