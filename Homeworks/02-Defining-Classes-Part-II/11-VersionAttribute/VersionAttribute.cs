using System;

namespace VersionAttributes
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface
    | AttributeTargets.Enum | AttributeTargets.Method)]

    public class VersionAttribute : Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }
        public int Minest { get; private set; }

        public VersionAttribute(int major, int minor, int minest)
        {
            this.Major = major;
            this.Minor = minor;
            this.Minest = minest;
        }
    }
}
