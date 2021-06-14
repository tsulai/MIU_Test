using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isDigitSum
    {
        [TestMethod]
        public void isDigitSum1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDigitSum(32121,10), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDigitSum(32121, 9), 0, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDigitSum(13, 6), 1, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDigitSum(3, 3), 0, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDigitSum(-543, 3), -1, "TEST 5");
        }
    }
}
