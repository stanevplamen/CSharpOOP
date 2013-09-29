using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericListNamespace
{
    class MainTests
    {
        static void Main()
        {
            GenericList<decimal> firstList = new GenericList<decimal>();
            GenericList<decimal> secondList = new GenericList<decimal>(20);
            firstList.Add(2.33m);
            firstList.Add(3.33m);
            firstList.Add(4.33m);
            firstList.Add(5.33m);
            firstList.Add(6.33m);
            firstList.Add(6.33m);
            firstList.Add(6.33m);
            firstList.Add(6.33m);
            firstList.Add(6.33m);
            firstList.Add(6.33m);
            secondList[1] = 4.44m;
            secondList[2] = 5.44m;
            secondList[3] = 6.44m;
            secondList[4] = 7.44m;
            secondList[5] = 8.44m;
            secondList[6] = 10.44m;
            secondList[19] = 9.44m; 
            // secondList[21] = 9.44m; ArgumentOutOfRangeException

            secondList.InsertAt(9.44m, 21);
            secondList.InsertAt(9.44m, 18);
            secondList.InsertAt(9.44m, 22);

            secondList.Add(-5.33m);

            firstList.RemoveAt(0);

            int indexOfOne = firstList.FindElement(0, 2.33m);
            int indexOfTwo = firstList.FindElement(0, 3.33m);

            firstList.Clear();

            string listString = secondList.ToString();

            decimal currentMax = secondList.Max<decimal>();
            decimal currentMix = secondList.Min<decimal>();
        }
    }
}
