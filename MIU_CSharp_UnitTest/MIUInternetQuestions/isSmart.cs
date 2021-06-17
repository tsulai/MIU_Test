using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isSmart
    {
        [TestMethod]
        public void isSmart1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isSmart(11), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isSmart(22), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isSmart(8), 0, "TEST 3");
        }
    }
}
