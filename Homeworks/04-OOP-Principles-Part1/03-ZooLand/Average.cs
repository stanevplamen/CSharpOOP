using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand
{
    public class Average
    {
        public static double GetAverage(Animal[] zooObjects)
        {
            double sum = 0;
            double length = (double)zooObjects.Length;
            for (int i = 0; i < zooObjects.Length; i++)
            {
                sum = sum + (double)zooObjects[i].Age;
            }

            return sum / length;           
        }
    }
}
