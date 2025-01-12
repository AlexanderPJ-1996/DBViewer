using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DBReader
{
    public partial class MainForm : Form
    {
        private readonly Conn cn = new Conn(); // Access class for connection
        private readonly Expo Ex = new Expo(); // Access class to export data
        String CoString; // Retain connection string

        public MainForm()
        {
            InitializeComponent();
            Text = Application.ProductName;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowCtrl(false);
            FrmProps(sender, e);
        }
        // Defining properties and calling events of controls
        void FrmProps(object sender, EventArgs e)
        {
            // Assign SQL statement type
            List<String> Statement = new List<String>
            {
                String.Empty,
                "that returns data",
                "that does not return data"
            };
            CBxState.Items.AddRange(Statement.ToArray());
            // Assign cell colors
            DGVTable.RowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
            DGVTable.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            DGVColum.RowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
            DGVColum.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            TBxCoStr_TextChanged(sender, e);
            TBxCoStr.Focus();
        }
        // Show or hide connection button and store database ConnectionString
        private void TBxCoStr_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Replace(TBxCoStr.Text, @"\s", String.Empty) != String.Empty)
            {
                BtnConnO.Visible = true;
            }
            else
            {
                BtnConnO.Visible = false;
            }
            CoString = TBxCoStr.Text;
        }
        // Test connection to the database
        private void BtnConnO_Click(object sender, EventArgs e)
        {
            cn.TryCon(CoString);
            ShowCtrl(cn.EConn);
        }
        // Validation to show or hide controls
        void ShowCtrl(Boolean Values)
        {
            if (Values == true)
            {
                BtnConnC.Visible = true;
                PanTable.Visible = true;
                TaCColum.Visible = true;
                PanState.Visible = true;

                TBxCoStr.Enabled = false;
                BtnConnO.Visible = false;
                BtnConnC.Visible = true;
            }
            else
            {
                BtnConnC.Visible = false;
                PanTable.Visible = false;
                TaCColum.Visible = false;
                PanState.Visible = false;

                TBxCoStr.Enabled = true;
                BtnConnO.Visible = true;
                BtnConnC.Visible = false;
                TBxCoStr.Focus();
            }
        }
        // Capture table/view name
        void CellE()
        {
            if (DGVTable.RowCount > 0)
            {
                try
                {
                    TBxTable.Text = DGVTable.CurrentRow.Cells[0].Value.ToString();
                }
                catch (Exception)
                {

                }
            }
            else
            {
                TBxTable.Clear();
            }
        }

        private void DGVTable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CellE();
        }
        // Load tables/views from database
        private void BtnTable_Click(object sender, EventArgs e)
        {
            cn.DBTables(DGVTable, CoString);
            try
            {
                DGVTable.Columns[0].HeaderText = "Table/View Name";
                DGVTable.Columns[0].Width = 200;
                DGVTable.Columns[1].HeaderText = "Type";
                DGVTable.Columns[1].Width = 150;
            }
            catch (Exception)
            {

            }
        }
        // Empty tables and columns
        private void BtnCleaT_Click(object sender, EventArgs e)
        {
            DGVColum.Columns.Clear();
            DGVTable.Columns.Clear();
        }
        // Load columns from tables/views
        private void BtnShowD_Click(object sender, EventArgs e)
        {
            if (Regex.Replace(TBxTable.Text, @"\s", String.Empty) != String.Empty)
            {
                String Table = TBxTable.Text;
                cn.DBColumns(DGVColum, CoString, Table);
            }
        }
        // Empty columns
        private void BtnCleaD_Click(object sender, EventArgs e)
        {
            DGVColum.Columns.Clear();
        }
        // Select SQL statement type
        private void CBxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Regex.Replace(CBxState.Text, @"\s", String.Empty) != String.Empty)
            {
                TBxState.Focus();
            }
            else
            {
                TBxState.Clear();
            }
        }
        // Validate and execute SQL statements
        private void BtnExecu_Click(object sender, EventArgs e)
        {
            if (Regex.Replace(CBxState.Text, @"\s", String.Empty) == String.Empty)
            {
                MessageBox.Show("First you will need to select what type of instruction you want to execute", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CBxState.Focus();
            }
            else if (Regex.Replace(TBxState.Text, @"\s", String.Empty) == String.Empty)
            {
                MessageBox.Show("Type the instruction you want to execute", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TBxState.Focus();
            }
            else
            {
                String Stat = TBxState.Text;
                switch (CBxState.Text)
                {
                    case "that returns data":
                        cn.StatRetY(DGVColum, CoString, Stat);
                        break;
                    case "that does not return data":
                        cn.StatRetN(CoString, Stat);
                        break;
                }
            }
        }
        // Calling procedures to export data
        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if (DGVColum.Columns.Count > 0)
            {
                Ex.Export(DGVColum);
            }
            else
            {
                MessageBox.Show("You will first need to load the columns of a table/view", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // Close connection and clear controls
        private void BtnConnC_Click(object sender, EventArgs e)
        {
            CBxState.ResetText();
            TBxState.Clear();
            BtnCleaT_Click(sender, e);
            ShowCtrl(false);
            TBxCoStr.Clear();
            TBxCoStr.Focus();
        }
    }
}
