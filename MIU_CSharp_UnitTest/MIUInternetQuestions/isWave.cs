using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isWave
    {
        [TestMethod]
        public void isWave1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isWave(new int[] { 7, 2, 9, 10, 5 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isWave(new int[] { 4, 11, 12, 1, 6 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isWave(new int[] { 1,0,5 }), 1, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isWave(new int[] { 2 }), 1, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isWave(new int[] { 2,6,3,4 }), 0, "TEST 5");
        }
    }
}
