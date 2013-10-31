using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsNS.Enums;

namespace StudentsNS
{
    class MainDemo
    {
        static void Main()
        {    
            Student ivanka1 = new Student("Ivanka", "Ivanova", "Stoichkova", 188034567, "Sofia, 123 Stambolyisky str.",
                "+ 359 8887 342398", Univercity.SofiaUnivercity, Faculty.Medical, Specialty.Doctor);
            Student ivanka2 = new Student("Ivanka", "Ivanova", "Hristova", 188034567, "Varna, 12 Bulgaria str.",
                "+ 359 8877 445678", Univercity.TUVarna, Faculty.MachineEngineering, Specialty.MachineEngineer);
            Student ivanka3 = new Student("Ivanka", "Ivanova", "Hristova", 185144333, "Sofia, 33 Todor Alexandrov str.",
                "+ 359 8876 445678", Univercity.SofiaUnivercity, Faculty.Medical, Specialty.Doctor);

            List<Student> someStudents = new List<Student>() { ivanka1, ivanka2, ivanka3 };

            if (ivanka1 == ivanka2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}\nand\n\n{1}", ivanka1, ivanka2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("is the same person\n\n");
            }
            else if (ivanka1 != ivanka2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}\nand\n\n{1}", ivanka1, ivanka2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("are NOT the same person\n\n");
            }

            if (ivanka1 == ivanka3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}\nand\n\n{1}", ivanka1, ivanka3);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("is the same person\n\n");
            }
            else if (ivanka1 != ivanka3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}\nand\n\n{1}", ivanka1, ivanka3);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("are NOT the same person\n\n");
            }
            Console.ForegroundColor = ConsoleColor.White;

            Student ivanka4 = ivanka1.Clone();
            ivanka4.SocialSocietyNumber = 188356789;
            ivanka4.Address = "Gabrovo, 2 Topolovo str.";
            ivanka4.PhoneNumber = "+ 358 8878 334567";
            ivanka4.Uni = Univercity.TUVarna;
            ivanka4.Fac = Faculty.ComputerSystemsTechnology;
            ivanka4.Spe = Specialty.SoftwareEngineer;

            if (ivanka1 == ivanka4)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}\nand\n\n{1}", ivanka1, ivanka4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("is the same person\n\n");
            }
            else if (ivanka1 != ivanka4)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}\nand\n\n{1}", ivanka1, ivanka4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("are NOT the same person\n\n");
            }

            someStudents.Add(ivanka4);
            someStudents.Sort();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Some sorted Students:\n\n");
            foreach (var st in someStudents)
            {
                Console.WriteLine(st);
            }
        }
    }
}
