using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isConsectiveFactored
    {
        [TestMethod]
        public void isConsectiveFactored1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isConsectiveFactored(24), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isConsectiveFactored(105), 0, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isConsectiveFactored(90), 1, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isConsectiveFactored(23), 0, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isConsectiveFactored(15), 0, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isConsectiveFactored(2), 0, "TEST 6");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isConsectiveFactored(0), 0, "TEST 7");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isConsectiveFactored(-12), 0, "TEST 8");
        }
    }
}
