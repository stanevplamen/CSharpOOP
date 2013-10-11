using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class Teacher : Person, ICommented
    {
        public string Comment { get; set; }

        public readonly HashSet<Dicipline> SetOfDiciplines = new HashSet<Dicipline>();

        public Teacher(string firstName, string lastName, int age, string gender, Fitness health)
            : base(firstName, lastName, age, gender, health)
        {
        }

        public void AddDicipline(Dicipline newObject)
        {
            if (!SetOfDiciplines.Contains(newObject))
            {
                this.SetOfDiciplines.Add(newObject);
            }
        }

        public override string ToString()
        {
            StringBuilder outputSB = new StringBuilder();
            outputSB.AppendFormat("The diciplines of {0} {1} are: ", this.FirstName, this.LastName);
            foreach (var dic in SetOfDiciplines)
            {
                outputSB.AppendFormat("{0}, ", dic.Name);
            }
            outputSB.AppendFormat("\b\b;");
            return outputSB.ToString();
        }
    }
}
