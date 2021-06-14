using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isHollow
    {
        [TestMethod]
        public void isHollow1()
        {
           Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isHollow(new int[] { 1, 2, 0, 0, 0, 3, 4 }), 1, "TEST 1");
           Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isHollow(new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 0, 2, 1, 2, 18 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isHollow(new int[] { 1, 2, 0, 0, 3, 4 }), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isHollow(new int[] { 1, 2, 0, 0, 0, 3, 4, 5 }), 0, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isHollow(new int[] { 3, 8, 3, 0, 0, 0, 3, 3 }), 0, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isHollow(new int[] { 1, 2, 0, 0, 0, 3, 4, 0 }), 0, "TEST 6");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isHollow(new int[] { 0, 1, 2, 0, 0, 0, 3, 4 }), 0, "TEST 7");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isHollow(new int[] { 0, 0, 0 }), 1, "TEST 8");
        }
    }
}
