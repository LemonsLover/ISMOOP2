using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibraryForOOP2
{
    public class Student : Abiturient
    {
        private int Course;
        private string Group;
        private string Faculty;
        private string University;

        //constructors
        public Student() : base()
        {
            Course = 0;
            Group = "Unknown";
            Faculty = "Unknown";
            University = "Unknown";
        }
        public Student(string name, string lastName, DateTime dateOfBirth, int znoMark,
            int schoolMark, string schoolName, int course, 
            string group, string faculty, string university) : 
            base(name, lastName, dateOfBirth, znoMark, schoolMark, schoolName)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
        public Student(string name, string lastName, int znoMark,
            int schoolMark, string schoolName, int course,
            string group, string faculty, string university) :
            base(name, lastName, znoMark, schoolMark, schoolName)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }

        //SET-
        public bool SetCourse(int course)
        {
            if (course > 0)
            {
                Course = course;
                return true;
            }
            else
                return false;
        }

        public void SetGroup(string group)
        {
            Group = group;
        }

        public void SetFaculty(string faculty)
        {
            Faculty = faculty;
        }

        public void SetUniversity(string university)
        {
            University = university;
        }
        //GET-
        public int GetCourse()
        {
            return Course;
        }

        public string GetGroup()
        {
            return Group;
        }

        public string GetFaculty()
        {
            return Faculty;
        }

        public string GetUniversity()
        {
            return University;
        }

        //methods
        public new string ShowInfo()
        {
            return $"{LastName} {Name} was born on {DateOfBirth}.\n" +
                $"Studied at {GetSchoolName()} with {GetSchoolMark()} as a result mark.\n" +
                $"His ZNO result is {GetZNOMark()}.\n" +
                $"Now studying at {University} in {Faculty} faculty in group {Group} on {Course}" +
                $" course.";
        }
    }
}
