using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNames
{
    class MainTest
    {

        static void Main()
        {
            StudentsArchive someStudents = new StudentsArchive();

            someStudents.Add(new Student("Ivan Ivanov", 25, "male"));
            someStudents.Add(new Student("Hristo Stoichkov", 44, "male"));
            someStudents.Add(new Student("Metodi Aleksiev", 12, "male"));
            someStudents.Add(new Student("Georgy Ivanov", 35, "male"));
            someStudents.Add(new Student("Ilko Peshev", 34, "male"));
            someStudents.Add(new Student("Strahil Kanev", 19, "male"));
            someStudents.Add(new Student("Geno Iliev", 22, "male"));
            someStudents.Add(new Student("Spas Hristov", 23, "male"));
            someStudents.Add(new Student("Yordam Ivanov", 24, "male"));
            someStudents.Add(new Student("Grigor Spasov", 23, "male"));
            someStudents.Add(new Student("Hristo Chalakov", 28, "male"));
            someStudents.Add(new Student("Dimitar Penchev", 29, "male"));
            someStudents.Add(new Student("Ivelin Grozdev", 24, "male"));
            someStudents.Add(new Student("Momchil Tzvetkov", 21, "male"));

            string selectedNames = someStudents.NameSpecialToString();
            Console.WriteLine(selectedNames);
            selectedNames = someStudents.AgeSpecialToString();
            Console.WriteLine(selectedNames);

            string names1 = someStudents.DisplayOrderedNamesLambda();
            string names2 = someStudents.DisplayOrderedNamesLinq();
            Console.WriteLine(names1);
            Console.WriteLine(names2);
        }
    }
}
