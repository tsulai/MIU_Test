using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isFineArray
    {
        [TestMethod]
        public void isFineArray1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isFineArray(new int[] { 4, 7, 9, 6, 5 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isFineArray(new int[] { 4, 9, 6, 33 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isFineArray(new int[] { 3, 8, 15 }), 0, "TEST 3");
        }
    }
}
