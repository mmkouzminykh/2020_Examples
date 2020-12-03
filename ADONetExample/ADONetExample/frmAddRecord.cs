using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ADONetExample.DataSet;

namespace ADONetExample
{
    public partial class frmContragent : Form
    {
        private bool isNew;
        private ContragentRow row;
        public frmContragent(ContragentRow row, bool isNew)
        {
            InitializeComponent();

            this.row = row;
            this.isNew = isNew;
        }

        private void frmContragent_Load(object sender, EventArgs e)
        {
            if (isNew)
            {
                nudID.ReadOnly = false;
            }
            else
            {
                nudID.ReadOnly = true;
                nudID.Value = row.ID;
                txtName.Text = row.Name;
                txtINN.Text = row.INN;
                txtAddress.Text = row.Address;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isNew)
                row.ID = (int)nudID.Value;

            row.Name = txtName.Text;
            row.INN = txtINN.Text;
            row.Address = txtAddress.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
