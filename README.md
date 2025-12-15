# Homework Management System (HMS) - CSC-253 Final Project

A WinForms desktop Homework Management System inspired by Moodle. Supports Admin, Instructor, and Student roles for managing courses, assignments, submissions, and grading.

## Features
### Admin
- View users
- Create users + assign roles
- Manage courses
- Manage enrollments

### Instructor
- Create / edit / delete assignments
- View submissions
- Grade submissions with feedback
- Generate grade reports
- Export reports to CSV

### Student
- View available courses
- Enroll in courses
- View assignments
- Submit homework (text + optional .txt upload)
- View grades and feedback

## Tech Stack
- C# WinForms
- SQL Server LocalDB (.mdf)
- ADO.NET (SqlConnection / SqlDataAdapter / DataTable)

## How to Run
1. Open `ACVHwMgmtFINALPROJ.sln` in Visual Studio
2. Build & Run
3. Login using the pre-created admin:
   - Username: `admin`
   - Password: `admin`

## Screenshots
![Login](Screenshots/login.png)
![Admin](Screenshots/admin-users.png)
![Instructor](Screenshots/instructor-grading.png)
![Student](Screenshots/student-assignments.png)
![Report](Screenshots/grade-report.png)
