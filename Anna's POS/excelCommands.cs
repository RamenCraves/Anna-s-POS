using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Anna_s_POS
{   
    static class excelCommands
    {
        public static Excel.Application excel = null;
        public static Excel.Workbook Database = null;

        public static Excel.Application WriteExcel()
        {
            if (excel == null)
            {
                excel = new Excel.Application();
            }
            excel.Visible = true;
            Database = excel.Workbooks.Add();
            var actsheet = (Excel.Worksheet)Database.ActiveSheet;
            actsheet.Columns["A:G"].ColumnWidth = 17;
            List<string> headings = new List<string>(new string[] { "Job Date", "Job Entry", "Category", "Start Time", "Time Completed", "Break Time", "Comments" });
            int rows = 1, cols = 1;

            for (int i = 0; i < headings.Count(); i++)
            {
                actsheet.Cells[rows, cols] = headings[i];
                cols++;
            }
            Excel.Range formatRange;
            formatRange = actsheet.get_Range("A:A");
            formatRange.NumberFormat = "@";
            return excel;
        }

        public static void OpenDatabase(string fileName)
        {
            excel = new Excel.Application();
            Database = excel.Workbooks.Open(fileName);
            var actsheet = (Excel.Worksheet)Database.ActiveSheet;
            excel.Visible = true;

        }
        public static void SaveDatabase()
        {
            Database = excel.ActiveWorkbook;
            Database.Save();
        }

        public static void CloseDatabase(Excel.Application Cexcel)
        {
            try
            {
                Database = Cexcel.ActiveWorkbook;
                Database.Close();
                Cexcel.Quit();
            }
            catch { }
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new POSService());
        }
    }
}
