using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace ACVHwMgmtFINALPROJ
{
    public partial class StudentPage : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=C:\Users\aidan\Downloads\ACVHwMgmtFINALPROJ\ACVHwMgmtFINALPROJ\Database1.mdf;
              Integrated Security=True;
              Connect Timeout=30;";

        private SqlConnection? conn;
        private SqlDataAdapter? AssignmentsAdapter;
        private SqlDataAdapter? checkAssignmentsAdapter;
        private SqlDataAdapter? StudentAdapter;
        private SqlDataAdapter? CourseAdapter;
        private SqlDataAdapter? SubmitAdapter;
        private SqlDataAdapter? GradeAdapter;
        private SqlDataAdapter? CourseAdapter2;
        private DataTable? AssignmentTable;
        private DataTable? StudentTable;
        private DataTable? CourseTable;
        private DataTable? CourseTable2;
        private DataTable? SubmitTable;
        private DataTable? GradeTable;
        private BindingSource? AssignmentBindingSource;
        private BindingSource? StudentBindingSource;
        private BindingSource? CourseBindingSource;
        private BindingSource? SubmitBindingSource;
        private BindingSource? GradeBindingSource;

        int _id;
        string _name;
        string _username;
        string _password;

        public StudentPage(string name, string username, string password)
        {
            InitializeComponent();
            this.Load += Form2_Load;
            _name = name;
            _username = username;
            _password = password;
            using var conn = new SqlConnection(cs);
            conn.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = $"Hello {_name}! :D";
            conn = new SqlConnection(cs);
            string userKeyword = "%" + _username + "%";
            StudentAdapter = new SqlDataAdapter("SELECT * FROM users WHERE username LIKE @userKeyword", conn);
            StudentAdapter.SelectCommand.Parameters.AddWithValue("@userKeyword", userKeyword);



            StudentTable = new DataTable();
            StudentBindingSource = new BindingSource();

            StudentAdapter.Fill(StudentTable);

            foreach (DataRow row in StudentTable.Rows)
            {
                _id = Convert.ToInt32(row["id"]);
            }

            string idKeyword = "%" + _id + "%";



            AssignmentsAdapter = new SqlDataAdapter("SELECT e.enrollmentID, e.studentID, e.courseID, u.name AS Student, a.title AS Assignment, a.description, a.dueDate, a.maxPoints, e.dateEnrolled " +
                                                "FROM Enrollments e " +
                                                "JOIN users u ON e.studentID = u.id " +
                                                "JOIN Assignments a ON e.courseID = a.courseID " +
                                                "WHERE u.username LIKE @userKeyword", conn);

            CourseAdapter = new SqlDataAdapter("SELECT e.enrollmentID, e.studentID, e.courseID, u.name AS Student, c.courseTitle AS Course, c.instructorName, c.credits, c.startDate, c.endDate, e.dateEnrolled " +
                                                "FROM Enrollments e " +
                                                "JOIN users u ON e.studentID = u.id " +
                                                "JOIN courses c ON e.courseID = c.courseID " +
                                                "WHERE u.username LIKE @userKeyword", conn);

            CourseAdapter2 = new SqlDataAdapter("SELECT e.enrollmentID, e.studentID, e.courseID, u.name AS Student, c.courseTitle AS Course, c.instructorName, c.credits, c.startDate, c.endDate, e.dateEnrolled " +
                                                "FROM Enrollments e " +
                                                "JOIN users u ON e.studentID = u.id " +
                                                "JOIN courses c ON e.courseID = c.courseID " +
                                                "WHERE u.username NOT LIKE @userKeyword", conn);

            AssignmentsAdapter.SelectCommand.Parameters.AddWithValue("@userKeyword", userKeyword);
            CourseAdapter.SelectCommand.Parameters.AddWithValue("@userKeyword", userKeyword);
            CourseAdapter2.SelectCommand.Parameters.AddWithValue("@userKeyword", userKeyword);



            AssignmentTable = new DataTable();
            AssignmentBindingSource = new BindingSource();
            AssignmentsAdapter.Fill(AssignmentTable);


            CourseTable = new DataTable();
            CourseBindingSource = new BindingSource();
            CourseAdapter.Fill(CourseTable);

            CourseTable2 = new DataTable();
            CourseBindingSource = new BindingSource();
            CourseAdapter2.Fill(CourseTable2);



            listBoxAssignments.Items.Clear();

            foreach (DataRow row in AssignmentTable.Rows)
            {
                listBoxAssignments.Items.Add(row["Assignment"].ToString());
            }

            listBoxEnrollCourses.Items.Clear();
            foreach (DataRow row in CourseTable.Rows)
            {
                listBoxEnrollCourses.Items.Add(row["Course"].ToString());
            }

            listBoxAvalCourses.Items.Clear();
            foreach (DataRow row in CourseTable2.Rows)
            {
                listBoxAvalCourses.Items.Add(row["Course"].ToString());
            }

            cbFilterByCourse.Items.Clear();
            foreach (DataRow row in CourseTable.Rows)
            {
                cbFilterByCourse.Items.Add(row["Course"].ToString());
            }

        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            object selectIndex = listBoxAssignments.SelectedItem;

            SubmitTable = new DataTable();
            SubmitAdapter = new SqlDataAdapter("SELECT * FROM submissions", conn);
            SubmitAdapter.Fill(SubmitTable);

            GradeTable = new DataTable();
            GradeAdapter = new SqlDataAdapter("SELECT * FROM grades", conn);
            GradeAdapter.Fill(GradeTable);


            AssignmentTable = new DataTable();
            AssignmentsAdapter = new SqlDataAdapter("SELECT * FROM Assignments", conn);
            AssignmentsAdapter.Fill(AssignmentTable);

            if (selectIndex != null)
            {
                string name = selectIndex.ToString();
                bool isSubmitted = false;
                bool isGraded = false;
                string gradeText = "N/A";
                string feedbackText = "N/A";

                DataRow[] rowsToUpdate = AssignmentTable.Select($"title = '{name}'");

                if (rowsToUpdate.Length == 0)
                {
                    MessageBox.Show("Assignment not found.");
                    return;
                }

                int assignmentID = Convert.ToInt32(rowsToUpdate[0]["assignmentID"]);

                int submissionID = -1;

                foreach (DataRow row in SubmitTable.Rows)
                {
                    if (Convert.ToInt32(row["assignmentID"]) == assignmentID)
                    {
                        isSubmitted = true;
                        submissionID = Convert.ToInt32(row["submissionID"]);
                        break;
                    }
                }

                if (isSubmitted && submissionID != -1)
                {
                    DataRow[] gradeRows = GradeTable.Select($"submissionID = {submissionID}");

                    if (gradeRows.Length > 0)
                    {
                        isGraded = true;
                        gradeText = gradeRows[0]["grade"].ToString();
                        feedbackText = gradeRows[0]["feedback"].ToString();
                    }
                }

                foreach (DataRow row in rowsToUpdate)
                {
                    MessageBox.Show(
                        $"Name: {row["title"]}\n" +
                        $"Description: {row["description"]}\n" +
                        $"Due Date: {row["dueDate"]}\n" +
                        $"Max Points: {row["maxPoints"]}\n" +
                        $"Is Submitted: {isSubmitted}\n" +
                        $"Is Graded: {isGraded}\n" +
                        $"Grade: {gradeText}\n" +
                        $"Feedback: {feedbackText}"
                    );
                }
            }
            else
            {
                MessageBox.Show("Please select an assignment.");
            }

        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbFilterByCourse.Text))
            {

                AssignmentTable = new DataTable();

                string userKeyword = "%" + _username + "%";
                string filterCkeyword = cbFilterByCourse.Text;
                DateTime filterDD1keyword = dtpFilterByDueDate1.Value.Date;
                DateTime filterDD2keyword = dtpFilterByDueDate2.Value.Date;

                if (filterDD1keyword > filterDD2keyword)
                {
                    MessageBox.Show("The first due date value cannot be larger than the second due date value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                AssignmentsAdapter = new SqlDataAdapter("SELECT e.enrollmentID, e.studentID, e.courseID, u.name AS Student, a.title AS Assignment, a.description, a.dueDate, a.maxPoints, e.dateEnrolled " +
                                                "FROM Enrollments e " +
                                                "JOIN users u ON e.studentID = u.id " +
                                                "JOIN Assignments a ON e.courseID = a.courseID " +
                                                "JOIN courses c ON e.courseID = c.courseID " +
                                                "WHERE u.username LIKE @userKeyword AND c.courseTitle = @filterCKeyword AND a.dueDate BETWEEN @filterDD1keyword AND @filterDD2keyword", conn);

                AssignmentsAdapter.SelectCommand.Parameters.AddWithValue("@userKeyword", userKeyword);
                AssignmentsAdapter.SelectCommand.Parameters.AddWithValue("@filterCkeyword", filterCkeyword);
                AssignmentsAdapter.SelectCommand.Parameters.AddWithValue("@filterDD1keyword", filterDD1keyword);
                AssignmentsAdapter.SelectCommand.Parameters.AddWithValue("@filterDD2keyword", filterDD2keyword);

                AssignmentsAdapter.Fill(AssignmentTable);

                listBoxAssignments.Items.Clear();

                foreach (DataRow row in AssignmentTable.Rows)
                {
                    listBoxAssignments.Items.Add(row["Assignment"].ToString());
                }

            }
            /*else if */
        }

        private void btnInfoEn_Click(object sender, EventArgs e)
        {
            object selectIndex = listBoxEnrollCourses.SelectedItem;


            if (selectIndex != null)
            {
                string name = selectIndex.ToString();

                DataRow[] rowsToUpdate = CourseTable.Select($"Course = '{name}'");

                foreach (DataRow row in rowsToUpdate)
                {
                    MessageBox.Show($"Course: {row["Course"]}\nInstructor: {row["instructorName"]}\nCredits: {row["credits"]}\nStart Date: {row["startDate"]}\nEnd Date: {row["endDate"]}");
                }

            }
        }

        private void btnInfoAv_Click(object sender, EventArgs e)
        {
            object selectIndex = listBoxAvalCourses.SelectedItem;

            if (selectIndex != null)
            {
                string name = selectIndex.ToString();

                DataRow[] rowsToUpdate = CourseTable2.Select($"Course = '{name}'");

                foreach (DataRow row in rowsToUpdate)
                {
                    MessageBox.Show($"Course: {row["Course"]}\nInstructor: {row["instructorName"]}\nCredits: {row["credits"]}\nStart Date: {row["startDate"]}\nEnd Date: {row["endDate"]}");
                }

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitTable = new DataTable();
            SubmitAdapter = new SqlDataAdapter("SELECT * FROM submissions", conn);
            SqlCommandBuilder submitBuilder = new SqlCommandBuilder(SubmitAdapter);
            SubmitAdapter.Fill(SubmitTable);
            SubmitBindingSource = new BindingSource();
            SubmitBindingSource.DataSource = SubmitTable;


            object selectIndex = listBoxAssignments.SelectedItem;

            if (selectIndex != null)
            {
                string name = selectIndex.ToString();

                string assignKey = "%" + name + "%";

                checkAssignmentsAdapter = new SqlDataAdapter("SELECT assignmentID FROM Assignments WHERE title LIKE @assignKey", conn);

                checkAssignmentsAdapter.SelectCommand.Parameters.AddWithValue("@assignKey", assignKey);


                DataTable aTable = new DataTable();

                checkAssignmentsAdapter.Fill(aTable);



                int assignmentID = Convert.ToInt32(aTable.Rows[0]["assignmentID"]);
                int idKeyword = _id;
                string userKeyword = _username;
                string submitByText = txtSubmit.Text;

                foreach (DataRow row in SubmitTable.Rows)
                {
                    if (assignmentID.ToString() == row["assignmentID"].ToString())
                    {
                        MessageBox.Show("Assignment Already Submitted!");
                        return;
                    }
                }


                var submittype = SubmitTable.NewRow();
                submittype["assignmentID"] = assignmentID;
                submittype["studentID"] = idKeyword;
                submittype["content"] = submitByText;
                submittype["filePath"] = DBNull.Value;
                submittype["timestamp"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                SubmitTable.Rows.Add(submittype);
                SubmitAdapter.Update(SubmitTable);

                MessageBox.Show("Submitted Successfully!");
            }
            else
            {
                MessageBox.Show("Assignment not found! Make sure the assignment is selected in the assignments listbox!");
                return;

            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
