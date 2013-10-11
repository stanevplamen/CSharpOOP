using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeHumans
{
    public class Worker : Human, IComparable<Worker>
    {
        #region Private Fields

        private int weekSalary;
        private int dailyWorkHours;
        public double hourMoney { get; set; }

        #endregion

        #region Properties

        public int WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value > 2100)
                {
                    throw new ArgumentException("Too big salary for our company");
                }
                this.weekSalary = value;
            }
        }

        public int DailyWorkHours
        {
            get
            {
                return this.dailyWorkHours;
            }
            set
            {
                if (value < 0 && value > 192)
                {
                    throw new ArgumentException("Not possible value of working hours per week");
                }
                this.dailyWorkHours = value;
            }
        }

        #endregion

        #region Constructor

        public Worker(string firstName, string lastName, int weekSalary, int dailyWorkHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.DailyWorkHours = dailyWorkHours;
            this.hourMoney = MoneyPerHour();
        }

        #endregion

        #region Methods

        public double MoneyPerHour()
        {
            double hourMoney = (weekSalary / 7) / dailyWorkHours;
            return hourMoney;
        }

        public int CompareTo(Worker other)
        {
            return this.hourMoney.CompareTo(other.hourMoney);
        }

        #endregion
    }
}
