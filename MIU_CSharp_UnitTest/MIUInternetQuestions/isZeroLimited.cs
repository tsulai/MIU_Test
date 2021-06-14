using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isZeroLimited
    {
        [TestMethod]
        public void isZeroLimited1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isZeroLimited(new int[] { 0, 0, 0, 0, 0 }), 0, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isZeroLimited(new int[] { 1,0 }),1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isZeroLimited(new int[] { 0,1 }), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isZeroLimited(new int[] { 5 }), 1, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isZeroLimited(new int[] { 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 0 }), 1, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isZeroLimited(new int[] {}), 1, "TEST 6");
        }
    }
}
