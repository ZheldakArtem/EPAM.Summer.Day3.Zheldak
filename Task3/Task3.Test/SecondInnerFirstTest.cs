using SecondInner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task3.Test
{
    public class SecondInnerFirstTest
    {
        [TestCase()]
        int InsertMethodTestWithNormalArgument(int first, int second, int startPos, int endPos)
        {
            return SecondInnerFirst.InsertMethod(first, second, startPos, endPos);
        }
    }
}
