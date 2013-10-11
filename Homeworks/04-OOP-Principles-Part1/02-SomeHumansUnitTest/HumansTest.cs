using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeHumans;
using System.Collections.Generic;
using System.Linq;

namespace SomeHumansUnitTest
{
    [TestClass]
    public class HumansTest
    {
        private static List<Student> studentsList = new List<Student>();
        private static List<Worker> workersList = new List<Worker>();
        private static List<Human> mergedLists = new List<Human>();

        [TestMethod]
        public void LoadLists()
        {
            studentsList.Add(new Student("Ivan", "Petrov", 5));
            studentsList.Add(new Student("Hristo", "Mihailov", 11));
            studentsList.Add(new Student("Ivana", "Nanova", 7));
            studentsList.Add(new Student("Daniela", "Dimitrova", 7));
            studentsList.Add(new Student("Ficho", "Kolev", 6));
            studentsList.Add(new Student("Gosho", "Petrov", 3));
            studentsList.Add(new Student("Mira", "Georgieva", 12));
            studentsList.Add(new Student("Mitko", "Topkov", 4));
            studentsList.Add(new Student("Daniela", "Dikova", 3));
            studentsList.Add(new Student("Krum", "Aleksandrov", 2));

            workersList.Add(new Worker("Ivan", "Petrov", 350, 8));
            workersList.Add(new Worker("Hristo", "Mihailov", 350, 4));
            workersList.Add(new Worker("Ivan", "Nanov", 500, 10));
            workersList.Add(new Worker("Daniel", "Dimitrov", 370, 8));
            workersList.Add(new Worker("Ficho", "Kolev", 380, 8));
            workersList.Add(new Worker("Gosho", "Petrov", 2000, 8));
            workersList.Add(new Worker("Miro", "Georgiev", 1000, 14));
            workersList.Add(new Worker("Mitko", "Topkov", 400, 12));
            workersList.Add(new Worker("Daniel", "Dikov", 300, 8));
            workersList.Add(new Worker("Krum", "Aleksandrov", 200, 4));

            foreach (var item in studentsList)
            {
                mergedLists.Add(item);
            }
            foreach (var item in workersList)
            {
                mergedLists.Add(item);
            }
        }

        [TestMethod]
        public void TestHuman1() // Test Students List
        {
            var studentsAscending =
                from st in studentsList
                orderby st
                select st;

            int counter = 0;
            studentsList.Sort();
            foreach (var st in studentsAscending)
            {
                string linqSort = String.Format("{0} {1}, grade {2}", st.FirstName, st.LastName, st.Grade);
                string listSort = String.Format("{0} {1}, grade {2}", studentsList[counter].FirstName, studentsList[counter].LastName, studentsList[counter].Grade);

                Assert.AreEqual(linqSort, listSort);
                counter++;
            }
        }


        [TestMethod]
        public void TestHuman2() // Test Workers List
        {
            var workersMoneyPerHourList =
                from wr in workersList
                orderby wr
                select wr;

            int counter = 0;
            workersList.Sort();
            foreach (var wr in workersMoneyPerHourList)
            {
                string linqSort = String.Format("{0} {1} - {2:c2} / hour", wr.FirstName, wr.LastName, wr.hourMoney);
                string listSort = String.Format("{0} {1} - {2:c2} / hour", workersList[counter].FirstName, workersList[counter].LastName, workersList[counter].hourMoney);

                Assert.AreEqual(linqSort, listSort);
                counter++;
            }
        }

        [TestMethod]
        public void TestHuman3() // Test Merge List
        {
            var mergeSortedLinq =
                from hum in mergedLists
                orderby hum
                select hum;

            int counter = 0;
            mergedLists.Sort();
            foreach (var hum in mergeSortedLinq)
            {
                string linqSort = String.Format("{0} {1}", hum.FirstName, hum.LastName);
                string listSort = String.Format("{0} {1}", mergedLists[counter].FirstName, mergedLists[counter].LastName);

                Assert.AreEqual(linqSort, listSort);
                counter++;
            }
        }
    }
}
