using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademyGlobal
{
    public abstract class Course : ICourse
    {
        public Course(string name, ITeacher teacher)          
        {
            this.Name = name;
            this.Teacher = teacher;
            topics = new List<string>();
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

        private ITeacher teacher;              
        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }

        private List<string> topics;
        public void AddTopic(string topic)
        {
            topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}: Name={1};", this.GetType().Name, this.Name);

            if (Teacher != null)
            {
                sb.Append(" ");
                sb.AppendFormat("Teacher={0}", Teacher.Name);

                if (topics.Count > 0)
                {
                    sb.AppendFormat(" Topics=[");

                    foreach (var tpc in topics)
                    {
                        sb.AppendFormat("{0}, ", tpc);
                    }

                    sb.AppendFormat("\b\b];");

                }
            }

            return sb.ToString();
        }
    }
}
