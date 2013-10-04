using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentNames
{
    public class StudentsArchive
    {
        #region Field and Constructor

        private List<Student> studentsList;

        public StudentsArchive()
        {
            this.studentsList = new List<Student>();
        }

        #endregion

        #region Methods

        public void Add(Student x)
        {
            studentsList.Add(x);
        }

        public void Clear()
        {
            studentsList.Clear();
        }

        public string NameSpecialToString()
        {
            List<Student> selectedStudents = studentsList.FindAll(TakeName);
            StringBuilder sb = new StringBuilder();
            foreach (var st in selectedStudents)
            {
                sb.AppendFormat("Student:{0}, age: {1}, gender: {2}\n", st.Name, st.Age, st.Gender);
            }
            return sb.ToString();
        }

        internal bool TakeName(Student x)
        {
            int divIndex = x.Name.IndexOf(' ');
            string firstName = x.Name.Substring(0, divIndex);
            string secondName = x.Name.Substring(divIndex + 1, x.Name.Length - divIndex - 1);
            int c = string.Compare(firstName, secondName);

            if (c == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string AgeSpecialToString()
        {
            List<Student> selectedStudents = studentsList.FindAll(TakeAge);
            StringBuilder sb = new StringBuilder();
            foreach (var st in selectedStudents)
            {
                sb.AppendFormat("Student:{0}, age: {1}, gender: {2}\n", st.Name, st.Age, st.Gender);
            }
            return sb.ToString();
        }

        public static bool TakeAge(Student x)
        {
            if (x.Age >= 18 && x.Age <= 24)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string DisplayOrderedNamesLambda()
        {
            StringBuilder sb = new StringBuilder();
            var selectedStudents = studentsList.OrderBy(st => st.Name); //studentsList.OrderBy(st => st.FirstName).ThenBy(st => st.LastName);
            foreach (var x in selectedStudents)
            {
                sb.AppendFormat("{0}\n", x.Name);
            }
            return sb.ToString();
        }

        public string DisplayOrderedNamesLinq()
        {
            StringBuilder sb = new StringBuilder();
            var selectedStudents = 
            from st in studentsList
            orderby st.Name // st.LastName, st.FirstName
            select st;
            foreach (var x in selectedStudents)
            {
                sb.AppendFormat("{0}\n", x.Name);
            }
            return sb.ToString();
        }

        #endregion Methods
    }
}
