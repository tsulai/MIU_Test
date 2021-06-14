using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isTwinPrime
    {
        [TestMethod]
        public void isTwinPrime1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isTwinPrime(5), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isTwinPrime(7), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isTwinPrime(53), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isTwinPrime(9), 0, "TEST 4");
        }
    }
}
