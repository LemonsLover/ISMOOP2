using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibraryForOOP2
{
    public class Person 
    {
        protected string Name;
        protected string LastName;
        protected DateTime DateOfBirth;


        //constructors
        public Person()
        {
            Name = "Unknown";
            LastName = "Unknown";
            DateOfBirth = new DateTime();
        }
        public Person(string name, string lastName, DateTime dateOfBirth)
        {
            Name = name;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
            DateOfBirth = new DateTime();
        }
        //Set-
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetlastName(string lastName)
        {
            LastName = lastName;
        }
        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }
        //Get-
        public string GetName()
        {
            return Name;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public DateTime GetDateOfBirth()
        {
            return DateOfBirth;
        }
        //methods
        public string ShowInfo()
        {
            return $"{LastName} {Name} was born on {DateOfBirth}.";
        }
    }
}
