using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolProject;
using System.Collections.Generic;

namespace SchoolProjectUnitTest
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void TestSchool1() // Test Person Class
        {
            Person carSeller1 = new Person("Ivan", "Ivanov", 40, "male", Fitness.Good);
            Person carSeller2 = new Person("Ivan", "Ivanov", 40, "male");

            string exp1 = "Person details: Ivan Ivanov, age=40, gender - male, health condition - Good";
            string exp2 = "Person details: Ivan Ivanov, age=40, gender - male, health condition - NotDefined";

            string cs1 = carSeller1.ToString();
            string cs2 = carSeller2.ToString();

            Assert.AreEqual(exp1, cs1);
            Assert.AreEqual(exp2, cs2);
        }

        [TestMethod]
        public void TestSchool2() // Test Teacher class and ICommended interface
        {
            Teacher ivanovOne = new Teacher("Stancho", "Ivanov", 42, "male", Fitness.NotSoGood);
            ivanovOne.AddDicipline(new Dicipline("Biology", 12));
            ivanovOne.AddDicipline(new Dicipline("Micro Biology", 8));
            ivanovOne.Comment = "The comment for teacher Ivanov: he is very professional";

            string exp1 = "The diciplines of Stancho Ivanov are: Biology, Micro Biology, \b\b;";
            string exp2 = "The comment for teacher Ivanov: he is very professional";

            string cs1 = ivanovOne.ToString();
            string cs2 = ivanovOne.Comment;

            Assert.AreEqual(exp1, cs1);
            Assert.AreEqual(exp2, cs2);
        }

        [TestMethod]
        public void TestSchool3() // Test School class 
        {
            Teacher ivanovOne = new Teacher("Stancho", "Ivanov", 42, "male", Fitness.NotSoGood);
            ivanovOne.AddDicipline(new Dicipline("Biology", 12));
            ivanovOne.AddDicipline(new Dicipline("Micro Biology", 8));

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
            fiveA.Comment = "The comment for 5A Class: very doog students";

            string exp1 = "The class 5A has the following teachers:\nName: Stancho Ivanov, Diciplines: Biology Micro Biology \nName: Ivan Chomakov, Diciplines: Mathematics 1 Mathematics 2 Mathematics 3 Software algorithms C# Java Script \nName: Pacho Hristov, Diciplines: Sports Tennis Table ";
            string exp2 = "The comment for 5A Class: very doog students";

            string cs1 = fiveA.ToString();
            string cs2 = fiveA.Comment;

            Assert.AreEqual(exp1, cs1);
            Assert.AreEqual(exp2, cs2);
        }

        [TestMethod]
        public void TestSchool4() // Test Student class 
        {
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

            List<string> onlyNames = new List<string>() { "Hristo Hristov", "Hristo Ivanov", "Ivan Hristov", "Pesho Stoichkov",
                "Evstati Georgiev", "Ognian Slavkov", "Milko Ivanov", "Vasil Penchev", "Mihail Mihailov", "Evjeni Jeliazkov" };

            someStudents.Sort();
            onlyNames.Sort();
            int counter = 0;

            foreach (var student in someStudents)
            {
                Assert.AreEqual(string.Format("{0} {1}", student.FirstName, student.LastName), onlyNames[counter]);
                counter++;
            }
        }
    }
}
