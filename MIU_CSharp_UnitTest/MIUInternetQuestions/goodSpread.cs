using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class goodSpread
    {
        [TestMethod]
        public void goodSpread1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.goodSpread(new int[] { 2, 1, 2, 5, 2, 1, 5, 9 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.goodSpread(new int[] { 3, 1, 3, 1, 3, 5, 5, 3 }), 0, "TEST 2");
        }
    }
}
