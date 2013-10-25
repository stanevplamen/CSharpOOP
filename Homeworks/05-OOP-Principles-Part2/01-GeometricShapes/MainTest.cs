using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class MainTest
    {
        static void Main()
        {
            Shape[] shapesArray1 = new Shape[]
		    {
			    new Rectangle() { Width = 2, Height = 3 },
			    new Circle() { Radius = 5 },
			    new Circle() { Radius = 2 },
			    new Triangle() { Width = 3, Height = 6 },
			    new Triangle() { Width = 4, Height = 7 },
                new Square() { Side = 4},
		    };
            foreach (var sh in shapesArray1)
            {
                Console.WriteLine("Figure = {0} surface = {1:F2}", sh.GetType().Name.PadRight(9, ' '), sh.CalculateSurface());
            }
            Console.WriteLine("============= // == // ===============");
            Shape[] shapesArray2 = new Shape[]
		    {
			    new Rectangle(2,3),
			    new Circle(5),
			    new Circle(2),
			    new Triangle(3,6),
			    new Triangle(4,7),
                new Square(4),
		    };
            foreach (var sh in shapesArray2)
            {
                Console.WriteLine("Figure = {0} surface = {1:F2}", sh.GetType().Name.PadRight(9, ' '), sh.CalculateSurface());
            }
        }
    }
}
