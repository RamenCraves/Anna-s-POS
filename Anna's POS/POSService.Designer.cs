namespace Anna_s_POS
{
    partial class POSService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSService));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.jobEntry = new System.Windows.Forms.TabPage();
            this.saveDatabase = new System.Windows.Forms.Button();
            this.categoryList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jobDate = new System.Windows.Forms.DateTimePicker();
            this.closeDatabase = new System.Windows.Forms.Button();
            this.openDatabase = new System.Windows.Forms.Button();
            this.newDatabase = new System.Windows.Forms.Button();
            this.breakEnd1 = new System.Windows.Forms.TextBox();
            this.breakStart1 = new System.Windows.Forms.TextBox();
            this.breakEndTime1 = new System.Windows.Forms.Label();
            this.breakStartTime1 = new System.Windows.Forms.Label();
            this.submitEntry = new System.Windows.Forms.Button();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.timeCompleted1 = new System.Windows.Forms.TextBox();
            this.startTime1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.jobCategoryLabel = new System.Windows.Forms.Label();
            this.jobName = new System.Windows.Forms.TextBox();
            this.jobNameLabel = new System.Windows.Forms.Label();
            this.completedJobs = new System.Windows.Forms.TabPage();
            this.Print = new System.Windows.Forms.Button();
            this.PrintSetup = new System.Windows.Forms.Button();
            this.completedSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.completedEnd = new System.Windows.Forms.DateTimePicker();
            this.completedStart = new System.Windows.Forms.DateTimePicker();
            this.completedJobsList = new System.Windows.Forms.ListView();
            this.listJobDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listJobEntry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listTimeCompleted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBreakTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listComments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billing = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.billingSearch = new System.Windows.Forms.Button();
            this.billingEnd = new System.Windows.Forms.DateTimePicker();
            this.billingStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tabControl1.SuspendLayout();
            this.jobEntry.SuspendLayout();
            this.completedJobs.SuspendLayout();
            this.billing.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.jobEntry);
            this.tabControl1.Controls.Add(this.completedJobs);
            this.tabControl1.Controls.Add(this.billing);
            this.tabControl1.Location = new System.Drawing.Point(12, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 525);
            this.tabControl1.TabIndex = 0;
            // 
            // jobEntry
            // 
            this.jobEntry.Controls.Add(this.saveDatabase);
            this.jobEntry.Controls.Add(this.categoryList);
            this.jobEntry.Controls.Add(this.label2);
            this.jobEntry.Controls.Add(this.jobDate);
            this.jobEntry.Controls.Add(this.closeDatabase);
            this.jobEntry.Controls.Add(this.openDatabase);
            this.jobEntry.Controls.Add(this.newDatabase);
            this.jobEntry.Controls.Add(this.breakEnd1);
            this.jobEntry.Controls.Add(this.breakStart1);
            this.jobEntry.Controls.Add(this.breakEndTime1);
            this.jobEntry.Controls.Add(this.breakStartTime1);
            this.jobEntry.Controls.Add(this.submitEntry);
            this.jobEntry.Controls.Add(this.commentBox);
            this.jobEntry.Controls.Add(this.commentLabel);
            this.jobEntry.Controls.Add(this.timeCompleted1);
            this.jobEntry.Controls.Add(this.startTime1);
            this.jobEntry.Controls.Add(this.label1);
            this.jobEntry.Controls.Add(this.startTimeLabel);
            this.jobEntry.Controls.Add(this.jobCategoryLabel);
            this.jobEntry.Controls.Add(this.jobName);
            this.jobEntry.Controls.Add(this.jobNameLabel);
            this.jobEntry.Location = new System.Drawing.Point(4, 25);
            this.jobEntry.Name = "jobEntry";
            this.jobEntry.Padding = new System.Windows.Forms.Padding(3);
            this.jobEntry.Size = new System.Drawing.Size(846, 496);
            this.jobEntry.TabIndex = 0;
            this.jobEntry.Text = "Job Entry";
            this.jobEntry.UseVisualStyleBackColor = true;
            // 
            // saveDatabase
            // 
            this.saveDatabase.Location = new System.Drawing.Point(658, 344);
            this.saveDatabase.Name = "saveDatabase";
            this.saveDatabase.Size = new System.Drawing.Size(137, 34);
            this.saveDatabase.TabIndex = 26;
            this.saveDatabase.Text = "Save Database";
            this.saveDatabase.UseVisualStyleBackColor = true;
            this.saveDatabase.Click += new System.EventHandler(this.saveDatabase_Click);
            // 
            // categoryList
            // 
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Items.AddRange(new object[] {
            "Internal Equiries",
            "External Equiries",
            "Training",
            "Team Events",
            "Planning"});
            this.categoryList.Location = new System.Drawing.Point(23, 188);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(236, 24);
            this.categoryList.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Job Date:";
            // 
            // jobDate
            // 
            this.jobDate.CustomFormat = "dd/MM/yyyy";
            this.jobDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.jobDate.Location = new System.Drawing.Point(23, 118);
            this.jobDate.Name = "jobDate";
            this.jobDate.Size = new System.Drawing.Size(236, 22);
            this.jobDate.TabIndex = 23;
            // 
            // closeDatabase
            // 
            this.closeDatabase.Location = new System.Drawing.Point(658, 384);
            this.closeDatabase.Name = "closeDatabase";
            this.closeDatabase.Size = new System.Drawing.Size(137, 34);
            this.closeDatabase.TabIndex = 22;
            this.closeDatabase.Text = "Close Database";
            this.closeDatabase.UseVisualStyleBackColor = true;
            this.closeDatabase.Click += new System.EventHandler(this.closeDatabase_Click);
            // 
            // openDatabase
            // 
            this.openDatabase.Location = new System.Drawing.Point(658, 304);
            this.openDatabase.Name = "openDatabase";
            this.openDatabase.Size = new System.Drawing.Size(137, 34);
            this.openDatabase.TabIndex = 21;
            this.openDatabase.Text = "Open Database";
            this.openDatabase.UseVisualStyleBackColor = true;
            this.openDatabase.Click += new System.EventHandler(this.openDatabase_Click);
            // 
            // newDatabase
            // 
            this.newDatabase.Location = new System.Drawing.Point(658, 264);
            this.newDatabase.Name = "newDatabase";
            this.newDatabase.Size = new System.Drawing.Size(137, 34);
            this.newDatabase.TabIndex = 20;
            this.newDatabase.Text = "New Database";
            this.newDatabase.UseVisualStyleBackColor = true;
            this.newDatabase.Click += new System.EventHandler(this.NewDatabase_Click);
            // 
            // breakEnd1
            // 
            this.breakEnd1.Location = new System.Drawing.Point(603, 123);
            this.breakEnd1.Name = "breakEnd1";
            this.breakEnd1.Size = new System.Drawing.Size(154, 22);
            this.breakEnd1.TabIndex = 15;
            this.breakEnd1.Leave += new System.EventHandler(this.jobTimeCalculation);
            // 
            // breakStart1
            // 
            this.breakStart1.Location = new System.Drawing.Point(373, 123);
            this.breakStart1.Name = "breakStart1";
            this.breakStart1.Size = new System.Drawing.Size(167, 22);
            this.breakStart1.TabIndex = 14;
            this.breakStart1.Leave += new System.EventHandler(this.jobTimeCalculation);
            // 
            // breakEndTime1
            // 
            this.breakEndTime1.AutoSize = true;
            this.breakEndTime1.Location = new System.Drawing.Point(600, 96);
            this.breakEndTime1.Name = "breakEndTime1";
            this.breakEndTime1.Size = new System.Drawing.Size(188, 16);
            this.breakEndTime1.TabIndex = 13;
            this.breakEndTime1.Text = "Break End Time: (in 24-hr time)";
            // 
            // breakStartTime1
            // 
            this.breakStartTime1.AutoSize = true;
            this.breakStartTime1.Location = new System.Drawing.Point(370, 96);
            this.breakStartTime1.Name = "breakStartTime1";
            this.breakStartTime1.Size = new System.Drawing.Size(191, 16);
            this.breakStartTime1.TabIndex = 12;
            this.breakStartTime1.Text = "Break Start Time: (in 24-hr time)";
            this.breakStartTime1.Click += new System.EventHandler(this.Label3_Click);
            // 
            // submitEntry
            // 
            this.submitEntry.Location = new System.Drawing.Point(658, 445);
            this.submitEntry.Name = "submitEntry";
            this.submitEntry.Size = new System.Drawing.Size(137, 34);
            this.submitEntry.TabIndex = 11;
            this.submitEntry.Text = "Submit Entry";
            this.submitEntry.UseVisualStyleBackColor = true;
            this.submitEntry.Click += new System.EventHandler(this.submitEntry_Click);
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(23, 264);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(577, 215);
            this.commentBox.TabIndex = 10;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(17, 237);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(74, 16);
            this.commentLabel.TabIndex = 9;
            this.commentLabel.Text = "Comments:";
            // 
            // timeCompleted1
            // 
            this.timeCompleted1.Location = new System.Drawing.Point(603, 57);
            this.timeCompleted1.Name = "timeCompleted1";
            this.timeCompleted1.Size = new System.Drawing.Size(154, 22);
            this.timeCompleted1.TabIndex = 7;
            this.timeCompleted1.Leave += new System.EventHandler(this.jobTimeCalculation);
            // 
            // startTime1
            // 
            this.startTime1.Location = new System.Drawing.Point(373, 57);
            this.startTime1.Name = "startTime1";
            this.startTime1.Size = new System.Drawing.Size(167, 22);
            this.startTime1.TabIndex = 6;
            this.startTime1.Leave += new System.EventHandler(this.jobTimeCalculation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time Completed: (in 24-hr time)";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(370, 30);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(152, 16);
            this.startTimeLabel.TabIndex = 4;
            this.startTimeLabel.Text = "Start Time: (in 24-hr time)";
            this.startTimeLabel.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // jobCategoryLabel
            // 
            this.jobCategoryLabel.AutoSize = true;
            this.jobCategoryLabel.Location = new System.Drawing.Point(20, 157);
            this.jobCategoryLabel.Name = "jobCategoryLabel";
            this.jobCategoryLabel.Size = new System.Drawing.Size(65, 16);
            this.jobCategoryLabel.TabIndex = 2;
            this.jobCategoryLabel.Text = "Category:";
            // 
            // jobName
            // 
            this.jobName.Location = new System.Drawing.Point(23, 57);
            this.jobName.Name = "jobName";
            this.jobName.Size = new System.Drawing.Size(236, 22);
            this.jobName.TabIndex = 1;
            // 
            // jobNameLabel
            // 
            this.jobNameLabel.AutoSize = true;
            this.jobNameLabel.Location = new System.Drawing.Point(20, 27);
            this.jobNameLabel.Name = "jobNameLabel";
            this.jobNameLabel.Size = new System.Drawing.Size(73, 16);
            this.jobNameLabel.TabIndex = 0;
            this.jobNameLabel.Text = "Job Name:";
            this.jobNameLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // completedJobs
            // 
            this.completedJobs.Controls.Add(this.Print);
            this.completedJobs.Controls.Add(this.PrintSetup);
            this.completedJobs.Controls.Add(this.completedSearch);
            this.completedJobs.Controls.Add(this.label6);
            this.completedJobs.Controls.Add(this.label5);
            this.completedJobs.Controls.Add(this.completedEnd);
            this.completedJobs.Controls.Add(this.completedStart);
            this.completedJobs.Controls.Add(this.completedJobsList);
            this.completedJobs.Location = new System.Drawing.Point(4, 25);
            this.completedJobs.Name = "completedJobs";
            this.completedJobs.Padding = new System.Windows.Forms.Padding(3);
            this.completedJobs.Size = new System.Drawing.Size(846, 496);
            this.completedJobs.TabIndex = 1;
            this.completedJobs.Text = "Completed Jobs";
            this.completedJobs.UseVisualStyleBackColor = true;
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(697, 51);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(125, 27);
            this.Print.TabIndex = 7;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // PrintSetup
            // 
            this.PrintSetup.Location = new System.Drawing.Point(697, 18);
            this.PrintSetup.Name = "PrintSetup";
            this.PrintSetup.Size = new System.Drawing.Size(125, 27);
            this.PrintSetup.TabIndex = 6;
            this.PrintSetup.Text = "Print Setup";
            this.PrintSetup.UseVisualStyleBackColor = true;
            this.PrintSetup.Click += new System.EventHandler(this.PrintSetup_Click);
            // 
            // completedSearch
            // 
            this.completedSearch.Location = new System.Drawing.Point(701, 422);
            this.completedSearch.Name = "completedSearch";
            this.completedSearch.Size = new System.Drawing.Size(133, 36);
            this.completedSearch.TabIndex = 5;
            this.completedSearch.Text = "Search";
            this.completedSearch.UseVisualStyleBackColor = true;
            this.completedSearch.Click += new System.EventHandler(this.completedSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(701, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "End Period:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(698, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Start Period:";
            // 
            // completedEnd
            // 
            this.completedEnd.CustomFormat = "dd/MM/yyyy";
            this.completedEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.completedEnd.Location = new System.Drawing.Point(701, 357);
            this.completedEnd.Name = "completedEnd";
            this.completedEnd.Size = new System.Drawing.Size(121, 22);
            this.completedEnd.TabIndex = 2;
            // 
            // completedStart
            // 
            this.completedStart.CustomFormat = "dd/MM/yyyy";
            this.completedStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.completedStart.Location = new System.Drawing.Point(701, 293);
            this.completedStart.Name = "completedStart";
            this.completedStart.Size = new System.Drawing.Size(121, 22);
            this.completedStart.TabIndex = 1;
            // 
            // completedJobsList
            // 
            this.completedJobsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listJobDate,
            this.listJobEntry,
            this.listCategory,
            this.listStartTime,
            this.listTimeCompleted,
            this.listBreakTime,
            this.listComments});
            this.completedJobsList.HideSelection = false;
            this.completedJobsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.completedJobsList.Location = new System.Drawing.Point(19, 18);
            this.completedJobsList.Name = "completedJobsList";
            this.completedJobsList.Size = new System.Drawing.Size(661, 451);
            this.completedJobsList.TabIndex = 0;
            this.completedJobsList.UseCompatibleStateImageBehavior = false;
            this.completedJobsList.View = System.Windows.Forms.View.Details;
            // 
            // listJobDate
            // 
            this.listJobDate.Text = "Job Date";
            this.listJobDate.Width = 80;
            // 
            // listJobEntry
            // 
            this.listJobEntry.Text = "Job Entry";
            this.listJobEntry.Width = 120;
            // 
            // listCategory
            // 
            this.listCategory.Text = "Category";
            this.listCategory.Width = 100;
            // 
            // listStartTime
            // 
            this.listStartTime.Text = "Start Time";
            this.listStartTime.Width = 100;
            // 
            // listTimeCompleted
            // 
            this.listTimeCompleted.Text = "Time Completed";
            this.listTimeCompleted.Width = 100;
            // 
            // listBreakTime
            // 
            this.listBreakTime.Text = "Break Time";
            this.listBreakTime.Width = 100;
            // 
            // listComments
            // 
            this.listComments.Text = "Comments";
            this.listComments.Width = 120;
            // 
            // billing
            // 
            this.billing.Controls.Add(this.listView1);
            this.billing.Controls.Add(this.billingSearch);
            this.billing.Controls.Add(this.billingEnd);
            this.billing.Controls.Add(this.billingStart);
            this.billing.Controls.Add(this.label4);
            this.billing.Controls.Add(this.label3);
            this.billing.Location = new System.Drawing.Point(4, 25);
            this.billing.Name = "billing";
            this.billing.Size = new System.Drawing.Size(846, 496);
            this.billing.TabIndex = 2;
            this.billing.Text = "Billing";
            this.billing.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(37, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(624, 459);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // billingSearch
            // 
            this.billingSearch.Location = new System.Drawing.Point(670, 178);
            this.billingSearch.Name = "billingSearch";
            this.billingSearch.Size = new System.Drawing.Size(144, 32);
            this.billingSearch.TabIndex = 4;
            this.billingSearch.Text = "Search";
            this.billingSearch.UseVisualStyleBackColor = true;
            // 
            // billingEnd
            // 
            this.billingEnd.CustomFormat = "dd/MM/yyyy";
            this.billingEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.billingEnd.Location = new System.Drawing.Point(670, 100);
            this.billingEnd.Name = "billingEnd";
            this.billingEnd.Size = new System.Drawing.Size(158, 22);
            this.billingEnd.TabIndex = 3;
            // 
            // billingStart
            // 
            this.billingStart.CustomFormat = "dd/MM/yyyy";
            this.billingStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.billingStart.Location = new System.Drawing.Point(670, 38);
            this.billingStart.Name = "billingStart";
            this.billingStart.Size = new System.Drawing.Size(161, 22);
            this.billingStart.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "End Period:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Start Period:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // POSService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 568);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "POSService";
            this.Text = "Timesheet";
            this.tabControl1.ResumeLayout(false);
            this.jobEntry.ResumeLayout(false);
            this.jobEntry.PerformLayout();
            this.completedJobs.ResumeLayout(false);
            this.completedJobs.PerformLayout();
            this.billing.ResumeLayout(false);
            this.billing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage jobEntry;
        private System.Windows.Forms.Label jobNameLabel;
        private System.Windows.Forms.TabPage completedJobs;
        private System.Windows.Forms.TabPage billing;
        private System.Windows.Forms.TextBox jobName;
        private System.Windows.Forms.Label jobCategoryLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.TextBox timeCompleted1;
        private System.Windows.Forms.TextBox startTime1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitEntry;
        private System.Windows.Forms.TextBox breakEnd1;
        private System.Windows.Forms.TextBox breakStart1;
        private System.Windows.Forms.Label breakEndTime1;
        private System.Windows.Forms.Label breakStartTime1;
        private System.Windows.Forms.Button closeDatabase;
        private System.Windows.Forms.Button openDatabase;
        private System.Windows.Forms.Button newDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker jobDate;
        private System.Windows.Forms.Button billingSearch;
        private System.Windows.Forms.DateTimePicker billingEnd;
        private System.Windows.Forms.DateTimePicker billingStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoryList;
        private System.Windows.Forms.ListView completedJobsList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader listJobDate;
        private System.Windows.Forms.ColumnHeader listCategory;
        private System.Windows.Forms.ColumnHeader listJobEntry;
        private System.Windows.Forms.ColumnHeader listStartTime;
        private System.Windows.Forms.ColumnHeader listTimeCompleted;
        private System.Windows.Forms.ColumnHeader listBreakTime;
        private System.Windows.Forms.ColumnHeader listComments;
        private System.Windows.Forms.Button completedSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker completedEnd;
        private System.Windows.Forms.DateTimePicker completedStart;
        private System.Windows.Forms.Button saveDatabase;
        private System.Windows.Forms.Button PrintSetup;
        private System.Windows.Forms.Button Print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

