using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class hasKSmallFactors
    {
        [TestMethod]
        public void hasKSmallFactors1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.hasKSmallFactors(7,30), true, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.hasKSmallFactors(6, 14), false, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.hasKSmallFactors(6, 30), false, "TEST 3");
        }
    }
}
