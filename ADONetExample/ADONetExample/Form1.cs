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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Contragent". При необходимости она может быть перемещена или удалена.
            this.contragentTableAdapter.Fill(this.dataSet.Contragent);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.contragentTableAdapter.Update(this.dataSet.Contragent);
            }
            catch(DBConcurrencyException ex)
            {
                MessageBox.Show("Не удалось сохранить изменения");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContragentRow newRow = this.dataSet.Contragent.NewContragentRow();

            frmContragent frm = new frmContragent(newRow, true);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.dataSet.Contragent.Rows.Add(newRow);

                //dgvContragent.
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvContragent.CurrentRow != null)
            {
                int id = (int)dgvContragent.CurrentRow.Cells[0].Value;

                var row = dataSet.Contragent.FindByID(id);

                frmContragent frm = new frmContragent(row, false);
                if (frm.ShowDialog() == DialogResult.OK)
                    dgvContragent.Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContragent.CurrentRow != null)
            {
                int id = (int)dgvContragent.CurrentRow.Cells[0].Value;

                var row = dataSet.Contragent.FindByID(id);

                row.Delete();
            }
        }
    }
}
