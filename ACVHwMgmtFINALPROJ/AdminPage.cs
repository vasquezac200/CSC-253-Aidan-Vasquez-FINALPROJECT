using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using static Azure.Core.HttpHeader;

namespace ACVHwMgmtFINALPROJ
{
    public partial class AdminPage : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=C:\Users\aidan\Downloads\ACVHwMgmtFINALPROJ\ACVHwMgmtFINALPROJ\Database1.mdf;
              Integrated Security=True;
              Connect Timeout=30;";

        private SqlConnection? conn;
        private SqlDataAdapter? userAdapter;
        private SqlDataAdapter? courseAdapter;
        private SqlDataAdapter? enrollmentsAdapter;
        private SqlDataAdapter? submissionAdapter;
        private SqlDataAdapter? studentAdapter;
        private SqlCommandBuilder? builder;
        private DataTable? userTable;
        private DataTable? courseTable;
        private DataTable? enrollTable;
        private DataTable? submissionTable;
        private DataTable? studentTable;
        private BindingSource? userBindingSource;
        private BindingSource? courseBindingSource;
        private BindingSource? enrollBindingSource;


        string _name;
        string _username;
        string _password;


        public AdminPage(string name, string username, string password)
        {
            InitializeComponent();
            this.Load += Form3_Load;
            _name = name;
            _username = username;
            _password = password;
            using var conn = new SqlConnection(cs);
            conn.Open();
        }





