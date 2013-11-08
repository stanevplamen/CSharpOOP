using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademyGlobal
{
    public class LocalCourse : Course, ILocalCourse
    {
        public LocalCourse(string name, ITeacher teacher, string lab)
            : base (name, teacher)
        {
            this.Lab = lab;
        }

        private string lab;
        public string Lab
        {
            get
            {
                return lab;
            }
            set
            {
                this.lab = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" Lab={0}", this.Lab);
        }
    }
}
