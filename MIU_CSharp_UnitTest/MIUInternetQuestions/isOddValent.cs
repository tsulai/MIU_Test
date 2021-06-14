using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isOddValent
    {
        [TestMethod]
        public void isOddValent1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isOddValent(new int[] { 9, 3, 4, 9, 1 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isOddValent(new int[] { 3, 3, 3, 3 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isOddValent(new int[] { 8, 8, 8, 4, 4, 7, 2 }), 1, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isOddValent(new int[] { 1, 2, 3, 4, 5 }), 0, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isOddValent(new int[] { 2, 2, 2, 4, 4 }), 0, "TEST 5");
        }
    }
}
