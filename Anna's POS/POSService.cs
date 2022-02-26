using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Anna_s_POS
{
    public partial class POSService : Form
    {
        public static Excel.Application excel = null;
        public static Excel.Workbook Database = null;
        public string files = "";
        public string jobTime = "";
        public string breakTime = "";
        public Single finalJobTime = 0;
        public int calculatedBreakTime = 0;
        public POSService()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void NewDatabase_Click(object sender, EventArgs e)
        {
            excel = excelCommands.WriteExcel();
            Database = excel.ActiveWorkbook;
            Excel.Worksheet activeSheet = Database.ActiveSheet;
        }

        private void openDatabase_Click(object sender, EventArgs e)
        {

            string fileName = null;

            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "C:\\Users\\mini_\\Desktop";
                openFileDialog1.Filter = "All Excel Files (*.xlsx*)|*.xls*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                    excel = new Excel.Application();
                    Database = excel.Workbooks.Open(fileName);
                    var actsheet = Database.ActiveSheet;
                    excel.Visible = true;
                }
                files = fileName;
            }
            //Have to do the output stuff.
        }

        private void closeDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                Database = excel.ActiveWorkbook;
                Database.Close();
                excel.Quit();
            }
            catch { }
        }

        private void submitEntry_Click(object sender, EventArgs e)
        {
            Excel.Worksheet actsheet = excel.ActiveWorkbook.ActiveSheet;
            List<string> entry = new List<string>(new string[] { jobDate.Text, jobName.Text, categoryList.Text, startTime1.Text, timeCompleted1.Text, calculatedBreakTime.ToString(), commentBox.Text });


            var usedRows = excel.WorksheetFunction.CountA(actsheet.Columns[1]);
            int cols = 1;

            /*            for (int m = 0; m < 4; m++) TODO: trying to stop someone adding in empty strings TODO: Stop people specifying a break time before the start or after the end time
                        {
                            if (entry[m] == "")
                            {

                            }
                        }*/

            for (int i = 0; i < entry.Count(); i++)
            {
                actsheet.Cells[usedRows + 1, cols] = entry[i];
                cols++;
            }

            ClearContents();
        }

        private void ClearContents()
        {
            categoryList.Text = "";
            jobName.Text = "";
            startTime1.Text = "";
            timeCompleted1.Text = "";
            commentBox.Text = "";
        }
        private void jobTimeCalculation(object sender, System.EventArgs e)
        {
            var calculatedBreakTime = 0;
            if (startTime1.Text == "" || timeCompleted1.Text == "")
            {
                return;
            }
            if (breakEnd1.Text == "" && breakStart1.Text != "" || breakEnd1.Text != "" && breakStart1.Text == "")
            {

            }
            else if (breakEnd1.Text != "" && breakStart1.Text != "")
            {
                calculatedBreakTime = Convert.ToInt32(breakEnd1.Text) - Convert.ToInt32(breakStart1.Text);              
            }
            Single calculatedJobTime =  Convert.ToInt32(timeCompleted1.Text)- Convert.ToInt32(startTime1.Text) - calculatedBreakTime;
            jobEntry.Refresh();
            int hours = Convert.ToByte(calculatedJobTime / 100);
            var min = (calculatedJobTime - hours * 100) / 60;
            finalJobTime = hours + min;
/*           Label label = new Label();
           //label.Text = "Job Time: " + finalJobTime.ToString() + " hours"; //TODO: have total job hours displayed
            label.Font = new Font("Times New Roman", 9);
            label.Location = new System.Drawing.Point(450, 145);
            jobEntry.Controls.Add(label);*/
        }

        private void completedSearch_Click(object sender, EventArgs e)
        {
            Excel.Worksheet actsheet = excel.ActiveWorkbook.ActiveSheet;
            var usedRows = excel.WorksheetFunction.CountA(actsheet.Columns[1]);
            for (int i = 0; i> usedRows;  i++)
            {

            }

        }
    }
  }



