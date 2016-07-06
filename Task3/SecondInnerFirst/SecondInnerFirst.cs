using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondInner
{
    public static class SecondInnerFirst
    {
        private const int MaxBit = 30;
        /// <summary>
        /// The method for inserting the second number of the first.
        /// </summary>
        /// <param name="first">The first value.</param>
        /// <param name="second">The second value.</param>
        /// <param name="endPos">Start number of bit.</param>
        /// <param name="startPos">End number of bit.</param>
        /// <returns></returns>
        public static int InsertMethod(int first, int second, int endPos, int startPos)
        {
            if (startPos < 0 || endPos > MaxBit)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (endPos < startPos)
                throw new ArgumentException();

            int sizeInsert = (int)(Math.Pow(2, endPos - startPos + 1) - 1);
            second = second & sizeInsert;
            second = second << startPos;

            return first | second;

        }
    }
}
