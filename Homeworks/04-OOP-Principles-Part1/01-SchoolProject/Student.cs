using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class Student : Person, ICommented
    {
        public int StudentNumber { get; private set; }
        public string ClassNumber { get; private set; }
        public string Comment { get; set; }

        public Student(string firstName, string lastName, int age, string gender, Fitness health, int studentNumb, string classNumb)
            : base(firstName, lastName, age, gender, health)
        {
            this.StudentNumber = studentNumb;
            this.ClassNumber = classNumb;
        }
    }
}
