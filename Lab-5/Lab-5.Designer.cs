namespace Lab_5
{
    partial class FormLab_5
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
            this.textBoxStartMeasure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStartMeasure = new System.Windows.Forms.ComboBox();
            this.comboBoxFinishMeasure = new System.Windows.Forms.ComboBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Початкова величина";
            // 
            // textBoxStartMeasure
            // 
            this.textBoxStartMeasure.Location = new System.Drawing.Point(44, 59);
            this.textBoxStartMeasure.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStartMeasure.Name = "textBoxStartMeasure";
            this.textBoxStartMeasure.Size = new System.Drawing.Size(260, 26);
            this.textBoxStartMeasure.TabIndex = 1;
            this.textBoxStartMeasure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumeric);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Результат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "==>";
            // 
            // comboBoxStartMeasure
            // 
            this.comboBoxStartMeasure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartMeasure.FormattingEnabled = true;
            this.comboBoxStartMeasure.Location = new System.Drawing.Point(44, 106);
            this.comboBoxStartMeasure.Name = "comboBoxStartMeasure";
            this.comboBoxStartMeasure.Size = new System.Drawing.Size(79, 26);
            this.comboBoxStartMeasure.TabIndex = 2;
            // 
            // comboBoxFinishMeasure
            // 
            this.comboBoxFinishMeasure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFinishMeasure.FormattingEnabled = true;
            this.comboBoxFinishMeasure.Location = new System.Drawing.Point(225, 106);
            this.comboBoxFinishMeasure.Name = "comboBoxFinishMeasure";
            this.comboBoxFinishMeasure.Size = new System.Drawing.Size(79, 26);
            this.comboBoxFinishMeasure.TabIndex = 3;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(44, 246);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(260, 26);
            this.textBoxResult.TabIndex = 1;
            this.textBoxResult.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(59, 157);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(234, 37);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Розрахунок";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // FormLab_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 299);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.comboBoxFinishMeasure);
            this.Controls.Add(this.comboBoxStartMeasure);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxStartMeasure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLab_5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab-5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStartMeasure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStartMeasure;
        private System.Windows.Forms.ComboBox comboBoxFinishMeasure;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button btnCalculate;
    }
}

