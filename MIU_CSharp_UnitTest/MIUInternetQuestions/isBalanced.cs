using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isBalanced
    {
        [TestMethod]
        public void isBalanced1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBalanced(new int[] {-2,3, 2, -3}), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBalanced(new int[] { -2, 2, 2, 2 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBalanced(new int[] { -5,2,-2 }), 0, "TEST 3");
        }
    }
}
