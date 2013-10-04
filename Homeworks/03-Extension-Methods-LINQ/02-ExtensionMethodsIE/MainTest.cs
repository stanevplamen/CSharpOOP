using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethodsIE
{
    class MainTest
    {
        static void Main()
        {
            List<long> numbers = new List<long>() 
            { 1, 2, 3, 4, 5, 6, 44, -33, 22, 77, 8888, 44444, 232223, 442322324, 0, -33, -434, -4343, -4343, -44 };
            
            long sum = numbers.Sum<long>();
            Console.WriteLine(sum);
            long product = numbers.Product<long>();
            Console.WriteLine(product);
            long max = numbers.Max<long>();
            Console.WriteLine(max);
            long min = numbers.Min<long>();
            Console.WriteLine(min);
            long average = numbers.Average<long>();
            Console.WriteLine(average);

            List<string> strList = new List<string>() { "a", "b", "c", "z" };
            string sumTest = strList.Sum<string>();
            Console.WriteLine(sumTest);

            List<char> charList = new List<char>() { 'a', 'b', 'c', 'z' };
            char maxTest = charList.Max<char>();
            Console.WriteLine(maxTest);


            long minSure = numbers.OrderByDescending(item => item).Last();
            long maxSure = numbers.OrderByDescending(item => item).First();

            Console.WriteLine(minSure);
            Console.WriteLine(maxSure);
        }
    }
}
