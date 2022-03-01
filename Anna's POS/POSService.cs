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
        public string[] searchEntry = new string[8] { "", "", "", "", "", "", "", "" };
        
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
            List<string> entry = new List<string>(new string[] { jobDate.Text, jobName.Text, categoryList.Text, startTime1.Text, timeCompleted1.Text, calculatedBreakTime.ToString(), commentBox.Text, finalJobTime.ToString() });


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
            breakStart1.Text = "";
            breakEnd1.Text = "";
        }
        public void jobTimeCalculation(object sender, System.EventArgs e)
        {
            if (startTime1.Text == "" || timeCompleted1.Text == "")
            {
                calculatedBreakTime = 0;
                return;
            }
            if (breakEnd1.Text == "" && breakStart1.Text != "" || breakEnd1.Text != "" && breakStart1.Text == "")
            {
                calculatedBreakTime = 0;
                return;
            }
            else if (breakEnd1.Text != "" && breakStart1.Text != "")
            {
                calculatedBreakTime = Convert.ToInt32(breakEnd1.Text) - Convert.ToInt32(breakStart1.Text);
            }
            Single calculatedJobTime = Convert.ToInt32(timeCompleted1.Text) - Convert.ToInt32(startTime1.Text) - calculatedBreakTime;
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
            completedJobsList.Items.Clear();
            FillinSearch(completedStart.Text, completedEnd.Text);

        }
        /*completedJobsList.Refresh();*/

        private void saveDatabase_Click(object sender, EventArgs e)
        {
            excelCommands.SaveDatabase();
        }

        private void FillinSearch(string startDate, string endDate)
        {
            Excel.Worksheet actsheet = excel.ActiveWorkbook.ActiveSheet;
            var usedRows = excel.WorksheetFunction.CountA(actsheet.Columns[1]);
            string[] listStartSearch = startDate.Split('/');
            string[] listEndSearch = endDate.Split('/');
            DateTime startSearch = new DateTime(Convert.ToInt32(listStartSearch[2]), Convert.ToInt32(listStartSearch[1]), Convert.ToInt32(listStartSearch[0]));
            DateTime endSearch = new DateTime(Convert.ToInt32(listEndSearch[2]), Convert.ToInt32(listEndSearch[1]), Convert.ToInt32(listEndSearch[0]));

            List<int> successfulSearches = new List<int>();


            for (int i = 2; i < usedRows + 1; i++)
            {
                var strSearchDate = actsheet.Cells[i, 1].Value;
                string[] listSearchDate = strSearchDate.Split('/');
                DateTime searchDate = new DateTime(Convert.ToInt32(listSearchDate[2]), Convert.ToInt32(listSearchDate[1]), Convert.ToInt32(listSearchDate[0]));

                if (startSearch <= searchDate && searchDate <= endSearch)
                {
                    successfulSearches.Add(i);
                }

            }
            /*string trial = (actsheet.Cells[2, 1].Value).ToString();*/
            foreach (int entryPos in successfulSearches)
            {
                for (int pos = 1; pos <= 8; pos++)
                {
                    searchEntry[pos - 1] = (actsheet.Cells[entryPos, pos].Value).ToString();
                }
                completedJobsList.Items.Add(new ListViewItem(new[] { searchEntry[0], searchEntry[1], searchEntry[2], searchEntry[3], searchEntry[4], searchEntry[5], searchEntry[6], searchEntry[7] }));

            }
        }

        private void PrintSetup_Click(object sender, EventArgs e)
        {
            PageSetupDialog PageSetupDialog1 = new PageSetupDialog();
            PageSetupDialog1.PageSettings = new System.Drawing.Printing.PageSettings();
            PageSetupDialog1.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            PageSetupDialog1.ShowNetwork = false;
            DialogResult result = PageSetupDialog1.ShowDialog();

            if (result == DialogResult.OK)
    {
        object[] results = new object[]{ 
            PageSetupDialog1.PageSettings.Margins, 
            PageSetupDialog1.PageSettings.PaperSize, 
            PageSetupDialog1.PageSettings.Landscape, 
            PageSetupDialog1.PrinterSettings.PrinterName, 
            PageSetupDialog1.PrinterSettings.PrintRange};
/*        ListBox1.Items.AddRange(results);*/
    }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.Document = printDocument1;
            DialogResult result = dlg.ShowDialog();

            if(result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Times New Roman", 12);
            e.Graphics.DrawString("Sample String", printFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top, new StringFormat());
        }
    }
}



