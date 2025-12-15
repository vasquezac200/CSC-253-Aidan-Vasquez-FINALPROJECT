using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Quic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace ACVHwMgmtFINALPROJ
{
    public partial class InstructorPage : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=C:\Users\aidan\Downloads\ACVHwMgmtFINALPROJ\ACVHwMgmtFINALPROJ\Database1.mdf;
              Integrated Security=True;
              Connect Timeout=30;";

        private SqlConnection? conn;
        private SqlDataAdapter? AssignmentsAdapter;
        private SqlDataAdapter? checkAssignmentsAdapter;
        private SqlDataAdapter? InstructorAdapter;
        private SqlDataAdapter? CourseAdapter;
        private SqlDataAdapter? SubmitAdapter;
        private SqlDataAdapter? gradeAdapter;
        private SqlDataAdapter? studentAdapter;
        private DataTable? AssignmentTable;
        private DataTable? InstructorTable;
        private DataTable? CourseTable;
        private DataTable? SubmitTable;
        private DataTable? gradeTable;
        private DataTable? studentTable;
        private DataTable? reportTable;
        private BindingSource? AssignmentBindingSource;
        private BindingSource? StudentBindingSource;
        private BindingSource? CourseBindingSource;
        private BindingSource? SubmitBindingSource;
        private BindingSource? GradeBindingSource;

        int _id;
        string _name;
        string _username;
        string _password;
        public InstructorPage(string name, string username, string password)
        {
            InitializeComponent();
            this.Load += Form4_Load;

            _name = name;
            _username = username;
            _password = password;

            conn = new SqlConnection(cs);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = $"Hello {_name}! :D";

            string userKeyword = "%" + _username + "%";

            InstructorAdapter = new SqlDataAdapter("SELECT * FROM users WHERE username LIKE @userKeyword", conn);
            InstructorAdapter.SelectCommand.Parameters.AddWithValue("@userKeyword", userKeyword);

            InstructorTable = new DataTable();
            InstructorAdapter.Fill(InstructorTable);

            _id = Convert.ToInt32(InstructorTable.Rows[0]["id"]);

            CourseAdapter = new SqlDataAdapter("SELECT * FROM courses WHERE instructorID = @id", conn);
            CourseAdapter.SelectCommand.Parameters.AddWithValue("@id", _id);

            CourseTable = new DataTable();
            CourseAdapter.Fill(CourseTable);

            comboBoxCourses.Items.Clear();
            listBoxAssignments.Items.Clear();
            listBoxSubmissions.Items.Clear();

            foreach (DataRow row in CourseTable.Rows)
            {
                string thatCourse = row["courseTitle"].ToString();
                comboBoxCourses.Items.Add(thatCourse);

                AssignmentsAdapter = new SqlDataAdapter(
                    "SELECT a.assignmentID AS aID, a.title AS Assignment, a.description, a.dueDate, a.maxPoints " +
                    "FROM Assignments a " +
                    "JOIN courses c ON a.courseID = c.courseID " +
                    "WHERE c.courseTitle = @thatCourse", conn);

                AssignmentsAdapter.SelectCommand.Parameters.AddWithValue("@thatCourse", thatCourse);

                AssignmentTable = new DataTable();
                AssignmentsAdapter.Fill(AssignmentTable);

                foreach (DataRow row2 in AssignmentTable.Rows)
                {
                    listBoxAssignments.Items.Add(row2["Assignment"].ToString());
                }
            }

            SubmitAdapter = new SqlDataAdapter(
                "SELECT s.submissionID, u.name AS Student, a.title AS Assignment, s.timestamp " +
                "FROM submissions s " +
                "JOIN users u ON s.studentID = u.id " +
                "JOIN assignments a ON s.assignmentID = a.assignmentID " +
                "JOIN courses c ON a.courseID = c.courseID " +
                "WHERE c.instructorID = @id", conn);

            SubmitAdapter.SelectCommand.Parameters.AddWithValue("@id", _id);

            SubmitTable = new DataTable();
            SubmitAdapter.Fill(SubmitTable);

            foreach (DataRow r in SubmitTable.Rows)
            {
                listBoxSubmissions.Items.Add(r["submissionID"].ToString());
            }

            studentAdapter = new SqlDataAdapter("SELECT * FROM users WHERE role = 'Student'", conn);
            studentTable = new DataTable();
            studentAdapter.Fill(studentTable);

          
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            string courseKey = "%" + comboBoxCourses.Text + "%";
            string title = textBoxAssignTitle.Text;
            string description = textBoxAssignDesc.Text;
            DateTime dueDate = dtpDueDate.Value.Date;
            int maxPoints = (int)nudMaxPoints.Value;


            SqlDataAdapter checkCoursesAdapter = new SqlDataAdapter("SELECT courseID FROM courses WHERE courseTitle LIKE @courseKey", conn);

            checkCoursesAdapter.SelectCommand.Parameters.AddWithValue("@courseKey", courseKey);

            DataTable aTable = new DataTable();

            checkCoursesAdapter.Fill(aTable);

            listBoxAssignments.Items.Add(title);

            conn = new SqlConnection(cs);
            AssignmentsAdapter = new SqlDataAdapter("SELECT * FROM Assignments", conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(AssignmentsAdapter);
            AssignmentTable = new DataTable();
            conn.Open();
            AssignmentsAdapter.Fill(AssignmentTable);
            AssignmentBindingSource = new BindingSource();
            AssignmentBindingSource.DataSource = AssignmentTable;


            var newuser = AssignmentTable.NewRow();
            newuser["courseID"] = Convert.ToInt32(aTable.Rows[0]["courseID"]);
            newuser["title"] = title;
            newuser["description"] = description;
            newuser["dueDate"] = dueDate;
            newuser["maxPoints"] = maxPoints;

            AssignmentTable.Rows.Add(newuser);
            AssignmentsAdapter.Update(AssignmentTable);

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            object selectIndex = listBoxAssignments.SelectedItem;

            AssignmentTable = new DataTable();

            AssignmentsAdapter = new SqlDataAdapter("SELECT * FROM Assignments", conn);

            AssignmentsAdapter.Fill(AssignmentTable);

            if (selectIndex != null)
            {
                string name = selectIndex.ToString();



                DataRow[] rowsToUpdate = AssignmentTable.Select($"title = '{name}'");

                foreach (DataRow row in rowsToUpdate)
                {
                    MessageBox.Show($"Name: {row["title"]}\nDescription: {row["description"]}\nDue Date: {row["dueDate"]}\nMax Points: {row["maxPoints"]}");
                }

            }
            else
            {
                MessageBox.Show("Please Select a assignment from the listbox.");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            AssignmentsAdapter = new SqlDataAdapter("SELECT * FROM Assignments", conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(AssignmentsAdapter);
            AssignmentTable = new DataTable();
            conn.Open();
            AssignmentsAdapter.Fill(AssignmentTable);

            object selectIndex = listBoxAssignments.SelectedItem;


            if (selectIndex != null)
            {
                string name = selectIndex.ToString();
                DataRow[] rowsToDelete = AssignmentTable.Select($"title = '{name}'");

                foreach (DataRow row in rowsToDelete)
                {
                    row.Delete();
                }
                AssignmentsAdapter.Update(AssignmentTable);
                listBoxAssignments.Items.RemoveAt(listBoxAssignments.SelectedIndex);
                MessageBox.Show("Assignment Deleted Successfully!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string courseKey = "%" + comboBoxCourses.Text + "%";
            string title = textBoxAssignTitle.Text;
            string description = textBoxAssignDesc.Text;
            DateTime dueDate = dtpDueDate.Value.Date;
            int maxPoints = (int)nudMaxPoints.Value;

            SqlCommandBuilder builder = new SqlCommandBuilder(AssignmentsAdapter);


            object selectIndex = listBoxAssignments.SelectedItem;


            if (selectIndex != null)
            {
                string name = selectIndex.ToString();

                DataRow[] rowsToUpdate = AssignmentTable.Select($"title = '{name}'");

                foreach (DataRow row in rowsToUpdate)
                {
                    row["title"] = title;
                    row["description"] = description;
                    row["dueDate"] = dueDate;
                    row["maxPoints"] = maxPoints;
                }
                AssignmentsAdapter.Update(AssignmentTable);
                MessageBox.Show("Assignment Updated Successfully!");

            }
        }

        private void btnSaveGF_Click(object sender, EventArgs e)
        {
            if (listBoxSubmissions.SelectedItem == null)
            {
                MessageBox.Show("Please select a submission first.");
                return;
            }

            int submissionID = Convert.ToInt32(listBoxSubmissions.SelectedItem);
            int grade = (int)nudGrade.Value;
            string feedback = textBoxFeedback.Text;

            SubmitTable = new DataTable();
            SubmitAdapter = new SqlDataAdapter("SELECT * FROM submissions", conn);
            SubmitAdapter.Fill(SubmitTable);

            DataRow[] subRows = SubmitTable.Select($"submissionID = {submissionID}");

            if (subRows.Length == 0)
            {
                MessageBox.Show("Submission not found.");
                return;
            }

            int assignmentID = Convert.ToInt32(subRows[0]["assignmentID"]);

            AssignmentTable = new DataTable();
            AssignmentsAdapter = new SqlDataAdapter("SELECT * FROM Assignments", conn);
            AssignmentsAdapter.Fill(AssignmentTable);

            DataRow[] assignRows = AssignmentTable.Select($"assignmentID = {assignmentID}");

            if (assignRows.Length == 0)
            {
                MessageBox.Show("Assignment not found.");
                return;
            }

            int maxPoints = Convert.ToInt32(assignRows[0]["maxPoints"]);

            if (grade > maxPoints)
            {
                MessageBox.Show($"Grade cannot exceed max points ({maxPoints}).");
                return;
            }

            gradeAdapter = new SqlDataAdapter("SELECT * FROM grades", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(gradeAdapter);
            gradeTable = new DataTable();
            gradeAdapter.Fill(gradeTable);

            DataRow[] existing = gradeTable.Select($"submissionID = {submissionID}");

            if (existing.Length > 0)
            {
                existing[0]["grade"] = grade;
                existing[0]["feedback"] = feedback;
            }
            else
            {
                DataRow newgrade = gradeTable.NewRow();
                newgrade["submissionID"] = submissionID;
                newgrade["grade"] = grade;
                newgrade["feedback"] = feedback;
                gradeTable.Rows.Add(newgrade);
            }

            gradeAdapter.Update(gradeTable);
            MessageBox.Show("Grade saved successfully!");
        }


        private void infoButton_Click(object sender, EventArgs e)
        {
            object selectIndex = listBoxSubmissions.SelectedItem;

            SubmitTable = new DataTable();
            SubmitAdapter = new SqlDataAdapter("SELECT * FROM submissions", conn);
            SubmitAdapter.Fill(SubmitTable);

            AssignmentTable = new DataTable();
            AssignmentsAdapter = new SqlDataAdapter("SELECT * FROM Assignments", conn);
            AssignmentsAdapter.Fill(AssignmentTable);

            gradeTable = new DataTable();
            gradeAdapter = new SqlDataAdapter("SELECT * FROM grades", conn);
            gradeAdapter.Fill(gradeTable);

            if (selectIndex != null)
            {
                int submissionID = Convert.ToInt32(selectIndex);
                bool isGraded = false;
                string gradeText = "N/A";
                string feedbackText = "N/A";

                DataRow[] subRows = SubmitTable.Select($"submissionID = {submissionID}");

                if (subRows.Length == 0)
                {
                    MessageBox.Show("Submission not found.");
                    return;
                }

                int assignmentID = Convert.ToInt32(subRows[0]["assignmentID"]);

                DataRow[] assignRows = AssignmentTable.Select($"assignmentID = {assignmentID}");

                if (assignRows.Length == 0)
                {
                    MessageBox.Show("Assignment not found.");
                    return;
                }

                DataRow assignmentRow = assignRows[0];

                DataRow[] gradeRows = gradeTable.Select($"submissionID = {submissionID}");

                if (gradeRows.Length > 0)
                {
                    isGraded = true;
                    gradeText = gradeRows[0]["grade"].ToString();
                    feedbackText = gradeRows[0]["feedback"].ToString();
                }

                MessageBox.Show(
                    $"Name: {assignmentRow["title"]}\n" +
                    $"Description: {assignmentRow["description"]}\n" +
                    $"Due Date: {assignmentRow["dueDate"]}\n" +
                    $"Max Points: {assignmentRow["maxPoints"]}\n" +
                    $"Is Graded: {isGraded}\n" +
                    $"Grade: {gradeText}\n" +
                    $"Feedback: {feedbackText}"
                );
            }
            else
            {
                MessageBox.Show("Please select a submission first.");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            reportTable = new DataTable();
            gradeAdapter = new SqlDataAdapter("SELECT * FROM grades", conn);
            gradeAdapter.Fill(reportTable);
            dataGridReport.DataSource = reportTable;

        }

        private void btnExportReportCSV_Click(object sender, EventArgs e)
        {
           
                string instructor = _username;
                string today = DateTime.Now.ToString("yyyy-MM-dd");

                saveReportCSV.FileName = $"GradeReport{instructor}_{today}.csv";
                saveReportCSV.Filter = "CSV files (*.csv)|*.csv";
                saveReportCSV.DefaultExt = "csv";
                saveReportCSV.ShowDialog();
        
        }

        private void saveReportCSV_FileOk(object sender, CancelEventArgs e)
        {
            if (reportTable == null || reportTable.Rows.Count == 0)
            {
                MessageBox.Show("Generate the report first before exporting.");
                return;
            }

            using StreamWriter csvFile = new StreamWriter(saveReportCSV.FileName);

            for (int i = 0; i < reportTable.Columns.Count; i++)
            {
                csvFile.Write(reportTable.Columns[i].ColumnName);
                if (i < reportTable.Columns.Count - 1) csvFile.Write(",");
            }
            csvFile.WriteLine();

            foreach (DataRow row in reportTable.Rows)
            {
                for (int i = 0; i < reportTable.Columns.Count; i++)
                {
                    string value = row[i]?.ToString() ?? "";

                    if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
                        value = "\"" + value.Replace("\"", "\"\"") + "\"";

                    csvFile.Write(value);
                    if (i < reportTable.Columns.Count - 1) csvFile.Write(",");
                }
                csvFile.WriteLine();
            }

            MessageBox.Show("CSV Exported!");
        }

    }
}
