using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isDual
    {
        [TestMethod]
        public void isDual1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDual(new int[] { 1, 2, 1, 3, 3, 2 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDual(new int[] { 2, 5, 2, 5, 5 }), 0, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDual(new int[] { 3, 1, 1, 2, 2 }), 0, "TEST 3");
        }
    }
}
