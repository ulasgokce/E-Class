using EClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            var expectedResult = true;
            var actualResult = AddQuestion.AddOrUpdateQuestion("soru", "Mantık", "cevap1", "cevap2", "cevap3", "cevap4");

            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }
        [TestMethod]
        public void Test2()
        {
            var expectedResult = true;
            var actualResult = AddUser.AddOrUpdateUser("ogrenci4", "123", "Ogrenci");

            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }

        [TestMethod]
        public void Test3()
        {
            var expectedResult = 0;
            var actualResult = GetIn.GetInside("ulasgokce", "123");

            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString());
        }
    }
}
