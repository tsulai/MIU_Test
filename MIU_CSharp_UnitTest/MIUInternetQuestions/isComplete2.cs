using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isComplete2
    {
        [TestMethod]
        public void isComplete2_1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isComplete2(new int[] {5, 6, 2, 3, 2, 4, 5, 11, 8, 7}), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isComplete2(new int[] { 5, 7, 9, 13 }), 0, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isComplete2(new int[] { 2,2 }), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isComplete2(new int[] { 2, 6, 3, 4 }), 0, "TEST 4");
        }
    }
}
