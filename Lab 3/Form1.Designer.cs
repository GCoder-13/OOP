namespace Lab_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabPageEx_1 = new System.Windows.Forms.TabPage();
            this.lbDepositAmount = new System.Windows.Forms.Label();
            this.lbRate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbSum = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.TabPageEx_2 = new System.Windows.Forms.TabPage();
            this.labelDistance = new System.Windows.Forms.Label();
            this.labelConsumption = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.textBoxConsumption = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.TabControlMain.SuspendLayout();
            this.TabPageEx_1.SuspendLayout();
            this.TabPageEx_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.TabPageEx_1);
            this.TabControlMain.Controls.Add(this.TabPageEx_2);
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMain.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabControlMain.Location = new System.Drawing.Point(0, 0);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(578, 323);
            this.TabControlMain.TabIndex = 0;
            // 
            // TabPageEx_1
            // 
            this.TabPageEx_1.BackColor = System.Drawing.SystemColors.Control;
            this.TabPageEx_1.Controls.Add(this.lbDepositAmount);
            this.TabPageEx_1.Controls.Add(this.lbRate);
            this.TabPageEx_1.Controls.Add(this.lbTime);
            this.TabPageEx_1.Controls.Add(this.lbSum);
            this.TabPageEx_1.Controls.Add(this.btnCalculate);
            this.TabPageEx_1.Controls.Add(this.textBoxDepositAmount);
            this.TabPageEx_1.Controls.Add(this.textBoxRate);
            this.TabPageEx_1.Controls.Add(this.textBoxTime);
            this.TabPageEx_1.Controls.Add(this.textBoxSum);
            this.TabPageEx_1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabPageEx_1.Location = new System.Drawing.Point(4, 30);
            this.TabPageEx_1.Name = "TabPageEx_1";
            this.TabPageEx_1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageEx_1.Size = new System.Drawing.Size(570, 289);
            this.TabPageEx_1.TabIndex = 0;
            this.TabPageEx_1.Text = "Ex. 1";
            // 
            // lbDepositAmount
            // 
            this.lbDepositAmount.AutoSize = true;
            this.lbDepositAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDepositAmount.Location = new System.Drawing.Point(72, 175);
            this.lbDepositAmount.Name = "lbDepositAmount";
            this.lbDepositAmount.Size = new System.Drawing.Size(169, 22);
            this.lbDepositAmount.TabIndex = 8;
            this.lbDepositAmount.Text = "Сума вкладу (грн)";
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRate.Location = new System.Drawing.Point(142, 121);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(104, 22);
            this.lbRate.TabIndex = 7;
            this.lbRate.Text = "Ставка(%)";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(174, 70);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(70, 22);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "Термін";
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSum.Location = new System.Drawing.Point(138, 20);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(103, 22);
            this.lbSum.TabIndex = 5;
            this.lbSum.Text = "Сума (грн)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(208, 229);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(170, 33);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Обчислити";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.Calculate);
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.Location = new System.Drawing.Point(263, 173);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.ReadOnly = true;
            this.textBoxDepositAmount.Size = new System.Drawing.Size(198, 29);
            this.textBoxDepositAmount.TabIndex = 3;
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(263, 119);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(198, 29);
            this.textBoxRate.TabIndex = 2;
            this.textBoxRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(263, 68);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(198, 29);
            this.textBoxTime.TabIndex = 1;
            this.textBoxTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(263, 18);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(198, 29);
            this.textBoxSum.TabIndex = 0;
            this.textBoxSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // TabPageEx_2
            // 
            this.TabPageEx_2.BackColor = System.Drawing.SystemColors.Control;
            this.TabPageEx_2.Controls.Add(this.labelCost);
            this.TabPageEx_2.Controls.Add(this.textBoxCost);
            this.TabPageEx_2.Controls.Add(this.buttonCalculate);
            this.TabPageEx_2.Controls.Add(this.labelDistance);
            this.TabPageEx_2.Controls.Add(this.labelConsumption);
            this.TabPageEx_2.Controls.Add(this.labelPrice);
            this.TabPageEx_2.Controls.Add(this.textBoxDistance);
            this.TabPageEx_2.Controls.Add(this.textBoxConsumption);
            this.TabPageEx_2.Controls.Add(this.textBoxPrice);
            this.TabPageEx_2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabPageEx_2.Location = new System.Drawing.Point(4, 30);
            this.TabPageEx_2.Name = "TabPageEx_2";
            this.TabPageEx_2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageEx_2.Size = new System.Drawing.Size(570, 289);
            this.TabPageEx_2.TabIndex = 1;
            this.TabPageEx_2.Text = "Ex. 2";
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDistance.Location = new System.Drawing.Point(209, 124);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(128, 22);
            this.labelDistance.TabIndex = 13;
            this.labelDistance.Text = "Відстань (км)";
            // 
            // labelConsumption
            // 
            this.labelConsumption.AutoSize = true;
            this.labelConsumption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConsumption.Location = new System.Drawing.Point(26, 73);
            this.labelConsumption.Name = "labelConsumption";
            this.labelConsumption.Size = new System.Drawing.Size(311, 22);
            this.labelConsumption.TabIndex = 12;
            this.labelConsumption.Text = "Споживання бензину (літр/100 км)";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(126, 23);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(211, 22);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Ціна бензину (грн/літр)";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(343, 122);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(198, 29);
            this.textBoxDistance.TabIndex = 10;
            this.textBoxDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // textBoxConsumption
            // 
            this.textBoxConsumption.Location = new System.Drawing.Point(343, 71);
            this.textBoxConsumption.Name = "textBoxConsumption";
            this.textBoxConsumption.Size = new System.Drawing.Size(198, 29);
            this.textBoxConsumption.TabIndex = 9;
            this.textBoxConsumption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(343, 21);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(198, 29);
            this.textBoxPrice.TabIndex = 8;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(190, 175);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(170, 33);
            this.buttonCalculate.TabIndex = 14;
            this.buttonCalculate.Text = "Порахувати";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(48, 240);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(132, 22);
            this.labelCost.TabIndex = 16;
            this.labelCost.Text = "Вартість (грн)";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(213, 238);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(328, 29);
            this.textBoxCost.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 323);
            this.Controls.Add(this.TabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 3";
            this.TabControlMain.ResumeLayout(false);
            this.TabPageEx_1.ResumeLayout(false);
            this.TabPageEx_1.PerformLayout();
            this.TabPageEx_2.ResumeLayout(false);
            this.TabPageEx_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage TabPageEx_1;
        private System.Windows.Forms.TabPage TabPageEx_2;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBoxDepositAmount;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label lbDepositAmount;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelConsumption;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.TextBox textBoxConsumption;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

