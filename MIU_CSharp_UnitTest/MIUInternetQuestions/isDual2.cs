using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isDual2
    {
        [TestMethod]
        public void isDual2_1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDual2(new int[] { 1, 2, 3, 0 }), 1, "TEST 1");
             Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDual2(new int[] { 1, 2, 2, 1, 3, 0 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDual2(new int[] { 1, 1,2,2 }), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDual2(new int[] { 1,2,1 }), 0, "TEST 4");
        }
    }
}
