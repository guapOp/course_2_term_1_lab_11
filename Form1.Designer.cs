namespace lab_11_code
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
            System.Windows.Forms.Label labelName;
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelWorked = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxWorked = new System.Windows.Forms.TextBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonСalculateSalary = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelName.Location = new System.Drawing.Point(12, 74);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(49, 24);
            labelName.TabIndex = 1;
            labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(12, 25);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(98, 24);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(12, 120);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(106, 24);
            this.labelPatronymic.TabIndex = 2;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRate.Location = new System.Drawing.Point(12, 167);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(158, 24);
            this.labelRate.TabIndex = 3;
            this.labelRate.Text = "Ставка руб\\час";
            // 
            // labelWorked
            // 
            this.labelWorked.AutoSize = true;
            this.labelWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorked.Location = new System.Drawing.Point(12, 218);
            this.labelWorked.Name = "labelWorked";
            this.labelWorked.Size = new System.Drawing.Size(221, 24);
            this.labelWorked.TabIndex = 4;
            this.labelWorked.Text = "Отработанное время";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSalary.Location = new System.Drawing.Point(12, 267);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(103, 24);
            this.labelSalary.TabIndex = 5;
            this.labelSalary.Text = "Зарплата";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(244, 28);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(260, 20);
            this.textBoxSurname.TabIndex = 6;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Enabled = false;
            this.textBoxSalary.Location = new System.Drawing.Point(244, 267);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.ReadOnly = true;
            this.textBoxSalary.Size = new System.Drawing.Size(159, 20);
            this.textBoxSalary.TabIndex = 7;
            // 
            // textBoxWorked
            // 
            this.textBoxWorked.Location = new System.Drawing.Point(244, 223);
            this.textBoxWorked.Name = "textBoxWorked";
            this.textBoxWorked.Size = new System.Drawing.Size(260, 20);
            this.textBoxWorked.TabIndex = 8;
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(244, 172);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(260, 20);
            this.textBoxRate.TabIndex = 9;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(244, 125);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(260, 20);
            this.textBoxPatronymic.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(244, 74);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(260, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // buttonСalculateSalary
            // 
            this.buttonСalculateSalary.Location = new System.Drawing.Point(409, 263);
            this.buttonСalculateSalary.Name = "buttonСalculateSalary";
            this.buttonСalculateSalary.Size = new System.Drawing.Size(95, 28);
            this.buttonСalculateSalary.TabIndex = 12;
            this.buttonСalculateSalary.Text = "Рассчитать";
            this.buttonСalculateSalary.UseVisualStyleBackColor = true;
            this.buttonСalculateSalary.Click += new System.EventHandler(this.buttonCalculateSalaryClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.handleCancel);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "Ок";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.handleOk);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 33);
            this.button4.TabIndex = 15;
            this.button4.Text = "Сохранить в файл";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.handleSaveToFile);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 399);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonСalculateSalary);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.textBoxWorked);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelWorked);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(labelName);
            this.Controls.Add(this.labelSurname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelWorked;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxWorked;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonСalculateSalary;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

