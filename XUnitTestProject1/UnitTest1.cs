using EClass;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expectedResult = 1;
            //Some Process

            var actualResult = 1;
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
