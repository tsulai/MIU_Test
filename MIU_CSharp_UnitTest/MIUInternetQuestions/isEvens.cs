using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isEvens
    {
        [TestMethod]
        public void isEvens1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isEvens(2426), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isEvens(3224), 0, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isEvens(3064), 0, "TEST 3");
        }
    }
}
