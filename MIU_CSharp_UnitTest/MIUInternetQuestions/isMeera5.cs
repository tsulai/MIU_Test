using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isMeera5
    {
        [TestMethod]
        public void isMeera5_1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera5(new int[] {-4, 0, 1, 0, 2}), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera5(new int[] {-1,0, 0, 8, 0}), 0, "TEST 2");
        }
    }
}
