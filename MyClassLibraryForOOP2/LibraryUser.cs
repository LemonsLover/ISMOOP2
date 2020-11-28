using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibraryForOOP2
{
    public class LibraryUser : Person
    {
        int ReaderID;
        DateTime DateOfIssue;
        int LibraryFee;

        //constructors
        public LibraryUser() : base()
        {
            ReaderID = 0;
            DateOfIssue = new DateTime().Date;
            LibraryFee = 0;
        }

        public LibraryUser(string name, string lastName, DateTime dateOfBirth,
            int readerID, DateTime dateOfIssue, int libraryFee) 
            : base(name, lastName, dateOfBirth)
        {
            ReaderID = readerID;
            DateOfIssue = dateOfIssue;
            LibraryFee = libraryFee;
        }

        public LibraryUser(string name, string lastName,
            int readerID, DateTime dateOfIssue, int libraryFee)
            : base(name, lastName)
        {
            ReaderID = readerID;
            DateOfIssue = new DateTime().Date;
            LibraryFee = libraryFee;
        }

        //SET-
        public bool SetReaderID(int readerID)
        {
            if (readerID > 0)
            {
                ReaderID = readerID;
                return true;
            }
            else return false;
        }

        public void SetDateOfIssue(DateTime dateOfIssue)
        {
            DateOfIssue = dateOfIssue;
        }

        public bool SetLibraryFee(int libraryFee)
        {
            if(libraryFee > 0)
            {
                LibraryFee = libraryFee;
                return  true;
            }
            else return false;
        }

        //GET-
        public int GetReaderID()
        {
            return ReaderID;
        }

        public DateTime GetDateOfIssue()
        {
            return DateOfIssue;
        }

        public int GetLibraryFee()
        {
            return LibraryFee;
        }

        //methods
        public new string ShowInfo()
        {
            return $"{LastName} {Name} was born on {DateOfBirth}.\n" +
                $"User of the library since {DateOfIssue} and pay {LibraryFee} UAH a mounth, " +
                $"his ID {ReaderID}";
                
        }
    }
}
