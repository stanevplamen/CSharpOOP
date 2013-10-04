using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNames
{
    public class Student
    {
        #region Fields

        private string name;
	    private int age;
        private string gender;

        #endregion Fields

        #region Properties

        public string Name
	    {
		    get 
		    {
			    return this.name;
		    }
		    set
		    {
			    if (value == null)
			    {
				    throw new ArgumentException("Invalid name.");
			    }
			    this.name = value;
		    }
	    }

	    public int Age
	    {
		    get 
		    {
			    return this.age;
		    }
		    set
		    {
			    if (value < 0 || value > 120)
			    {
				    throw new ArgumentOutOfRangeException("Invalid age.");
			    }
			    this.age = value;
		    }
	    }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid gender.");
                }
                this.gender = value;
            }
        }

        #endregion Properties
     
	    public Student(string name, int age, string gender)
	    {
		    this.Name = name;
		    this.Age = age;
            this.Gender = gender;
	    }

        #region Methods

        public override string ToString()
	    {
		    return string.Format("Student:{0}, age: {1}, gender: {2}", this.Name, this.Age, this.Gender);
        }

        #endregion Methods
    }
}
