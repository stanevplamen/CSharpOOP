using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    class Program
    {
        static Engine GetEngineInstance()
        {
            return new EngineExtended();
        }

        static void Main(string[] args)
        {
            //This section is compiled in Debug Mode only.
#if DEBUG
            Console.SetIn(new System.IO.StreamReader("input.txt"));
#endif
            Engine engine = GetEngineInstance();

            string command = Console.ReadLine();
            while (command != "end")
            {
                engine.ExecuteCommand(command);
                command = Console.ReadLine();
            }
        }
    }
}
