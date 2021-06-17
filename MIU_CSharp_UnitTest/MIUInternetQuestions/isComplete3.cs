using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isComplete3
    {
        [TestMethod]
        public void isComplete3_1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isComplete3(new int[] { 2, 3, 2, 4, 11, 6, 10, 9, 8 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isComplete3(new int[] { 2, 3, 3,6 }), 0, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isComplete3(new int[] { 2, -3, 4,3, 6 }), 0, "TEST 3");
        }
    }
}