        private void Form3_Load(object sender, EventArgs e)
        {

            conn = new SqlConnection(cs);
            userAdapter = new SqlDataAdapter("SELECT * FROM users", conn);
            courseAdapter = new SqlDataAdapter("SELECT * FROM courses", conn);
            userTable = new DataTable();
            courseTable = new DataTable();
            conn.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(userAdapter);
            SqlCommandBuilder builder2 = new SqlCommandBuilder(courseAdapter);
            userAdapter.Fill(userTable);
            userBindingSource = new BindingSource();
            courseBindingSource = new BindingSource();
            welcomeLabel.Text = $"Hello {_name}! :D";
            userBindingSource.DataSource = userTable;
            dataGridAdmin.DataSource = userBindingSource;

            SqlDataAdapter enrollmentsAdapter = new SqlDataAdapter("SELECT e.enrollmentID, e.studentID, e.courseID, u.name AS Student, c.courseTitle AS Course, e.dateEnrolled " +
                                                "FROM Enrollments e " +
                                                "JOIN users u ON e.studentID = u.id " +
                                                "JOIN courses c ON e.courseID = c.courseID ", conn);




            studentAdapter = new SqlDataAdapter("SELECT * FROM users " +
                                                 "WHERE role = 'Student'", conn);
            studentTable = new DataTable();
            SqlCommandBuilder builder3 = new SqlCommandBuilder(studentAdapter);

            enrollTable = new DataTable();
            enrollmentsAdapter.Fill(enrollTable);
            enrollBindingSource = new BindingSource();

            enrollBindingSource.DataSource = enrollTable;
            dataGridEnrollments.DataSource = enrollBindingSource;

            courseAdapter.Fill(courseTable);


            listBoxCourses.Items.Clear();
            comboBoxFilterC.Items.Clear();
            cbEnrollCourse.Items.Clear();
            foreach (DataRow row in courseTable.Rows)
            {
                listBoxCourses.Items.Add(row["courseTitle"].ToString());
                comboBoxFilterC.Items.Add(row["courseTitle"].ToString());
                cbEnrollCourse.Items.Add(row["courseTitle"].ToString());
            }

            studentAdapter.Fill(studentTable);

            comboBoxFilterS.Items.Clear();
            cbEnrollStudent.Items.Clear();
            foreach (DataRow row2 in studentTable.Rows)
            {
                comboBoxFilterS.Items.Add(row2["name"].ToString());
                cbEnrollStudent.Items.Add(row2["username"].ToString());
            }



            comboBoxRole.Items.Add("Admin");
            comboBoxRole.Items.Add("Instructor");
            comboBoxRole.Items.Add("Student");


        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            userAdapter = new SqlDataAdapter("SELECT * FROM users", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(userAdapter);
            userTable = new DataTable();
            conn.Open();
            userAdapter.Fill(userTable);
            userBindingSource = new BindingSource();
            userBindingSource.DataSource = userTable;
            dataGridAdmin.DataSource = userBindingSource;


            string name = txtUName.Text;
            string username = txtUUsername.Text;
            string password = txtUPassword.Text;
            string role = comboBoxRole.Text;


            var newuser = userTable.NewRow();
            newuser["name"] = name;
            newuser["username"] = username;
            newuser["password"] = password;
            newuser["role"] = role;



            bool userIsTaken = false;
            foreach (DataRow r in userTable.Rows)
            {
                if (r["username"].ToString() == username)
                {
                    MessageBox.Show("Username is already taken.");
                    userIsTaken = true;
                    break;
                }
            }

            if (userIsTaken == false)
            {
                userTable.Rows.Add(newuser);
                userAdapter.Update(userTable);
            }


        }


        private void btnLogoutAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string courseName = txtCourseName.Text;
            string instructor = comboBoxInstructor.Text;
            string credits = nudCredits.Text;
            string startDate = dtpStartDate.Text;
            string endDate = dtpEndDate.Text;

            listBoxCourses.Items.Add(courseName);

            conn = new SqlConnection(cs);
            courseAdapter = new SqlDataAdapter("SELECT * FROM courses", conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(courseAdapter);
            courseTable = new DataTable();
            conn.Open();
            courseAdapter.Fill(courseTable);
            courseBindingSource = new BindingSource();
            courseBindingSource.DataSource = courseTable;

            


            var newcourse = courseTable.NewRow();
            newcourse["courseTitle"] = courseName;
            newcourse["instructorName"] = instructor;
            newcourse["credits"] = credits;
            newcourse["startDate"] = startDate;
            newcourse["endDate"] = endDate;



            courseTable.Rows.Add(newcourse);
            courseAdapter.Update(courseTable);


        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            courseAdapter = new SqlDataAdapter("SELECT * FROM courses", conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(courseAdapter);
            courseTable = new DataTable();
            conn.Open();
            courseAdapter.Fill(courseTable);

            object selectIndex = listBoxCourses.SelectedItem;


            if (selectIndex != null)
            {
                string name = selectIndex.ToString();
                DataRow[] rowsToDelete = courseTable.Select($"courseTitle = '{name}'");

                foreach (DataRow row in rowsToDelete)
                {
                    row.Delete();
                }
                courseAdapter.Update(courseTable);
                listBoxCourses.Items.RemoveAt(listBoxCourses.SelectedIndex);
                MessageBox.Show("Course Deleted Successfully!");
            }


        }

        private void btnSaveUsers_Click(object sender, EventArgs e)
        {

            userAdapter.Update(userTable);

        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            string courseName = txtCourseName.Text;
            string instructor = comboBoxInstructor.Text;
            string credits = nudCredits.Text;
            string startDate = dtpStartDate.Text;
            string endDate = dtpEndDate.Text;

            object selectIndex = listBoxCourses.SelectedItem;


            if (selectIndex != null)
            {
                string name = selectIndex.ToString();

                DataRow[] rowsToUpdate = courseTable.Select($"courseTitle = '{name}'");

                foreach (DataRow row in rowsToUpdate)
                {
                    row["courseTitle"] = courseName;
                    row["instructorName"] = instructor;
                    row["credits"] = credits;
                    row["startDate"] = startDate;
                    row["endDate"] = endDate;
                }
                courseAdapter.Update(courseTable);
                MessageBox.Show("Course Updated Successfully!");

            }
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {

            object selectIndex = listBoxCourses.SelectedItem;


            if (selectIndex != null)
            {
                string name = selectIndex.ToString();

                DataRow[] rowsToUpdate = courseTable.Select($"courseTitle = '{name}'");

                foreach (DataRow row in rowsToUpdate)
                {
                    MessageBox.Show($"Course: {row["courseTitle"]}\nInstructor: {row["instructorName"]}\nCredits: {row["credits"]}\nStart Date: {row["startDate"]}\nEnd Date: {row["endDate"]}");
                }

            }
        }

        class Course
        {
            public Course(int ID, string Name, string InstructorName, string credits, string startDate, string endDate)
            {
                id = ID;
                name = Name;
                instName = InstructorName;
                credit = credits;
                start = startDate;
                end = endDate;

            }
            public int id { get; set; }
            public string name { get; set; }
            public string instName { get; set; }
            public string credit { get; set; }
            public string start { get; set; }

            public string end { get; set; }

            public override string ToString()
            {
                return $"({id}, {name}, {instName}, {credit}, {start}, {end})";
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)

        {
            if ((!string.IsNullOrWhiteSpace(comboBoxFilterC.Text)) && (!string.IsNullOrWhiteSpace(comboBoxFilterS.Text)))
            {

                string courseKeyword = "%" + comboBoxFilterC.Text + "%";
                string studentKeyword = "%" + comboBoxFilterS.Text + "%";
                SqlDataAdapter enrollmentsAdapter = new SqlDataAdapter("SELECT e.enrollmentID, e.studentID, e.courseID, u.name AS Student, c.courseTitle AS Course, e.dateEnrolled " +
                                                    "FROM Enrollments e " +
                                                    "JOIN users u ON e.studentID = u.id " +
                                                    "JOIN courses c ON e.courseID = c.courseID " +
                                                    "WHERE c.courseTitle LIKE @courseKeyword OR u.name LIKE @studentKeyword", conn);
                enrollmentsAdapter.SelectCommand.Parameters.AddWithValue("@courseKeyword", courseKeyword);
                enrollmentsAdapter.SelectCommand.Parameters.AddWithValue("@studentKeyword", studentKeyword);
                DataTable enrollTable = new DataTable();
                enrollmentsAdapter.Fill(enrollTable);
                dataGridEnrollments.DataSource = enrollTable;

            }
            else if (!string.IsNullOrWhiteSpace(comboBoxFilterC.Text))
            {
                string courseKeyword = "%" + comboBoxFilterC.Text + "%";
                SqlDataAdapter enrollmentsAdapter = new SqlDataAdapter("SELECT e.enrollmentID, e.studentID, e.courseID, u.name AS Student, c.courseTitle AS Course, e.dateEnrolled " +
                                                    "FROM Enrollments e " +
                                                    "JOIN users u ON e.studentID = u.id " +
                                                    "JOIN courses c ON e.courseID = c.courseID " +
                                                    "WHERE c.courseTitle LIKE @courseKeyword", conn);
                enrollmentsAdapter.SelectCommand.Parameters.AddWithValue("@courseKeyword", courseKeyword);
                DataTable enrollTable = new DataTable();
                enrollmentsAdapter.Fill(enrollTable);
                dataGridEnrollments.DataSource = enrollTable;
            }
            else if (!string.IsNullOrWhiteSpace(comboBoxFilterS.Text))
            {
                string studentKeyword = "%" + comboBoxFilterS.Text + "%";
                SqlDataAdapter enrollmentsAdapter = new SqlDataAdapter("SELECT e.enrollmentID, e.studentID, e.courseID, u.name AS Student, c.courseTitle AS Course, e.dateEnrolled " +
                                                    "FROM Enrollments e " +
                                                    "JOIN users u ON e.studentID = u.id " +
                                                    "JOIN courses c ON e.courseID = c.courseID " +
                                                    "WHERE u.name LIKE @studentKeyword", conn);
                enrollmentsAdapter.SelectCommand.Parameters.AddWithValue("@studentKeyword", studentKeyword);
                DataTable enrollTable = new DataTable();
                enrollmentsAdapter.Fill(enrollTable);
                dataGridEnrollments.DataSource = enrollTable;
            }
            else
            {
                MessageBox.Show("Input values are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        

        private void comboBoxFilterS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewEnroll_Click(object sender, EventArgs e)
        {
            string studentUsername = cbEnrollStudent.Text;
            string courseName = cbEnrollCourse.Text;
            DateTime dateEnrolled = dtpDateEnrolled.Value;

            enrollmentsAdapter = new SqlDataAdapter("SELECT * FROM Enrollments", conn);
            SqlCommandBuilder b = new SqlCommandBuilder(enrollmentsAdapter);

            enrollTable = new DataTable();
            enrollmentsAdapter.Fill(enrollTable);

            if (string.IsNullOrWhiteSpace(studentUsername) || string.IsNullOrWhiteSpace(courseName))
            {
                MessageBox.Show("One of the values are empty (Student or Course).");
                return;
            }


            userAdapter = new SqlDataAdapter("SELECT * FROM users " +
                                             "WHERE username = @studentName", conn);
            userAdapter.SelectCommand.Parameters.AddWithValue("@studentName", studentUsername);
            courseAdapter = new SqlDataAdapter("SELECT * FROM courses " +
                                                "WHERE courseTitle = @courseName", conn);
            courseAdapter.SelectCommand.Parameters.AddWithValue("@courseName", courseName);
            userTable = new DataTable();
            userAdapter.Fill(userTable);

            courseTable = new DataTable();
            courseAdapter.Fill(courseTable);

            int studentID = Convert.ToInt32(userTable.Rows[0]["id"]);
            int courseID = Convert.ToInt32(courseTable.Rows[0]["courseID"]);

            foreach (DataRow r in enrollTable.Rows)
            {
                if (Convert.ToInt32(r["studentID"]) == studentID && Convert.ToInt32(r["courseID"]) == courseID)
                {
                    MessageBox.Show("Student is already enrolled in this course.");
                    return;
                }
            }

            if (userTable.Rows.Count == 0 || courseTable.Rows.Count == 0)
            {
                MessageBox.Show("Student or course not found.");
                return;
            }


            var newEnroll = enrollTable.NewRow();
            newEnroll["studentID"] = Convert.ToInt32(userTable.Rows[0]["id"]);
            newEnroll["courseID"] = Convert.ToInt32(courseTable.Rows[0]["courseID"]);
            newEnroll["dateEnrolled"] = dateEnrolled;

            enrollTable.Rows.Add(newEnroll);
            enrollmentsAdapter.Update(enrollTable);

            MessageBox.Show("Enrollment Added Successfully!");



        }

        private void btnSaveEnroll_Click(object sender, EventArgs e)
        {
            enrollmentsAdapter.Update(enrollTable);
        }
    }
}
