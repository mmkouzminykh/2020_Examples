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
            this.btnInfo = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnIEnumerableTest = new System.Windows.Forms.Button();
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
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 57);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Get Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(93, 60);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(360, 172);
            this.txtInfo.TabIndex = 3;
            // 
            // btnIEnumerableTest
            // 
            this.btnIEnumerableTest.Location = new System.Drawing.Point(12, 86);
            this.btnIEnumerableTest.Name = "btnIEnumerableTest";
            this.btnIEnumerableTest.Size = new System.Drawing.Size(75, 23);
            this.btnIEnumerableTest.TabIndex = 4;
            this.btnIEnumerableTest.Text = "IEnumerable";
            this.btnIEnumerableTest.UseVisualStyleBackColor = true;
            this.btnIEnumerableTest.Click += new System.EventHandler(this.btnIEnumerableTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIEnumerableTest);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnInfo);
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
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnIEnumerableTest;
    }
}

