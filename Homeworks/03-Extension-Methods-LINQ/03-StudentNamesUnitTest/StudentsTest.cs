using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentNames;

namespace StudentUnitTest
{
    [TestClass]
    public class StudentsTest
    {
        public static StudentsArchive someStudents = new StudentsArchive();

        private static void AddTheList()
        {
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
            someStudents.Add(new Student("Dimitar penchev", 29, "male"));
            someStudents.Add(new Student("Ivelin Grozdev", 24, "male"));
            someStudents.Add(new Student("Momchil Tzvetkov", 21, "male"));
        }

        [TestMethod]
        public void StudentTest1()
        {
            AddTheList();                 
            string expectedOutput = "Student:Ivan Ivanov, age: 25, gender: male\nStudent:Hristo Stoichkov, age: 44, gender: male\nStudent:Georgy Ivanov, age: 35, gender: male\nStudent:Ilko Peshev, age: 34, gender: male\nStudent:Geno Iliev, age: 22, gender: male\nStudent:Grigor Spasov, age: 23, gender: male\nStudent:Dimitar penchev, age: 29, gender: male\nStudent:Momchil Tzvetkov, age: 21, gender: male\n";
            string selectedNames = someStudents.NameSpecialToString();
            Assert.AreEqual(expectedOutput, selectedNames);
        }

        [TestMethod]
        public void StudentTest2()
        {
            string expectedOutput = "Student:Strahil Kanev, age: 19, gender: male\nStudent:Geno Iliev, age: 22, gender: male\nStudent:Spas Hristov, age: 23, gender: male\nStudent:Yordam Ivanov, age: 24, gender: male\nStudent:Grigor Spasov, age: 23, gender: male\nStudent:Ivelin Grozdev, age: 24, gender: male\nStudent:Momchil Tzvetkov, age: 21, gender: male\n";
            string selectedNames = someStudents.AgeSpecialToString();
            Assert.AreEqual(expectedOutput, selectedNames);
        }

        [TestMethod]
        public void StudentTest3()
        {
            string names1 = someStudents.DisplayOrderedNamesLambda();
            string names2 = someStudents.DisplayOrderedNamesLinq();
            Assert.AreEqual(names1, names2);
        }
    }
}