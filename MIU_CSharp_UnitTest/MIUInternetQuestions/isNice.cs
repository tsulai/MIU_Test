using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isNice
    {
        [TestMethod]
        public void isNice1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isNice(new int[] { 2, 10, 9, 3 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isNice(new int[] { 2, 2, 3, 3, 3 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isNice(new int[] { 1, 1, 1, 2, 1, 1 }), 1, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isNice(new int[] {0, 1, 1}), 1, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isNice(new int[] { 3, 4, 5, 7 }), 0, "TEST 5");
        }
    }
}
