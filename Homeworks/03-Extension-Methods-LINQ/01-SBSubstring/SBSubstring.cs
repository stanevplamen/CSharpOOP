using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SBSubstrings
{
    public static class SBSubstring
    {
        public static StringBuilder Substring(this StringBuilder inputSB, int index, int length)
        {
            StringBuilder resultSB = new StringBuilder();

            if (index + length > inputSB.Length || index < 0)
            {
                throw new ArgumentOutOfRangeException("The index and length are out of the StringBuilder`s size");
            }

            int endIndex = index + length;

            for (int i = index; i < endIndex; i++)
            {
                resultSB.Append(inputSB[i]);
            }

            return resultSB;
        }
    }
}
