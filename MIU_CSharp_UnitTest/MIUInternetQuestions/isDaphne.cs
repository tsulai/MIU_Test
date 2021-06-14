using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isDaphne
    {
        [TestMethod]
        public void isDaphne1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDaphne(new int[] { 2,4,2 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDaphne(new int[] { 1,3,17,-5 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDaphne(new int[] { 3, 2, 5 }), 0, "TEST 3");
        }
    }
}
