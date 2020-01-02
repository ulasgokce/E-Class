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
           var expectedResult = true;
           var actualResult = AddQuestion.AddOrUpdateQuestion("soru", "Mantık", "cevap1", "cevap2", "cevap3", "cevap4");

            Assert.Equal(expectedResult.ToString(), actualResult.ToString()) ;
        }
        [Fact]
        public void Test2()
        {
            var expectedResult = true;
            var actualResult = AddUser.AddOrUpdateUser("ogrenci4","123","Ogrenci");

            Assert.Equal(expectedResult.ToString(), actualResult.ToString());
        }

        [Fact]
        public void Test3()
        {
            var expectedResult = 0;
            var actualResult = GetIn.GetInside("ulasgokce", "123");

            Assert.Equal(expectedResult.ToString(), actualResult.ToString());
        }
    }
}
