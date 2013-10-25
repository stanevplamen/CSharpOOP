using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class MainDemo
    {
        static void Main()
        {
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            #region Perform Int Exception

            int start = 1;
            int end = 100;

            try
            {
                PerformIntException(start, end, 30);
                Console.WriteLine("The number {0} is in range", 30);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine("{0}, The number {1} is NOT in range", e.Message, 30);
            }

            try
            {
                PerformIntException(start, end, 102);
                Console.WriteLine("The number {0} is in range", 102);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine("{0}, The number {1} is NOT in range", e.Message, 102);
            }
            PerformIntException(start, end, 30);

            #endregion Perform Int Exception


            #region Perform Date Exception

            DateTime firstDate = new DateTime(2015, 12, 31);

            try
            {
                PerformDateException(startDate, endDate, firstDate);
                Console.WriteLine("The date {0:d.MM.yy г.} is in range", firstDate);
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine("{0}, The date {1:d.MM.yy г.} is NOT in range", e.Message, firstDate);
            }

            DateTime secondDate = new DateTime(2012, 12, 31);

            try
            {
                PerformDateException(startDate, endDate, secondDate);
                Console.WriteLine("The date {0:d.MM.yy г.} is in range", secondDate);
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine("{0}, The date {1:d.MM.yy г.} is NOT in range", e.Message, secondDate);
            }

            #endregion Perform Date Exception

        }

        private static void PerformDateException(DateTime startDate, DateTime endDate, DateTime currenttDate)
        {
            if (currenttDate < startDate || currenttDate > endDate)
            {
                throw new InvalidRangeException<DateTime>(string.Format("Invalid range exception, range: ({0:d.MM.yy г.} - {1:d.MM.yy г.})", startDate, endDate), startDate, endDate);
            }
        }

        private static void PerformIntException(int start, int end, int number)
        {
            if (number < start || number > end)
            {
                throw new InvalidRangeException<int>(string.Format("Invalid range exception, range: ({0} - {1})", start, end), start, end);
            }
        }
    }
}
