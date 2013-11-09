using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometryAPI
{
    class MainDemo
    {
        private static FigureController GetFigureController()
        {
            return new FigureControllerExtended();
        }

        static void Main(string[] args)
        {
            //This section is compiled in Debug Mode only.
#if DEBUG
            Console.SetIn(new System.IO.StreamReader("input.txt"));
#endif

            var figController = GetFigureController();

            int figCreationsCount = int.Parse(Console.ReadLine());
            int endCommandsCount = 0;

            while (endCommandsCount < figCreationsCount)
            {
                string currentToken = Console.ReadLine();
                figController.ExecuteCommand(currentToken);
                if (figController.EndCommandExecuted)
                {
                    endCommandsCount++;
                }
            }
        }
    }
}
