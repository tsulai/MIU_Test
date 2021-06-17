using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isContinuousFactored
    {
        [TestMethod]
        public void isContinuousFactored1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isContinuousFactored(6), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isContinuousFactored(60), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isContinuousFactored(120), 1, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isContinuousFactored(90), 1, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isContinuousFactored(99), 0, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isContinuousFactored(121), 0, "TEST 6");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isContinuousFactored(2), 0, "TEST 7");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isContinuousFactored(13), 0, "TEST 8");
        }
    }
}
