using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBReader
{
    public class Conn // Mini backend to connect to database
    {
        public Boolean EConn;
        // Test connection to the database
        public void TryCon(String CoString)
        {
            using (var Connect = new SqlConnection(CoString))
            {
                try
                {
                    Connect.Open();
                    EConn = true;
                    Connect.Close();
                    MessageBox.Show("Connection successful", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EConn = false;
                }
            }
        }
        // Load and show existing tables and views
        public void DBTables(DataGridView DGV, String CoString)
        {
            using (var Connect = new SqlConnection(CoString))
            {
                Connect.Open();
                try
                {
                    String QSel = "SELECT TABLE_NAME, TABLE_TYPE FROM Information_Schema.Tables";
                    SqlDataAdapter DA = new SqlDataAdapter(QSel, Connect);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    DGV.DataSource = DT;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "DBTables", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Connect.Close();
            }
        }
        // Show columns of the selected table
        public void DBColumns(DataGridView DGV, String CoString, String Table)
        {
            using (var Connect = new SqlConnection(CoString))
            {
                Connect.Open();
                try
                {
                    String QSel = "SELECT * FROM " + Table;
                    SqlDataAdapter DA = new SqlDataAdapter(QSel, Connect);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    DGV.DataSource = DT;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "DBColumns", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Connect.Close();
            }
        }
        // SQL statement that returns data
        public void StatRetY(DataGridView DGV, String CoString, String Stat)
        {
            using (var Connect = new SqlConnection(CoString))
            {
                Connect.Open();
                try
                {
                    SqlDataAdapter DA = new SqlDataAdapter(Stat, Connect);
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    DGV.DataSource = DT;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "StatRetY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Connect.Close();
            }
        }
        // SQL statement that does not return data
        public void StatRetN(String CoString, String Stat)
        {
            using (var Connect = new SqlConnection(CoString))
            {
                Connect.Open();
                try
                {
                    SqlCommand CMD = new SqlCommand(Stat, Connect);
                    CMD.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "StatRetN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Connect.Close();
            }
        }
    }
}
