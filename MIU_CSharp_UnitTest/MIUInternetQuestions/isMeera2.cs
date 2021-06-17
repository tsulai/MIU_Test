using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isMeera2
    {
        [TestMethod]
        public void isMeera2_1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera2(new int[] {-4,0, 1, 0, 2, 1}), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera2(new int[] {-8, 0, 0, 8, 0}), 0, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera2(new int[] {-8,0, 0, 2, 0}), 0, "TEST 3");
        }
    }
}
