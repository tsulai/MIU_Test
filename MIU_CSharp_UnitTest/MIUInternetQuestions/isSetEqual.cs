using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isSetEqual
    {
        [TestMethod]
        public void isSetEqual1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isSetEqual(new int[] { 1, 9, 12 }, new int[] { 12, 1, 9 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isSetEqual(new int[] { 1, 9, 12 }, new int[] { 9, 1, 9, 12, 9, 12, 1, 9}), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isSetEqual(new int[] { 1, 7, 8 }, new int[] { 1, 7, 1 }), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isSetEqual(new int[] { 1, 7, 8 }, new int[] { 1, 7, 6 }), 0, "TEST 4");
        }
    }
}
