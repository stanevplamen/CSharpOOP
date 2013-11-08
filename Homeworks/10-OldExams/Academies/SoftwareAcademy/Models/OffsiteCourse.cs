using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademyGlobal
{
    public class OffsiteCourse : Course, IOffsiteCourse
    {
        public OffsiteCourse(string name, ITeacher teacher, string town) 
            : base (name, teacher)
        {
            this.Town = town;
        }

        private string town;
        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                this.town = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + String.Format(" Town={0}", this.Town);
        }
    }
}
