using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SBSubstrings
{
    class MainTest
    {
        static void Main()
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Some words to be put into the string builder");

            StringBuilder sb2 = new StringBuilder();
            int startIndex = 5;
            int subLength = 5;

            sb2 = sb1.Substring(startIndex, subLength);
            Console.WriteLine(sb1);
            Console.WriteLine(sb2);
        }
    }
}
