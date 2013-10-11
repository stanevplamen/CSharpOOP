using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class SchoolClass : ICommented
    {
        public readonly HashSet<Teacher> SetOfTeachers = new HashSet<Teacher>();
        public readonly HashSet<Student> SetOfStudents = new HashSet<Student>();
        private string classID;
        public string Comment { get; set; }

        public string ClassID
        {
            get
            {
                return this.classID;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid class ID.");
                }
                this.classID = value;
            }
        }

        public SchoolClass(string classID)
        {
            this.ClassID = classID;
        }

        public void AddTeacher(Teacher newTeacher)
        {
            if (!SetOfTeachers.Contains(newTeacher))
            {
                this.SetOfTeachers.Add(newTeacher);
            }
        }

        public void AddStudent(Student newStudent)
        {
            if (!SetOfStudents.Contains(newStudent))
            {
                this.SetOfStudents.Add(newStudent);
            }
        }

        public override string ToString()
        {
            StringBuilder outputSB = new StringBuilder();
            outputSB.AppendFormat("The class {0} has the following teachers:", this.classID);
            foreach (var teacher in SetOfTeachers)
            {
                outputSB.AppendFormat("\nName: {0} {1}, Diciplines: ", teacher.FirstName, teacher.LastName);
                foreach (var dic in teacher.SetOfDiciplines)
                {
                    outputSB.AppendFormat("{0} ", dic.Name);
                }
            }
            return outputSB.ToString();
        }
    }
}
