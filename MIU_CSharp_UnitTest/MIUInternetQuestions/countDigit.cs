using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class countDigit
    {
        [TestMethod]
        public void countDigit1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.countDigit(32121, 1), 2, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.countDigit(33331, 3), 4, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.countDigit(33331, 6), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.countDigit(3, 3), 1, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.countDigit(-543, 3), -1, "TEST 5");
        }
    }
}
