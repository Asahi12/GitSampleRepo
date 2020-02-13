using System;
using Xunit;
using MainProj;

namespace UTProj
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(0, 0, 0)]
        public void CalcNumTest1(int a, int b, int c)
        {
            Calc c1 = new Calc();
            Assert.Equal(c, c1.CalcNum(a, b));
        }
    }
}
