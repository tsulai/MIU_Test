using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isTriple
    {
        [TestMethod]
        public void isTriple1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isTriple(new int[] { 3, 1, 2, 1, 3, 1, 3, 2, 2 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isTriple(new int[] { 2, 5, 2, 5, 5, 2, 5 }), 0, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isTriple(new int[] { 3,1,1,1 }), 0, "TEST 3");
        }
    }
}
