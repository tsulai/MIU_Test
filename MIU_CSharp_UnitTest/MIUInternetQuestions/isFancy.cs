using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isFancy
    {
        [TestMethod]
        public void isFancy1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isFancy(17), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isFancy(22), 0, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isFancy(61), 1, "TEST 3");
        }
    }
}
