using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isBalanced2
    {
        [TestMethod]
        public void isBalanced21()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBalanced2(new int[] { 2, 3, 6, 7 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBalanced2(new int[] { 6, 7, 2, 3, 12 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBalanced2(new int[] { 7, 15, 2, 3 }), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBalanced2(new int[] { 16, 6, 2, 3 }), 0, "TEST 4");
        }
    }
}
