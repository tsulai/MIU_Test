using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isTwin
    {
        [TestMethod]
        public void isTwin1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isTwin(new int[] { 3, 5, 8, 10, 27 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isTwin(new int[] { 11, 9, 12, 13, 23 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isTwin(new int[] { 5, 3, 14, 7, 18, 67 }), 1, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isTwin(new int[] { 13, 14, 15, 3, 5 }), 0, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isTwin(new int[] { 1, 17, 8, 25, 67 }), 0, "TEST 5");

        }
    }
}
