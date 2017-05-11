namespace Lab_4
{
    partial class FormMain
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxR1 = new System.Windows.Forms.TextBox();
            this.textBoxR2 = new System.Windows.Forms.TextBox();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.radioButtonConsistent = new System.Windows.Forms.RadioButton();
            this.radioButtonParallel = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "R1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(72, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "R2";
            // 
            // textBoxR1
            // 
            this.textBoxR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxR1.Location = new System.Drawing.Point(109, 36);
            this.textBoxR1.Name = "textBoxR1";
            this.textBoxR1.Size = new System.Drawing.Size(173, 22);
            this.textBoxR1.TabIndex = 1;
            this.textBoxR1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumeric);
            // 
            // textBoxR2
            // 
            this.textBoxR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxR2.Location = new System.Drawing.Point(109, 75);
            this.textBoxR2.Name = "textBoxR2";
            this.textBoxR2.Size = new System.Drawing.Size(173, 22);
            this.textBoxR2.TabIndex = 2;
            this.textBoxR2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumeric);
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.radioButtonConsistent);
            this.groupBoxConnection.Controls.Add(this.radioButtonParallel);
            this.groupBoxConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxConnection.Location = new System.Drawing.Point(77, 123);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(200, 93);
            this.groupBoxConnection.TabIndex = 3;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "З\'єднання";
            // 
            // radioButtonConsistent
            // 
            this.radioButtonConsistent.AutoSize = true;
            this.radioButtonConsistent.Location = new System.Drawing.Point(24, 57);
            this.radioButtonConsistent.Name = "radioButtonConsistent";
            this.radioButtonConsistent.Size = new System.Drawing.Size(102, 20);
            this.radioButtonConsistent.TabIndex = 3;
            this.radioButtonConsistent.Text = "Послідовне";
            this.radioButtonConsistent.UseVisualStyleBackColor = true;
            this.radioButtonConsistent.CheckedChanged += new System.EventHandler(this.SwitchRadioButton);
            // 
            // radioButtonParallel
            // 
            this.radioButtonParallel.AutoSize = true;
            this.radioButtonParallel.Checked = true;
            this.radioButtonParallel.Location = new System.Drawing.Point(24, 27);
            this.radioButtonParallel.Name = "radioButtonParallel";
            this.radioButtonParallel.Size = new System.Drawing.Size(107, 20);
            this.radioButtonParallel.TabIndex = 3;
            this.radioButtonParallel.TabStop = true;
            this.radioButtonParallel.Text = "Паралельне";
            this.radioButtonParallel.UseVisualStyleBackColor = true;
            this.radioButtonParallel.CheckedChanged += new System.EventHandler(this.SwitchRadioButton);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(64, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Результат:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(111, 239);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(132, 32);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Розрахунок";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(161, 288);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(130, 22);
            this.textBoxResult.TabIndex = 100;
            this.textBoxResult.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 332);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBoxConnection);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxR2);
            this.Controls.Add(this.textBoxR1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab-4";
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxR1;
        private System.Windows.Forms.TextBox textBoxR2;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.RadioButton radioButtonConsistent;
        private System.Windows.Forms.RadioButton radioButtonParallel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

