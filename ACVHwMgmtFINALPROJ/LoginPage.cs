using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using static System.Net.Mime.MediaTypeNames;

namespace ACVHwMgmtFINALPROJ
{
    public partial class LoginPage : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=C:\Users\aidan\Downloads\ACVHwMgmtFINALPROJ\ACVHwMgmtFINALPROJ\Database1.mdf;
              Integrated Security=True;
              Connect Timeout=30;";


        private SqlConnection? conn;
        private SqlDataAdapter? adapter;
        private SqlCommandBuilder? builder;
        private DataTable? table;
        private BindingSource? bindingSource;


        public LoginPage()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            using var conn = new SqlConnection(cs);
            conn.Open();

        }

        private List<User> users = new List<User>();
        
        

        private void Form1_Load(object sender, EventArgs e)
        {

            conn = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT id, name, role, username, password FROM users", conn);
            table = new DataTable();
            conn.Open();
            bindingSource = new BindingSource();
            bindingSource.DataSource = table;


        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM users", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            table = new DataTable();
            conn.Open();
            adapter.Fill(table);

            

            string fullName = txtFullName.Text;
            string username = txtNewUser.Text;
            string password = txtNewPass.Text;
            string confpass = txtConfNewPass.Text;

            Student user = new Student(fullName, username, password);

            var newrow = table.NewRow();
            newrow["name"] = user.nameToString();
            newrow["username"] = user.usernameToString();
            newrow["password"] = user.passwordToString();
            newrow["role"] = user.roleToString();
            



            if (password == confpass)
            {
                bool userIsTaken = false;
                foreach (DataRow r in table.Rows)
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
                    table.Rows.Add(newrow);
                    adapter.Update(table);
                    MessageBox.Show("Register Successful! Login to continue.");
                }

            }
            else
            {
                MessageBox.Show("Password doesn't match!");
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            string userInput = txtUser.Text;
            string passInput = txtPass.Text;

            string userKeyword = "%" + userInput + "%";
            string passKeyword = "%" + passInput + "%";

            conn = new SqlConnection(cs);
            conn.Open();
            string query = "SELECT * FROM users WHERE username LIKE @userKeyword";
            string query2 = "SELECT * FROM users WHERE password LIKE @passKeyword";
            var adapter1 = new SqlDataAdapter(query, conn);
            var adapter2 = new SqlDataAdapter(query2, conn);
            adapter1.SelectCommand.Parameters.AddWithValue("@userKeyword", userKeyword);
            adapter2.SelectCommand.Parameters.AddWithValue("@passkeyword", passKeyword);

            var table = new DataTable();
            adapter1.Fill(table);
            adapter2.Fill(table);


            bool correctUsername = false;
            bool correctPassword = false;

            

            foreach (DataRow row in table.Rows)
            {

                /*int id = 1;*/
                string name = row["name"] as string ?? "";
                string role = row["role"] as string ?? "";
                string username = row["username"] as string ?? "";  
                string password = row["password"] as string ?? "";

                User user = new User(name, role, username, password);
                
                string _name = user.name;
                string _username = user.username;
                string _password = user.password;

                if (username == userInput)
                {
                    correctUsername = true;
                    if (password == passInput)
                    {
                        correctPassword = true;
                        if (user.role == "Student") { StudentPage toStudent = new StudentPage(_name, _username, _password);  toStudent.ShowDialog(); }
                        else if (user.role == "Instructor") { InstructorPage toInstructor = new InstructorPage(_name, _username, _password);  toInstructor.ShowDialog(); }
                        else if (user.role == "Admin") { AdminPage toAdmin = new AdminPage(_name, _username, _password);  toAdmin.ShowDialog(); }

                    }
                }
            }

         if (!correctUsername)
            {
                MessageBox.Show("Username is incorrect!");
            }
            else if (!correctPassword)
            {
                MessageBox.Show("Password is incorrect!");
            }

        }
        
    }
}
