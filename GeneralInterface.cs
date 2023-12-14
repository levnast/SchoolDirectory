using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SchoolSystem
{
    public class GeneralInterface
    {
        public ScheduleOfLessons Schedule;
        public Grades Assessments;
        public Attendance Attendance;
        public Homework Homework;

        public void ViewScheduleOfLessons()
        {
            string[] lines = File.ReadAllLines("ScheduleOfLessons.txt");
            foreach (string s in lines)
                Console.WriteLine(s);

        }
        public void ViewGrades()
        {
            string[] lines = File.ReadAllLines("Grades.txt");
            foreach (string s in lines)
                Console.WriteLine(s);
        }
        public void ViewAttendance()
        {
            string[] lines = File.ReadAllLines("Attendance.txt");
            foreach (string s in lines)
                Console.WriteLine(s);
        }
        public void ViewHomework()
        {
            string[] lines = File.ReadAllLines("Homework.txt");
            foreach (string s in lines)
                Console.WriteLine(s);
        }
    }
}
