using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class sumDigits
    {
        [TestMethod]
        public void sumDigits1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.sumDigits(3114), 9, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.sumDigits(-6543), 18, "TEST 2");
        }
    }
}
