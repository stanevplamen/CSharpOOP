using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class MainTestClass
    {
        static void Main()
        {
            Person carSeller = new Person("Ivan", "Ivanov", 40, "male", Fitness.Good);
            Student hristoOne = new Student("Hristo", "Hristov", 15, "male", Fitness.Good, 123, "5A");
            Student hristoTwo = new Student("Hristo", "Ivanov", 17, "male", Fitness.Bad, 124, "7C");
            Student ivanOne = new Student("Ivan", "Hristov", 14, "male", Fitness.Super, 125, "4A");
            Student peshoOne = new Student("Pesho", "Stoichkov", 18, "male", Fitness.NotSoGood, 126, "8C");
            Student evstatiOne = new Student("Evstati", "Georgiev", 13, "male", Fitness.Bad, 127, "3B");
            Student ognianOne = new Student("Ognian", "Slavkov", 12, "male", Fitness.VeryGood, 128, "2B");
            Student milkoOne = new Student("Milko", "Ivanov", 12, "male", Fitness.Good, 129, "2B");
            Student vasilOne = new Student("Vasil", "Penchev", 15, "male", Fitness.Good, 130, "5A");
            Student mihailOne = new Student("Mihail", "Mihailov", 15, "male", Fitness.VeryGood, 131, "5A");
            Student evgeniOne = new Student("Evjeni", "Jeliazkov", 15, "male", Fitness.Good, 132, "5A");

            List<Student> someStudents = new List<Student>() { hristoOne, hristoTwo, ivanOne, peshoOne, evstatiOne, 
            ognianOne, milkoOne, vasilOne, mihailOne, evgeniOne};

            someStudents.Sort();

            Teacher ivanovOne = new Teacher("Stancho", "Ivanov", 42, "male", Fitness.NotSoGood);
            ivanovOne.AddDicipline(new Dicipline("Biology", 12));
            ivanovOne.AddDicipline(new Dicipline("Micro Biology", 8));
            ivanovOne.Comment = "The comment for teacher Ivanov: he is very professional";

            Teacher chomakovOne = new Teacher("Ivan", "Chomakov", 35, "male", Fitness.Good);
            chomakovOne.AddDicipline(new Dicipline("Mathematics 1", 15));
            chomakovOne.AddDicipline(new Dicipline("Mathematics 2", 15));
            chomakovOne.AddDicipline(new Dicipline("Mathematics 3", 10));
            chomakovOne.AddDicipline(new Dicipline("Software algorithms", 12));
            chomakovOne.AddDicipline(new Dicipline("C#", 20));
            chomakovOne.AddDicipline(new Dicipline("Java Script", 20));

            Teacher hristovOne = new Teacher("Pacho", "Hristov", 42, "male", Fitness.Bad);
            hristovOne.AddDicipline(new Dicipline("Sports", 4));
            hristovOne.AddDicipline(new Dicipline("Tennis Table", 4));


            SchoolClass fiveA = new SchoolClass("5A");
            fiveA.AddTeacher(ivanovOne);
            fiveA.AddTeacher(chomakovOne);
            fiveA.AddTeacher(hristovOne);

            // test one
            Console.WriteLine("===========================");
            Console.WriteLine(ivanovOne.ToString());
            Console.WriteLine(chomakovOne.ToString());
            Console.WriteLine(hristovOne.ToString());
            Console.WriteLine("===========================");
            // test two
            Console.WriteLine(fiveA.ToString());
            Console.WriteLine("===========================");
            // test three
            Console.WriteLine(ivanovOne.Comment);
            Console.WriteLine("===========================");
        }
    }
}
