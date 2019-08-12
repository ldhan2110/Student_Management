namespace Student_Management.UI
{
    partial class GiaoVu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbfile = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClassCoursesRB = new System.Windows.Forms.RadioButton();
            this.ScoreRB = new System.Windows.Forms.RadioButton();
            this.ScheduleRB = new System.Windows.Forms.RadioButton();
            this.ClassRB = new System.Windows.Forms.RadioButton();
            this.cbtable = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView.ContextMenuStrip = this.contextMenuStrip1;
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(13, 60);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(434, 239);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MSSV";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 159;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gender";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CMND";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 70;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.analyzeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 114);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Enabled = false;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // analyzeToolStripMenuItem
            // 
            this.analyzeToolStripMenuItem.Enabled = false;
            this.analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            this.analyzeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.analyzeToolStripMenuItem.Text = "Analyze";
            this.analyzeToolStripMenuItem.Click += new System.EventHandler(this.analyzeToolStripMenuItem_Click);
            // 
            // cbClass
            // 
            this.cbClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(13, 28);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(125, 21);
            this.cbClass.TabIndex = 2;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbfile
            // 
            this.tbfile.Location = new System.Drawing.Point(13, 305);
            this.tbfile.Name = "tbfile";
            this.tbfile.Size = new System.Drawing.Size(272, 20);
            this.tbfile.TabIndex = 4;
            this.tbfile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbfile_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClassCoursesRB);
            this.panel1.Controls.Add(this.ScoreRB);
            this.panel1.Controls.Add(this.ScheduleRB);
            this.panel1.Controls.Add(this.ClassRB);
            this.panel1.Location = new System.Drawing.Point(144, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 26);
            this.panel1.TabIndex = 5;
            // 
            // ClassCoursesRB
            // 
            this.ClassCoursesRB.AutoSize = true;
            this.ClassCoursesRB.Location = new System.Drawing.Point(136, 6);
            this.ClassCoursesRB.Name = "ClassCoursesRB";
            this.ClassCoursesRB.Size = new System.Drawing.Size(86, 17);
            this.ClassCoursesRB.TabIndex = 3;
            this.ClassCoursesRB.TabStop = true;
            this.ClassCoursesRB.Text = "Class Course";
            this.ClassCoursesRB.UseVisualStyleBackColor = true;
            this.ClassCoursesRB.CheckedChanged += new System.EventHandler(this.radiobutton4_CheckedChanged);
            // 
            // ScoreRB
            // 
            this.ScoreRB.AutoSize = true;
            this.ScoreRB.Location = new System.Drawing.Point(228, 5);
            this.ScoreRB.Name = "ScoreRB";
            this.ScoreRB.Size = new System.Drawing.Size(53, 17);
            this.ScoreRB.TabIndex = 2;
            this.ScoreRB.Text = "Score";
            this.ScoreRB.UseVisualStyleBackColor = true;
            this.ScoreRB.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // ScheduleRB
            // 
            this.ScheduleRB.AutoSize = true;
            this.ScheduleRB.Location = new System.Drawing.Point(60, 6);
            this.ScheduleRB.Name = "ScheduleRB";
            this.ScheduleRB.Size = new System.Drawing.Size(70, 17);
            this.ScheduleRB.TabIndex = 1;
            this.ScheduleRB.Text = "Schedule";
            this.ScheduleRB.UseVisualStyleBackColor = true;
            this.ScheduleRB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ClassRB
            // 
            this.ClassRB.AutoSize = true;
            this.ClassRB.Checked = true;
            this.ClassRB.Location = new System.Drawing.Point(4, 6);
            this.ClassRB.Name = "ClassRB";
            this.ClassRB.Size = new System.Drawing.Size(50, 17);
            this.ClassRB.TabIndex = 0;
            this.ClassRB.TabStop = true;
            this.ClassRB.Text = "Class";
            this.ClassRB.UseVisualStyleBackColor = true;
            this.ClassRB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cbtable
            // 
            this.cbtable.FormattingEnabled = true;
            this.cbtable.Items.AddRange(new object[] {
            "Students",
            "Courses",
            "Scores"});
            this.cbtable.Location = new System.Drawing.Point(291, 304);
            this.cbtable.Name = "cbtable";
            this.cbtable.Size = new System.Drawing.Size(77, 21);
            this.cbtable.TabIndex = 6;
            // 
            // GiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 331);
            this.Controls.Add(this.cbtable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbfile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GiaoVu";
            this.Text = "GiaoVu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbfile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ScoreRB;
        private System.Windows.Forms.RadioButton ScheduleRB;
        private System.Windows.Forms.RadioButton ClassRB;
        private System.Windows.Forms.ComboBox cbtable;
        private System.Windows.Forms.RadioButton ClassCoursesRB;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItem;
    }
}