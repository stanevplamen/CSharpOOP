using System;
using System.Collections.Generic;
using System.Linq;

namespace DivideBy
{
    class MainTest
    {
        static void Main()
        {
            int[] myArray = { 10, 20, 21, 42, 3, 5, 33, 233, 126, 1323, 378, 344 };
            //lambda
            int[] result = myArray.Where(x => x % 7 == 0 && x % 3 == 0).ToArray();
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var selectedNumsLambda = myArray.Where(x => x % 21 == 0);
            foreach (var num in selectedNumsLambda)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //ling
            int[] result2 = (from num in myArray where num % 7 == 0 && num % 3 == 0 select num).ToArray();
            foreach (int item in result2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var selectedNumsLinq =
              from num in myArray
              where num % 21 == 0
              select num;
            foreach (var num in selectedNumsLinq)
            {
                Console.WriteLine(num);
            }
        }
    }
}
