using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeHumans
{
    class MainTest
    {
        static void Main()
        {
            List<Student> studentsList = new List<Student>();
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

            Console.WriteLine("Sort students in ascending sort by grade");
            var studentsAscending =
                from st in studentsList
                orderby st
                select st;

            foreach (var st in studentsAscending)
            {
                Console.WriteLine("{0} {1}, grade {2}", st.FirstName, st.LastName, st.Grade);
            }

            Console.WriteLine("\n\nSort workers by money per hour");

            List<Worker> workersList = new List<Worker>();
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

            var workersMoneyPerHourList =
                from wr in workersList
                orderby wr
                select wr;

            foreach (var wr in workersMoneyPerHourList)
            {
                Console.WriteLine("{0} {1} - {2:c2} / hour", wr.FirstName, wr.LastName, wr.hourMoney);
            }

            List<Human> mergedLists = new List<Human>();
            foreach (var item in studentsList)
            {
                mergedLists.Add(item);
            }
            foreach (var item in workersList)
            {
                mergedLists.Add(item);
            }

            mergedLists.Sort();
            Console.WriteLine("\n\nSorted workers and students by name are:");
            foreach (var item in mergedLists)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
        }
    }
}
