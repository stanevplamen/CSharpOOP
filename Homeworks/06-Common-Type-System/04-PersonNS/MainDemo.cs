using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNS
{
    class MainDemo
    {
        static void Main()
        {
            Person ivan1 = new Person("Ivan", 24);
            Person ivan2 = new Person("Ivan");
            Console.WriteLine(ivan1);
            Console.WriteLine(ivan2);
            ivan2.Age = 37;
            Console.WriteLine(ivan2);
        }
    }
}
