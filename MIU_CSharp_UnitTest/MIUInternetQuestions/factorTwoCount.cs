using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class factorTwoCount
    {
        [TestMethod]
        public void factorTwoCount1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.factorTwoCount(48), 4, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.factorTwoCount(27), 0, "TEST 2");
        }
    }
}
