using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ACVHwMgmtFINALPROJ
{
    public class User
    {
        public User(/*int ID,*/ string Name, string Role, string Username, string Password)
        {
            /*id = ID;*/
            name = Name;
            role = Role;
            username = Username;
            password = Password;
        }

        /*public int id { get; set; }*/
        public string name { get; set; }
        public string role { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public override string ToString()
        {
            return $"Name: {name}, Role: {role}, Username: {username}, Password: {password}";
        }

        public string nameToString()
        {
            return name;
        }
        public string roleToString()
        {
            return role;
        }
        public string usernameToString()
        {
            return username;
        }
        public string passwordToString()
        {
            return password;
        }
    }
    public class Student : User
    {
        public Student(/*int ID,*/ string Name, string Username, string Password) : base(/*ID,*/ Name, "Student", Username, Password) { }
    }

    public class Instructor : User
    {
        public Instructor(/*int ID,*/ string Name, string Username, string Password) : base(/*ID,*/ Name, "Instructor", Username, Password) { }

    }

    public class Admin : User
    {
        public Admin(/*int ID,*/ string Name, string Username, string Password) : base(/*ID,*/ Name, "Admin", Username, Password) { }

    }
}

