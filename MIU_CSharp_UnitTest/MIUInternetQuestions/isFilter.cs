using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isFilter
    {
        [TestMethod]
        public void isFilter1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isFilter(new int[] { 1, 2, 3, 9, 6, 11 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isFilter(new int[] { 3, 4, 6, 7, 14, 16 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isFilter(new int[] { 1, 2, 3, 4, 10, 11, 13 }), 1, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isFilter(new int[] { 3, 6, 5, 5, 13, 6, 13 }), 1, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isFilter(new int[] { 9, 6, 18 }), 0, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isFilter(new int[] { 4, 7, 13 }), 0, "TEST 6");
        }
    }
}
