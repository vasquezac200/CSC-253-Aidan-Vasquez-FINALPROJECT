namespace ACVHwMgmtFINALPROJ
{
    partial class StudentPage
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
            welcomeLabel = new Label();
            listBoxEnrollCourses = new ListBox();
            listBoxAssignments = new ListBox();
            groupBox1 = new GroupBox();
            tabControl2 = new TabControl();
            tabPage2 = new TabPage();
            btnInfoEn = new Button();
            tabPage3 = new TabPage();
            btnInfoAv = new Button();
            listBoxAvalCourses = new ListBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            label5 = new Label();
            dtpFilterByDueDate2 = new DateTimePicker();
            dtpFilterByDueDate1 = new DateTimePicker();
            label4 = new Label();
            label1 = new Label();
            cbFilterByCourse = new ComboBox();
            filterButton = new Button();
            infoButton = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtSubmit = new TextBox();
            File = new TabPage();
            browseBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            btnSubmit = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            File.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(31, 22);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(269, 38);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Hello *Student*! :D";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBoxEnrollCourses
            // 
            listBoxEnrollCourses.FormattingEnabled = true;
            listBoxEnrollCourses.Location = new Point(0, 0);
            listBoxEnrollCourses.Name = "listBoxEnrollCourses";
            listBoxEnrollCourses.Size = new Size(266, 164);
            listBoxEnrollCourses.TabIndex = 1;
            // 
            // listBoxAssignments
            // 
            listBoxAssignments.FormattingEnabled = true;
            listBoxAssignments.Location = new Point(25, 24);
            listBoxAssignments.Name = "listBoxAssignments";
            listBoxAssignments.Size = new Size(200, 264);
            listBoxAssignments.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl2);
            groupBox1.Location = new Point(31, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 259);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Courses";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Location = new Point(19, 27);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(274, 226);
            tabControl2.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnInfoEn);
            tabPage2.Controls.Add(listBoxEnrollCourses);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(266, 193);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Enrolled";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInfoEn
            // 
            btnInfoEn.Location = new Point(79, 164);
            btnInfoEn.Name = "btnInfoEn";
            btnInfoEn.Size = new Size(94, 29);
            btnInfoEn.TabIndex = 2;
            btnInfoEn.Text = "Info";
            btnInfoEn.UseVisualStyleBackColor = true;
            btnInfoEn.Click += btnInfoEn_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnInfoAv);
            tabPage3.Controls.Add(listBoxAvalCourses);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(266, 193);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Available";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnInfoAv
            // 
            btnInfoAv.Location = new Point(79, 164);
            btnInfoAv.Name = "btnInfoAv";
            btnInfoAv.Size = new Size(94, 29);
            btnInfoAv.TabIndex = 3;
            btnInfoAv.Text = "Info";
            btnInfoAv.UseVisualStyleBackColor = true;
            btnInfoAv.Click += btnInfoAv_Click;
            // 
            // listBoxAvalCourses
            // 
            listBoxAvalCourses.FormattingEnabled = true;
            listBoxAvalCourses.Location = new Point(0, 0);
            listBoxAvalCourses.Name = "listBoxAvalCourses";
            listBoxAvalCourses.Size = new Size(266, 164);
            listBoxAvalCourses.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(infoButton);
            groupBox2.Controls.Add(listBoxAssignments);
            groupBox2.Location = new Point(374, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(415, 300);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Assignments";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(dtpFilterByDueDate2);
            groupBox4.Controls.Add(dtpFilterByDueDate1);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(cbFilterByCourse);
            groupBox4.Controls.Add(filterButton);
            groupBox4.Location = new Point(237, 59);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(172, 229);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Filter";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 138);
            label5.Name = "label5";
            label5.Size = new Size(23, 20);
            label5.TabIndex = 12;
            label5.Text = "to";
            // 
            // dtpFilterByDueDate2
            // 
            dtpFilterByDueDate2.Format = DateTimePickerFormat.Short;
            dtpFilterByDueDate2.Location = new Point(6, 161);
            dtpFilterByDueDate2.Name = "dtpFilterByDueDate2";
            dtpFilterByDueDate2.Size = new Size(151, 27);
            dtpFilterByDueDate2.TabIndex = 11;
            // 
            // dtpFilterByDueDate1
            // 
            dtpFilterByDueDate1.Format = DateTimePickerFormat.Short;
            dtpFilterByDueDate1.Location = new Point(6, 110);
            dtpFilterByDueDate1.Name = "dtpFilterByDueDate1";
            dtpFilterByDueDate1.Size = new Size(151, 27);
            dtpFilterByDueDate1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 87);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 9;
            label4.Text = "Due Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 8;
            label1.Text = "Course";
            // 
            // cbFilterByCourse
            // 
            cbFilterByCourse.FormattingEnabled = true;
            cbFilterByCourse.Location = new Point(6, 51);
            cbFilterByCourse.Name = "cbFilterByCourse";
            cbFilterByCourse.Size = new Size(151, 28);
            cbFilterByCourse.TabIndex = 7;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(6, 194);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(151, 29);
            filterButton.TabIndex = 6;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // infoButton
            // 
            infoButton.Location = new Point(231, 24);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(94, 29);
            infoButton.TabIndex = 5;
            infoButton.Text = "Info";
            infoButton.UseVisualStyleBackColor = true;
            infoButton.Click += infoButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(File);
            tabControl1.Location = new Point(17, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(356, 232);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtSubmit);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(348, 199);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Text";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSubmit
            // 
            txtSubmit.Location = new Point(6, 6);
            txtSubmit.Multiline = true;
            txtSubmit.Name = "txtSubmit";
            txtSubmit.Size = new Size(339, 187);
            txtSubmit.TabIndex = 0;
            // 
            // File
            // 
            File.Controls.Add(browseBtn);
            File.Controls.Add(label2);
            File.Controls.Add(label3);
            File.Location = new Point(4, 29);
            File.Name = "File";
            File.Padding = new Padding(3);
            File.Size = new Size(348, 199);
            File.TabIndex = 1;
            File.Text = "File";
            File.UseVisualStyleBackColor = true;
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(214, 43);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(94, 29);
            browseBtn.TabIndex = 9;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 96);
            label2.Name = "label2";
            label2.Size = new Size(279, 100);
            label2.TabIndex = 8;
            label2.Text = "Notes:\r\n  • Only one submission per assignment.  \r\n  • Submission timestamp stored.\r\n  • Make sure the text box on the text tab\r\n     is empty when submitting with file.\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 47);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 0;
            label3.Text = "*File Name*";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(379, 227);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tabControl1);
            groupBox3.Controls.Add(btnSubmit);
            groupBox3.Location = new Point(154, 363);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(504, 266);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Homework Submission";
            // 
            // StudentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 641);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(welcomeLabel);
            Name = "StudentPage";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            File.ResumeLayout(false);
            File.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private ListBox listBoxEnrollCourses;
        private ListBox listBoxAssignments;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage File;
        private Button filterButton;
        private Button infoButton;
        private TabControl tabControl2;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListBox listBoxAvalCourses;
        private Label label2;
        private TextBox txtSubmit;
        private Label label3;
        private Button browseBtn;
        private Button btnSubmit;
        private GroupBox groupBox3;
        private ComboBox cbFilterByCourse;
        private Button btnInfoEn;
        private Button btnInfoAv;
        private GroupBox groupBox4;
        private DateTimePicker dtpFilterByDueDate1;
        private Label label4;
        private Label label1;
        private Label label5;
        private DateTimePicker dtpFilterByDueDate2;
    }
}