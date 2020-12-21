using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Net_Clean
{
    public partial class frmMain : Form
    {
        private SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable contragents = new DataTable();
        SqlTransaction transaction = null;
        public frmMain()
        {
            InitializeComponent();

            conn = new SqlConnection(@"Data Source=DESKTOP-BAR5EC0;Initial Catalog = ComputerShop;Integrated Security=True;Connect Timeout=30;");
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"SELECT ID, Name, INN, Address FROM Contragent", conn);
                /*
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int rowNum = 0;
                    while (reader.Read())
                    {
                        
                        dgvMain.RowCount++;
                        dgvMain.Rows[rowNum].Cells[0].Value = reader["ID"].ToString();
                        dgvMain.Rows[rowNum].Cells[1].Value = reader["Name"].ToString();
                        dgvMain.Rows[rowNum].Cells[2].Value = reader["INN"].ToString();
                        dgvMain.Rows[rowNum].Cells[3].Value = reader["Address"].ToString();
                        rowNum++;
                    }
                }
                */
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(contragents);
                contragents.PrimaryKey = new DataColumn[] { contragents.Columns["ID"] };

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = builder.GetInsertCommand(true);
                adapter.UpdateCommand = builder.GetUpdateCommand(true);
                adapter.DeleteCommand = builder.GetDeleteCommand(true);

                //MessageBox.Show(adapter.UpdateCommand.CommandText);

                FillTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при работе с данными: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void FillTable()
        {
            dgvMain.RowCount = 0;
            int rowNum = 0;

            foreach(DataRow row in contragents.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                    continue;

                dgvMain.RowCount++;
                dgvMain.Rows[rowNum].Cells[0].Value = row["ID"].ToString();
                dgvMain.Rows[rowNum].Cells[1].Value = row["Name"].ToString();
                dgvMain.Rows[rowNum].Cells[2].Value = row["INN"].ToString();
                dgvMain.Rows[rowNum].Cells[3].Value = row["Address"].ToString();
                rowNum++;
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newRow = contragents.NewRow();

            frmContragent frm = new frmContragent(newRow, true);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                contragents.Rows.Add(newRow);
                FillTable();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(contragents);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                //string id = dgvMain.CurrentRow.Cells[0].Value.ToString();
                //DataRow row = contragents.Select("ID = " + id)[0];

                int id = Convert.ToInt32(dgvMain.CurrentRow.Cells[0].Value);
                DataRow row = contragents.Rows.Find(id);

                frmContragent frm = new frmContragent(row, false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    FillTable();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvMain.CurrentRow.Cells[0].Value);
                DataRow row = contragents.Rows.Find(id);

                row.Delete();
                FillTable();
                
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (transaction == null)
            {
                conn.Open();
                transaction = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
                SqlCommand cmd = new SqlCommand("INSERT INTO Contragent VALUES(10, 'Test', '123', 'None')", conn, transaction);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (transaction != null)
            {
                transaction.Commit();
                conn.Close();
                transaction = null;
            }
        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            if (transaction != null)
            {
                transaction.Rollback();
                conn.Close();
                transaction = null;
            }            
        }
    }
}
