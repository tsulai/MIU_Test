using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class countOnes
    {
        [TestMethod]
        public void countOnes1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.countOnes(9), 2, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.countOnes(5), 2, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.countOnes(15), 4, "TEST 3");
        }
    }
}
