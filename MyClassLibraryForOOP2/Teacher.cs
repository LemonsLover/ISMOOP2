using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibraryForOOP2
{
    public class Teacher : Person
    {
        string Position;
        string Department;
        string University;

        //constructors

        public Teacher() : base()
        {
            Position = "Unknown";
            Department = "Unknown";
            University = "Unknown";
        }

        public Teacher(string name, string lastName, string position,
            string department, string university) : base(name, lastName)
        {
            Position = position;
            Department = department;
            University = university;
        }

        public Teacher(string name, string lastName, DateTime dateOfBirth, string position,
            string department, string university):base(name, lastName, dateOfBirth)
        {
            Position = position;
            Department = department;
            University = university;
        }

        //SET-
        public void SetPosition(string position)
        {
            Position = position;
        }

        public void SetDepartment(string department)
        {
            Department = department;
        }

        public void SetUniversity(string university)
        {
            University = university;
        }

        //GET-
        public string GetPosition()
        {
            return Position;
        }

        public string GetDepartment()
        {
            return Department;
        }

        public string SetUniversity()
        {
            return University;
        }

        //methods
        public override string ShowInfo()
        {
            return $"{LastName} {Name} was born on {DateOfBirth}.\n" +
                $"Work as a {Position} at {Department} department at the {University} university.";     
        }
    }
}

