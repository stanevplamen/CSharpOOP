using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray64NS
{
    class MainDemo
    {
        static void Main()
        {
            BitArray64 bits = new BitArray64();

            bits[0] = 1;
            bits[5] = 1;
            bits[5] = 0;
            bits[25] = 1;
            bits[31] = 1;
            bits[61] = 1;

            for (int i = 0; i < BitArray64.allBits; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, bits[i]);
            }

            // test foreach
            Console.Write("Test Foreach: " + "Bits = ");
            foreach (var bit in bits)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            // inverted test of indexer
            Console.Write("Test Indexer: " + "Bits = ");
            for (int i = BitArray64.allBits - 1; i >= 0; i--)
            {
                Console.Write(bits[i]);
            }
            Console.WriteLine();

            // test ToString
            Console.WriteLine("Test ToString: " + bits);

            // test operators
            BitArray64 bits1 = new BitArray64();
            bits1[0] = 1;
            bits1[5] = 1;
            bits1[5] = 0;
            bits1[25] = 1;
            BitArray64 bits2 = new BitArray64();
            bits2[0] = 1;
            bits2[5] = 1;
            bits2[5] = 0;
            bits2[26] = 1;

            if (bits1 == bits2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}\nand\n\n{1}", bits1, bits2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("are equal arrays\n\n");
            }
            else if (bits1 != bits2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}\nand\n{1}", bits1, bits2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("are NOT equal arrays\n");
            }
            bits2[26] = 0;
            bits2[25] = 1;
            if (bits1 == bits2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}\nand\n\n{1}", bits1, bits2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("are equal arrays\n\n");
            }
            else if (bits1 != bits2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}\nand\n{1}", bits1, bits2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("are NOT equal arrays\n");
            }
        }
    }
}
