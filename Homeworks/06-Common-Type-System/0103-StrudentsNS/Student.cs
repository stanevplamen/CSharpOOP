using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsNS.Enums;

namespace StudentsNS
{
    public class Student : IComparable<Student>, ICloneable
    {
        #region Fields

        private const int minNameSymbols = 2;
        private const int minAddressSymbols = 11;
        private const int minPhoneSymbols = 11;

        private string firstName;
        private string middleName;
        private string lastName;
        private long socialSocietyNumber;
        private string address;
        private string phoneNumber;

        private Univercity university;
        private Faculty faculty;
        private Specialty specialty;

        #endregion

        #region Properties

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if ((value != null && value.Length >= minNameSymbols) || value == null)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new FormatException(String.Format("Invalid name {0}", this.firstName));
                }
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                if ((value != null && value.Length >= minNameSymbols) || value == null)
                {
                    this.middleName = value;
                }
                else
                {
                    throw new FormatException(String.Format("Invalid name {0}", this.middleName));
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if ((value != null && value.Length >= minNameSymbols) || value == null)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new FormatException(String.Format("Invalid name {0}", this.lastName));
                }
            }
        }

        public long SocialSocietyNumber
        {
            get { return this.socialSocietyNumber; }
            set
            {
                if ((value >= 0 && value < 1000000000000000) || value == null)
                {
                    this.socialSocietyNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid social sociaty number");
                }
            }
        }

        public string Address
        {
            get { return this.address; }
            set
            {
                if ((value != null && value.Length >= minAddressSymbols) || value == null)
                {
                    this.address = value;
                }
                else
                {
                    throw new FormatException(String.Format("Invalid name {0}", this.address));
                }
            }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                if ((value != null && value.Length >= minPhoneSymbols) || value == null)
                {
                    this.phoneNumber = value;
                }
                else
                {
                    throw new FormatException(String.Format("Invalid name {0}", this.phoneNumber));
                }
            }
        }

        public Univercity Uni
        {
            get { return university; }
            set { university = value; }
        }

        public Faculty Fac
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public Specialty Spe
        {
            get { return specialty; }
            set { specialty = value; }
        }

        #endregion

        #region Constructors

        public Student(string firstName, string middleName, string lastName, long socialSocietyNumber, string address,
            string phoneNumber, Univercity univercity, Faculty faculty, Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSocietyNumber = socialSocietyNumber;
            this.Address = address;
            this.PhoneNumber = phoneNumber;

            this.Uni = university;
            this.Fac = faculty;
            this.Spe = specialty;
        }

        #endregion

        #region Methods

        object ICloneable.Clone()  // Implicit interface implementation
        {
            return this.Clone();
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student == null)
            {
                return false;
            }

            if (this.SocialSocietyNumber != student.SocialSocietyNumber)
            {
                return false;
            }
            return true;
        }


        public int CompareTo(Student other)
        {
            int resultOfCompare = FirstName.CompareTo(other.FirstName);
            if (resultOfCompare == 0)
            {
                resultOfCompare = MiddleName.CompareTo(other.MiddleName);
            }
            if (resultOfCompare == 0)
            {
                resultOfCompare = LastName.CompareTo(other.LastName);
            }
            if (resultOfCompare == 0)
            {
                resultOfCompare = SocialSocietyNumber.CompareTo(other.SocialSocietyNumber);
            }

            return resultOfCompare;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ SocialSocietyNumber.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("Student: {0} {1} {2}\nSSN: {3}\nAddress: {4}\nPhone number: {5}\nUnivercity: {6}, Faculty: {7}, Specialty: {8}\n",
                this.FirstName, this.MiddleName, this.LastName, this.SocialSocietyNumber,
                this.Address, this.PhoneNumber,
                this.Uni, this.Fac, this.Spe);
        }

        public Student Clone() // Deep cloning 
        {
            Student clonedStudent = new Student(
                 this.FirstName,
                 this.MiddleName,
                 this.LastName,
                 this.SocialSocietyNumber,
                 this.Address,
                 this.PhoneNumber,
                 this.Uni,
                 this.Fac,
                 this.Spe);

            return clonedStudent;
        }

        #endregion
    }
}
