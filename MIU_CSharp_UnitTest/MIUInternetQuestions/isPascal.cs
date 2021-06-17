using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isPascal
    {
        [TestMethod]
        public void isPascal1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isPascal(6), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isPascal(15), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isPascal(7), 0, "TEST 3");
        }
    }
}
