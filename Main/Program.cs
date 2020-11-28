using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibraryForOOP2;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Egor = new Person("Yehor", "Ovseukov", new DateTime(2002,09,26));
            Abiturient Gosha = new Abiturient("Gosha", "Ivanov", 200, 7, "lyceum #2");
            Student Roma = new Student("Roma", "Markeev",new DateTime(2002,09,21), 
                179, 9, "School #10", 1, "CS_20_1", "FICT", "ZTU");
            Teacher Misha = new Teacher("Misha", "Simonec",new DateTime(1980,06,6), "Dean", "CE", "ZTU");
            LibraryUser Danil = new LibraryUser("Danil", "Malinovskiy",
                new DateTime(2003, 05, 12), 1337,  new DateTime(2020, 11, 29), 25);

            Console.WriteLine($"Person - {Egor.ShowInfo()}\n");
            Console.WriteLine("Abiturient - " + Gosha.ShowInfo() + "\n");
            Console.WriteLine("Student - " + Roma.ShowInfo() + "\n");
            Console.WriteLine("Teacher - " + Misha.ShowInfo() + "\n");
            Console.WriteLine("Library user - " + Danil.ShowInfo() + "\n");

            Console.ReadKey();
        }
    }
}
