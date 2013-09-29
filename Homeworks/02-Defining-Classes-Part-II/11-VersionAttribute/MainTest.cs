using System;
using System.Collections.Generic;
using System.Reflection;

namespace VersionAttributes
{
    [VersionAttribute(2, 12, 11)]
    class MainTest
    {
        static void Main()
        {
            Type type = typeof(MainTest);
            object[] versionAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAttribute in versionAttributes)
            {
                Console.WriteLine("The version of the Attribute`s class MainTest is {0}.{1},{2}", 
                    versionAttribute.Major, versionAttribute.Minor, versionAttribute.Minest);
            }
        }
    }
}
