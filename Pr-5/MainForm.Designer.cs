namespace Pr_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlus = new System.Windows.Forms.Label();
            this.labelMinus = new System.Windows.Forms.Label();
            this.labelMnozh = new System.Windows.Forms.Label();
            this.labelDil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Виберіть операцію";
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPlus.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlus.Location = new System.Drawing.Point(115, 76);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(121, 23);
            this.labelPlus.TabIndex = 1;
            this.labelPlus.Text = "Додавання";
            this.labelPlus.Click += new System.EventHandler(this.labelPlus_Click);
            // 
            // labelMinus
            // 
            this.labelMinus.AutoSize = true;
            this.labelMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMinus.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinus.Location = new System.Drawing.Point(112, 128);
            this.labelMinus.Name = "labelMinus";
            this.labelMinus.Size = new System.Drawing.Size(127, 23);
            this.labelMinus.TabIndex = 1;
            this.labelMinus.Text = "Віднімання";
            this.labelMinus.Click += new System.EventHandler(this.labelMinus_Click);
            // 
            // labelMnozh
            // 
            this.labelMnozh.AutoSize = true;
            this.labelMnozh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMnozh.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMnozh.Location = new System.Drawing.Point(115, 180);
            this.labelMnozh.Name = "labelMnozh";
            this.labelMnozh.Size = new System.Drawing.Size(120, 23);
            this.labelMnozh.TabIndex = 1;
            this.labelMnozh.Text = "Множення";
            this.labelMnozh.Click += new System.EventHandler(this.labelMnozh_Click);
            // 
            // labelDil
            // 
            this.labelDil.AutoSize = true;
            this.labelDil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDil.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDil.Location = new System.Drawing.Point(129, 232);
            this.labelDil.Name = "labelDil";
            this.labelDil.Size = new System.Drawing.Size(93, 23);
            this.labelDil.TabIndex = 1;
            this.labelDil.Text = "Ділення";
            this.labelDil.Click += new System.EventHandler(this.labelDil_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 292);
            this.Controls.Add(this.labelDil);
            this.Controls.Add(this.labelMnozh);
            this.Controls.Add(this.labelMinus);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pr-5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.Label labelMinus;
        private System.Windows.Forms.Label labelMnozh;
        private System.Windows.Forms.Label labelDil;
    }
}

