using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isMagicArray
    {
        [TestMethod]
        public void isMagicArray1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMagicArray(new int[] {21, 3, 7, 9, 11, 4, 6}), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMagicArray(new int[] { 13, 4, 4, 4, 4 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMagicArray(new int[] { 10, 5, 5 }), 1, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMagicArray(new int[] { 0, 6, 8, 20 }), 1, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMagicArray(new int[] { 3 }), 1, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMagicArray(new int[] {8, 5, -5,
5, 3}), 0, "TEST 6");
        }
    }
}
