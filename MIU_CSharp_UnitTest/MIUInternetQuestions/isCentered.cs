using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isCentered
    {
        [TestMethod]
        public void isCentered1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isCentered(new int[] { 5, 3, 3, 4, 5 }), 0, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isCentered(new int[] { 3, 2, 1, 4, 5 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isCentered(new int[] {3, 2, 1, 4, 1}), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isCentered(new int[] {3, 2, 1, 1, 4, 6}), 0, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isCentered(new int[] {}), 0, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isCentered(new int[] {1}), 1, "TEST 6");
        }
    }
}
