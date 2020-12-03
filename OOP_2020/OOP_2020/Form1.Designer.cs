namespace OOP_2020
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
            this.btnCreateHuman = new System.Windows.Forms.Button();
            this.txtTestValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateHuman
            // 
            this.btnCreateHuman.Location = new System.Drawing.Point(12, 12);
            this.btnCreateHuman.Name = "btnCreateHuman";
            this.btnCreateHuman.Size = new System.Drawing.Size(75, 23);
            this.btnCreateHuman.TabIndex = 0;
            this.btnCreateHuman.Text = "Создать";
            this.btnCreateHuman.UseVisualStyleBackColor = true;
            this.btnCreateHuman.Click += new System.EventHandler(this.btnCreateHuman_Click);
            // 
            // txtTestValue
            // 
            this.txtTestValue.Location = new System.Drawing.Point(93, 14);
            this.txtTestValue.Name = "txtTestValue";
            this.txtTestValue.Size = new System.Drawing.Size(132, 20);
            this.txtTestValue.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTestValue);
            this.Controls.Add(this.btnCreateHuman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateHuman;
        private System.Windows.Forms.TextBox txtTestValue;
    }
}

