using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isZeroBalanced
    {
        [TestMethod]
        public void isZeroBalanced1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isZeroBalanced(new int[] { 1, 2, -2, -1 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isZeroBalanced(new int[] { -3, 1, 2, -2, -1, 3 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isZeroBalanced(new int[] { 3, 4, -2, -3, -2 }), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isZeroBalanced(new int[] { 0, 0, 0, 0, 0, 0 }), 1, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isZeroBalanced(new int[] { 3, -3, -3 }), 0, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isZeroBalanced(new int[] { 3 }),0, "TEST 6");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isZeroBalanced(new int[] { }), 0, "TEST 7");
        }
    }
}
