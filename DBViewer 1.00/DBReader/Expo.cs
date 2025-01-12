using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DBReader
{
    public class Expo // Procedure to export data from a table to an excel file
    {
        public void Export(DataGridView DGV)
        {
            Excel.Application ExcelApp = new Excel.Application();
            Excel.Workbook WorkBook = ExcelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet WorkSheet = WorkBook.Sheets[1];
            WorkSheet = WorkBook.ActiveSheet;
            WorkSheet.Name = "ExportedData";
            // Export headers
            for (Int32 i = 1; i < DGV.Columns.Count + 1; i++)
            {
                WorkSheet.Cells[1, i] = DGV.Columns[i - 1].HeaderText;
            }
            // Export the data
            for (Int32 i = 0; i < DGV.Rows.Count; i++)
            {
                for (Int32 j = 0; j < DGV.Columns.Count; j++)
                {
                    WorkSheet.Cells[i + 2, j + 1] = DGV.Rows[i].Cells[j].Value.ToString();
                }
            }
            // Save the file
            SaveFileDialog SaveDialog = new SaveFileDialog
            {
                Filter = "Excel files|*.xlsx",
                Title = "Save Excel file",
                /*
				This last line [FileName] can be removed, as it is only to give an automatic 
                name to the file that is unsaved.
				*/
                FileName = "ExportedData"
            };
            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                WorkBook.SaveAs(SaveDialog.FileName);
                WorkBook.Close();
                ExcelApp.Quit();
            }
        }
    }
}
