using SecondInner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Collections;

namespace Task3.Test
{
    public class SecondInnerFirstTest
    {
        public IEnumerable<TestCaseData> DataParam
        {
            get
            {
                yield return new TestCaseData(3, 7, 7, 5).Returns(227);
                yield return new TestCaseData(27, 48, 18, 1).Returns(123);
                yield return new TestCaseData(int.MaxValue, 20, 18, 1).Returns(2147483647);
                yield return new TestCaseData(4, 5, -1, 4).Throws(typeof(ArgumentException));
                yield return new TestCaseData(4, 7, 7, 10).Throws(typeof(ArgumentException));
                yield return new TestCaseData(15, 5, -4, -1).Throws(typeof(ArgumentOutOfRangeException));
            }
        }

        [Test, TestCaseSource(nameof(DataParam))]
        public int InsertMethodTestWithNormalArgument(int first, int second, int endPos, int startPos)
        {
            return SecondInnerFirst.InsertMethod(first, second, endPos, startPos);
        }
    }
}
