using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class Dicipline : ICommented
    {
        private string name;
        private int hoursPerWeek;
        public string Comment { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == String.Empty)
                {
                    throw new ArgumentException("Invalid dicipline name.");
                }
                this.name = value;
            }
        }

        public int HoursPerWeek
        {
            get
            {
                return this.hoursPerWeek;
            }
            set
            {
                if (value < 0 || value > 84)
                {
                    throw new ArgumentOutOfRangeException("Invalid hours` assignment");
                }
                this.hoursPerWeek = value;
            }
        }

        public Dicipline(string name, int hoursPerWeek)
        {
            this.Name = name;
            this.HoursPerWeek = hoursPerWeek;
        }
    }
}
