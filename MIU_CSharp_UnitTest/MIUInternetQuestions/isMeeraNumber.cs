using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isMeeraNumber
    {
        [TestMethod]
        public void isMeeraNumber1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeeraNumber(6), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeeraNumber(30), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeeraNumber(21), 0, "TEST 3");
        }
    }
}
