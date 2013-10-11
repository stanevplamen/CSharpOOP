using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeHumans
{
    public class Student : Human, IComparable<Student>
    {
        private int grade;

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 0 || grade > 14)
                {
                    throw new ArgumentException("Invalid grade.");
                }
                this.grade = value;
            }
        }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int CompareTo(Student other)
        {
            return this.Grade.CompareTo(other.Grade);
        }
    }
}
