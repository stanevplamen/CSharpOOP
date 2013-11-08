using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademyGlobal
{
    public class Teacher : ITeacher
    {
        public Teacher(string name)
        {
            this.Name = name;
            coursesOfTeacher = new List<ICourse>();
        }

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        //public List<ICourse> CoursesOfTeacher
        //{
        //    get
        //    {
        //        return this.coursesOfTeacher;
        //    }
        //}

        private List<ICourse> coursesOfTeacher;
        public void AddCourse(ICourse course)
        {
            coursesOfTeacher.Add(course);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Teacher Name={0};", this.Name);
            if (coursesOfTeacher.Count > 0)
            {
                sb.AppendFormat(" Courses=[");

                foreach (var course in coursesOfTeacher)
                {
                    sb.AppendFormat("{0}, ", course.Name);
                }

                sb.AppendFormat("\b\b] ");
            }

            return sb.ToString();
        }
    }
}
