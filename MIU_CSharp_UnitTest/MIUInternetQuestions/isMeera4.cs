using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isMeera4
    {
        [TestMethod]
        public void isMeera4_1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera4(new int[] { 7, 9, 0, 10, 1 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera4(new int[] { 6, 10, 8 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera4(new int[] { 7, 6, 1 }), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera4(new int[] { 9, 10, 0 }), 0, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera4(new int[] { 1, 1, 0, 8, 0, 9, 9, 1 }), 1, "TEST 5");
        }
    }
}
