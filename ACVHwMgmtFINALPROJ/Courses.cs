using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ACVHwMgmtFINALPROJ
{
    public class Course
    {
        public int CourseID { get; private set; }
        public string CourseTitle { get; set; }
        public int InstructorID { get; set; }
        public string InstructorName { get; set; }
        public int Credits { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Course(int courseID, string courseTitle, int instructorID, string instructorName,
                      int credits, DateTime startDate, DateTime endDate)
        {
            CourseID = courseID;
            CourseTitle = courseTitle;
            InstructorID = instructorID;
            InstructorName = instructorName;
            Credits = credits;
            StartDate = startDate;
            EndDate = endDate;
        }


        public override string ToString()
        {
            return $"{CourseID} {CourseTitle}";
        }
    }
}
