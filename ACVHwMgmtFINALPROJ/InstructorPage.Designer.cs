namespace ACVHwMgmtFINALPROJ
{
    partial class InstructorPage
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label14 = new Label();
            label9 = new Label();
            btnSave = new Button();
            nudMaxPoints = new NumericUpDown();
            dtpDueDate = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBoxAssignDesc = new TextBox();
            textBoxAssignTitle = new TextBox();
            btnDelete = new Button();
            btnInfo = new Button();
            btnCreate = new Button();
            listBoxAssignments = new ListBox();
            comboBoxCourses = new ComboBox();
            tabPage2 = new TabPage();
            infoButton = new Button();
            listBoxSubmissions = new ListBox();
            btnSaveGF = new Button();
            textBoxFeedback = new TextBox();
            label11 = new Label();
            label10 = new Label();
            nudGrade = new NumericUpDown();
            tabPage3 = new TabPage();
            groupBox2 = new GroupBox();
            dataGridReport = new DataGridView();
            btnGenerateReport = new Button();
            btnExportReportCSV = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSaveUser = new Button();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnNewUser = new Button();
            btnUpgrade = new Button();
            dataGridStudents = new DataGridView();
            welcomeLabel = new Label();
            saveReportCSV = new SaveFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxPoints).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGrade).BeginInit();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReport).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStudents).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 68);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(870, 424);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(nudMaxPoints);
            tabPage1.Controls.Add(dtpDueDate);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBoxAssignDesc);
            tabPage1.Controls.Add(textBoxAssignTitle);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnInfo);
            tabPage1.Controls.Add(btnCreate);
            tabPage1.Controls.Add(listBoxAssignments);
            tabPage1.Controls.Add(comboBoxCourses);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(862, 391);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Assignment Management";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(672, 320);
            label14.Name = "label14";
            label14.Size = new Size(80, 20);
            label14.TabIndex = 14;
            label14.Text = "Max Points";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(510, 285);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 13;
            label9.Text = "Due Date";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(742, 350);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nudMaxPoints
            // 
            nudMaxPoints.Location = new Point(763, 318);
            nudMaxPoints.Name = "nudMaxPoints";
            nudMaxPoints.Size = new Size(73, 27);
            nudMaxPoints.TabIndex = 11;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(584, 282);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(250, 27);
            dtpDueDate.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(499, 161);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 9;
            label8.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(544, 124);
            label7.Name = "label7";
            label7.Size = new Size(38, 20);
            label7.TabIndex = 8;
            label7.Text = "Title";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(505, 19);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 7;
            label6.Text = "Instructor Courses";
            // 
            // textBoxAssignDesc
            // 
            textBoxAssignDesc.Location = new Point(590, 161);
            textBoxAssignDesc.Multiline = true;
            textBoxAssignDesc.Name = "textBoxAssignDesc";
            textBoxAssignDesc.Size = new Size(244, 115);
            textBoxAssignDesc.TabIndex = 6;
            // 
            // textBoxAssignTitle
            // 
            textBoxAssignTitle.Location = new Point(590, 121);
            textBoxAssignTitle.Name = "textBoxAssignTitle";
            textBoxAssignTitle.Size = new Size(244, 27);
            textBoxAssignTitle.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(742, 66);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(640, 66);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(94, 29);
            btnInfo.TabIndex = 3;
            btnInfo.Text = "Info";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(540, 66);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // listBoxAssignments
            // 
            listBoxAssignments.FormattingEnabled = true;
            listBoxAssignments.Location = new Point(29, 31);
            listBoxAssignments.Name = "listBoxAssignments";
            listBoxAssignments.Size = new Size(398, 324);
            listBoxAssignments.TabIndex = 1;
            // 
            // comboBoxCourses
            // 
            comboBoxCourses.FormattingEnabled = true;
            comboBoxCourses.Location = new Point(640, 16);
            comboBoxCourses.Name = "comboBoxCourses";
            comboBoxCourses.Size = new Size(151, 28);
            comboBoxCourses.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(infoButton);
            tabPage2.Controls.Add(listBoxSubmissions);
            tabPage2.Controls.Add(btnSaveGF);
            tabPage2.Controls.Add(textBoxFeedback);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(nudGrade);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(862, 391);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Submission Review & Grading";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // infoButton
            // 
            infoButton.Location = new Point(444, 20);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(111, 40);
            infoButton.TabIndex = 8;
            infoButton.Text = "Info";
            infoButton.UseVisualStyleBackColor = true;
            infoButton.Click += infoButton_Click;
            // 
            // listBoxSubmissions
            // 
            listBoxSubmissions.FormattingEnabled = true;
            listBoxSubmissions.Location = new Point(11, 20);
            listBoxSubmissions.Name = "listBoxSubmissions";
            listBoxSubmissions.Size = new Size(427, 364);
            listBoxSubmissions.TabIndex = 7;
            // 
            // btnSaveGF
            // 
            btnSaveGF.Location = new Point(711, 262);
            btnSaveGF.Name = "btnSaveGF";
            btnSaveGF.Size = new Size(117, 40);
            btnSaveGF.TabIndex = 6;
            btnSaveGF.Text = "Add Grade";
            btnSaveGF.UseVisualStyleBackColor = true;
            btnSaveGF.Click += btnSaveGF_Click;
            // 
            // textBoxFeedback
            // 
            textBoxFeedback.Location = new Point(546, 93);
            textBoxFeedback.Multiline = true;
            textBoxFeedback.Name = "textBoxFeedback";
            textBoxFeedback.Size = new Size(288, 152);
            textBoxFeedback.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(468, 96);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 4;
            label11.Text = "Feedback";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(669, 57);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 3;
            label10.Text = "Grade";
            // 
            // nudGrade
            // 
            nudGrade.Location = new Point(724, 54);
            nudGrade.Name = "nudGrade";
            nudGrade.Size = new Size(92, 27);
            nudGrade.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(862, 391);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Grade Export & Reports";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridReport);
            groupBox2.Controls.Add(btnGenerateReport);
            groupBox2.Controls.Add(btnExportReportCSV);
            groupBox2.Location = new Point(11, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(835, 341);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Export Options";
            // 
            // dataGridReport
            // 
            dataGridReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReport.Location = new Point(288, 36);
            dataGridReport.Name = "dataGridReport";
            dataGridReport.RowHeadersWidth = 51;
            dataGridReport.Size = new Size(529, 287);
            dataGridReport.TabIndex = 8;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(21, 69);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(226, 111);
            btnGenerateReport.TabIndex = 1;
            btnGenerateReport.Text = "Generate Grade Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnExportReportCSV
            // 
            btnExportReportCSV.Location = new Point(21, 190);
            btnExportReportCSV.Name = "btnExportReportCSV";
            btnExportReportCSV.Size = new Size(226, 115);
            btnExportReportCSV.TabIndex = 0;
            btnExportReportCSV.Text = "Export Report to CSV";
            btnExportReportCSV.UseVisualStyleBackColor = true;
            btnExportReportCSV.Click += btnExportReportCSV_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSaveUser);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnNewUser);
            groupBox1.Controls.Add(btnUpgrade);
            groupBox1.Controls.Add(dataGridStudents);
            groupBox1.Location = new Point(12, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(829, 336);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "User";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(590, 249);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 11;
            label5.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(585, 215);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(609, 182);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(606, 149);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // btnSaveUser
            // 
            btnSaveUser.Location = new Point(719, 290);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(94, 29);
            btnSaveUser.TabIndex = 7;
            btnSaveUser.Text = "Save User";
            btnSaveUser.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(635, 245);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(661, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(661, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(661, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // btnNewUser
            // 
            btnNewUser.Location = new Point(605, 95);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(170, 29);
            btnNewUser.TabIndex = 2;
            btnNewUser.Text = "Create New User";
            btnNewUser.UseVisualStyleBackColor = true;
            // 
            // btnUpgrade
            // 
            btnUpgrade.Enabled = false;
            btnUpgrade.Location = new Point(605, 59);
            btnUpgrade.Name = "btnUpgrade";
            btnUpgrade.Size = new Size(170, 30);
            btnUpgrade.TabIndex = 1;
            btnUpgrade.Text = "Upgrade to Instructor";
            btnUpgrade.UseVisualStyleBackColor = true;
            // 
            // dataGridStudents
            // 
            dataGridStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStudents.Location = new Point(24, 48);
            dataGridStudents.Name = "dataGridStudents";
            dataGridStudents.RowHeadersWidth = 51;
            dataGridStudents.Size = new Size(544, 271);
            dataGridStudents.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(12, 9);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(295, 38);
            welcomeLabel.TabIndex = 13;
            welcomeLabel.Text = "Hello *Instructor*! :D";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveReportCSV
            // 
            saveReportCSV.FileOk += saveReportCSV_FileOk;
            // 
            // InstructorPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 521);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Controls.Add(welcomeLabel);
            Name = "InstructorPage";
            Text = "Form4";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxPoints).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGrade).EndInit();
            tabPage3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridReport).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox listBoxAssignments;
        private ComboBox comboBoxCourses;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSaveUser;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnNewUser;
        private Button btnUpgrade;
        private DataGridView dataGridStudents;
        private Label welcomeLabel;
        private Button btnDelete;
        private Button btnInfo;
        private Button btnCreate;
        private Label label6;
        private TextBox textBoxAssignDesc;
        private TextBox textBoxAssignTitle;
        private DateTimePicker dtpDueDate;
        private Label label8;
        private Label label7;
        private Label label14;
        private Label label9;
        private Button btnSave;
        private NumericUpDown nudMaxPoints;
        private Label label10;
        private NumericUpDown nudGrade;
        private Button btnSaveGF;
        private TextBox textBoxFeedback;
        private Label label11;
        private GroupBox groupBox2;
        private Button btnGenerateReport;
        private Button btnExportReportCSV;
        private ListBox listBoxSubmissions;
        private Button infoButton;
        private SaveFileDialog saveReportCSV;
        private DataGridView dataGridReport;
    }
}