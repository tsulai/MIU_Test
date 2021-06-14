using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class minDistance
    {
        [TestMethod]
        public void minDistance1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.minDistance(13013), 2, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.minDistance(8), 1, "TEST 2");
        }
    }
}
