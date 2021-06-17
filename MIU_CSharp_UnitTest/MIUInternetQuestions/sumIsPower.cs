using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class sumIsPower
    {
        [TestMethod]
        public void sumIsPower1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.sumIsPower(new int[] { 8, 8, 8, 8 }), true, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.sumIsPower(new int[] { 8, 8, 8 }), false, "TEST 2");
        }
    }
}
