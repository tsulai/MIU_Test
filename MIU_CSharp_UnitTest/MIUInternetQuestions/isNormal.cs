using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isNormal
    {
        [TestMethod]
        public void isNormal1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isNormal(1), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isNormal(2), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isNormal(3), 1, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isNormal(4), 1, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isNormal(5), 1, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isNormal(7), 1, "TEST 6");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isNormal(8), 1, "TEST 7");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isNormal(6), 0, "TEST 8");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isNormal(9), 0, "TEST 9");
        }
    }
}
