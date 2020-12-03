namespace EF_DB_First
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
            this.lstBanks = new System.Windows.Forms.ListBox();
            this.btnReadBanks = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBIC = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCorrAccount = new System.Windows.Forms.TextBox();
            this.lblBIC = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCorrAccount = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblContragent = new System.Windows.Forms.Label();
            this.cbbContragent = new System.Windows.Forms.ComboBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBanks
            // 
            this.lstBanks.FormattingEnabled = true;
            this.lstBanks.Location = new System.Drawing.Point(21, 12);
            this.lstBanks.Name = "lstBanks";
            this.lstBanks.Size = new System.Drawing.Size(254, 290);
            this.lstBanks.TabIndex = 0;
            this.lstBanks.SelectedIndexChanged += new System.EventHandler(this.lstBanks_SelectedIndexChanged);
            // 
            // btnReadBanks
            // 
            this.btnReadBanks.Location = new System.Drawing.Point(21, 320);
            this.btnReadBanks.Name = "btnReadBanks";
            this.btnReadBanks.Size = new System.Drawing.Size(75, 23);
            this.btnReadBanks.TabIndex = 1;
            this.btnReadBanks.Text = "Прочитать";
            this.btnReadBanks.UseVisualStyleBackColor = true;
            this.btnReadBanks.Click += new System.EventHandler(this.btnReadBanks_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 519);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBIC
            // 
            this.txtBIC.Location = new System.Drawing.Point(85, 364);
            this.txtBIC.Name = "txtBIC";
            this.txtBIC.Size = new System.Drawing.Size(100, 20);
            this.txtBIC.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(85, 400);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(190, 61);
            this.txtAddress.TabIndex = 4;
            // 
            // txtCorrAccount
            // 
            this.txtCorrAccount.Location = new System.Drawing.Point(85, 480);
            this.txtCorrAccount.Name = "txtCorrAccount";
            this.txtCorrAccount.Size = new System.Drawing.Size(190, 20);
            this.txtCorrAccount.TabIndex = 5;
            // 
            // lblBIC
            // 
            this.lblBIC.AutoSize = true;
            this.lblBIC.Location = new System.Drawing.Point(19, 368);
            this.lblBIC.Name = "lblBIC";
            this.lblBIC.Size = new System.Drawing.Size(29, 13);
            this.lblBIC.TabIndex = 6;
            this.lblBIC.Text = "БИК";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(19, 403);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(38, 13);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Адрес";
            // 
            // lblCorrAccount
            // 
            this.lblCorrAccount.AutoSize = true;
            this.lblCorrAccount.Location = new System.Drawing.Point(19, 483);
            this.lblCorrAccount.Name = "lblCorrAccount";
            this.lblCorrAccount.Size = new System.Drawing.Size(57, 13);
            this.lblCorrAccount.TabIndex = 8;
            this.lblCorrAccount.Text = "Корр.счет";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(103, 519);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(102, 320);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 10;
            this.bntDelete.Text = "Удалить";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // lstAccounts
            // 
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.Location = new System.Drawing.Point(301, 12);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(253, 160);
            this.lstAccounts.TabIndex = 11;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(308, 185);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(41, 13);
            this.lblNumber.TabIndex = 12;
            this.lblNumber.Text = "Номер";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(389, 182);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(165, 20);
            this.txtNumber.TabIndex = 13;
            // 
            // lblContragent
            // 
            this.lblContragent.AutoSize = true;
            this.lblContragent.Location = new System.Drawing.Point(308, 232);
            this.lblContragent.Name = "lblContragent";
            this.lblContragent.Size = new System.Drawing.Size(65, 13);
            this.lblContragent.TabIndex = 14;
            this.lblContragent.Text = "Контрагент";
            // 
            // cbbContragent
            // 
            this.cbbContragent.FormattingEnabled = true;
            this.cbbContragent.Location = new System.Drawing.Point(389, 229);
            this.cbbContragent.Name = "cbbContragent";
            this.cbbContragent.Size = new System.Drawing.Size(165, 21);
            this.cbbContragent.TabIndex = 15;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(311, 279);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(118, 23);
            this.btnAddAccount.TabIndex = 16;
            this.btnAddAccount.Text = "Добавить счет";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 572);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.cbbContragent);
            this.Controls.Add(this.lblContragent);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lstAccounts);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblCorrAccount);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBIC);
            this.Controls.Add(this.txtCorrAccount);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtBIC);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReadBanks);
            this.Controls.Add(this.lstBanks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBanks;
        private System.Windows.Forms.Button btnReadBanks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBIC;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCorrAccount;
        private System.Windows.Forms.Label lblBIC;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCorrAccount;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.ListBox lstAccounts;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblContragent;
        private System.Windows.Forms.ComboBox cbbContragent;
        private System.Windows.Forms.Button btnAddAccount;
    }
}

