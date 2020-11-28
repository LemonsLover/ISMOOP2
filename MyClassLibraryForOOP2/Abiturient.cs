using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibraryForOOP2
{
    public class Abiturient : Person
    {
        private int ZNOMark;
        private int SchoolMark;
        private string SchoolName;

        //constructors
        public Abiturient() : base()
        {
            ZNOMark = 0;
            SchoolMark = 0;
            SchoolName = "Unknown";
        }

        public Abiturient(string name, string lastName, int znoMark,
            int schoolMark, string schoolName) : base(name, lastName)
        {
            ZNOMark = znoMark;
            SchoolMark = schoolMark;
            SchoolName = schoolName;
        }

        public Abiturient(string name, string lastName, DateTime dateOfBirth, int znoMark, 
            int schoolMark, string schoolName) : base(name, lastName, dateOfBirth)
        {
            ZNOMark = znoMark;
            SchoolMark = schoolMark;
            SchoolName = schoolName;
        }

        //SET-
        public bool SetZNOMark(int znoMark)
        {
            if (znoMark >= 1 && znoMark <= 200)
            {
                ZNOMark = znoMark;
                return true;
            }
            else 
                return false;
        }
        public bool SetSchoolMark(int schoolMark)
        {
            if (schoolMark >= 1 && schoolMark <= 12)
            {
                SchoolMark = schoolMark;
                return true;
            }
            else
                return false;
        }
        public void SetSchoolName(string schoolName)
        {
            SchoolName = schoolName;
        }

        //GET-
        public int GetZNOMark()
        {
            return ZNOMark;
        }

        public int GetSchoolMark()
        {
            return SchoolMark;
        }

        public string GetSchoolName()
        {
            return SchoolName;
        }

        //methods
        public new string ShowInfo()
        {
            return $"{LastName} {Name} was born on {DateOfBirth}.\n" +
                $"Studied at {SchoolName} with {SchoolMark} as a result mark.\n" +
                $"His ZNO result is {ZNOMark}.";
        }
    }
}
