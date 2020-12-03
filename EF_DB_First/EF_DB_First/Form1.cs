using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_DB_First
{
    public partial class Form1 : Form
    {
        ComputerShopEntities context;
        Bank selBank = null;
        public Form1()
        {
            InitializeComponent();

            context = new ComputerShopEntities();
        }

        private void btnReadBanks_Click(object sender, EventArgs e)
        {
            ShowBanks();

        }

        private void ShowBanks()
        {
            lstBanks.Items.Clear();
            foreach (var bank in context.Bank)
            {
                lstBanks.Items.Add(bank);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bank newBank = new Bank();

            newBank.BIC = txtBIC.Text;
            newBank.Address = txtAddress.Text;
            newBank.CorrAccount = txtCorrAccount.Text;

            context.Bank.Add(newBank);
            context.SaveChanges();

            ShowBanks();
        }

        private void lstBanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBanks.SelectedItem != null)
                selBank = (Bank)lstBanks.SelectedItem;
            else
                return;

            txtBIC.Text = selBank.BIC;
            txtAddress.Text = selBank.Address;
            txtCorrAccount.Text = selBank.CorrAccount;

            lstAccounts.Items.Clear();
            foreach(var acc in selBank.Account)
            {
                lstAccounts.Items.Add(acc);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selBank == null)
            {
                MessageBox.Show("Выберите банк");
                return;
            }
            //selBank.BIC = txtBIC.Text;
            selBank.Address = txtAddress.Text;
            selBank.CorrAccount = txtCorrAccount.Text;
            context.SaveChanges();
            ShowBanks();
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (selBank == null)
            {
                MessageBox.Show("Выберите банк");
                return;
            }

            if (selBank.Account.Count > 0)
            {
                MessageBox.Show("В банке есть счета, удаление невозможно");
                return;
            }

            context.Bank.Remove(selBank);
            context.SaveChanges();
            ShowBanks();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var c in context.Contragent)
                cbbContragent.Items.Add(c);
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (selBank == null)
            {
                MessageBox.Show("Выберите банк");
                return;
            }

            if (cbbContragent.SelectedItem == null)
            {
                MessageBox.Show("Выберите контрагента");
                return;
            }

            Account account = new Account();
            account.Number = txtNumber.Text;

            account.ID = ((Contragent)cbbContragent.SelectedItem).ID;
            account.BIC = selBank.BIC;

            context.Account.Add(account);
            context.SaveChanges();
        }
    }
}
