using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class factorEqual
    {
        [TestMethod]
        public void factorEqual1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.factorEqual(10,33), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.factorEqual(9, 10), 0, "TEST 2");
        }
    }
}
