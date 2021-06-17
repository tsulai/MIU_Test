using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isMeera3
    {
        [TestMethod]
        public void isMeera3_1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera3(new int[] { 7, 6, 0, 10, 1 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera3(new int[] {6,10,1}), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera3(new int[] { 7,6,10}), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera3(new int[] { 6, 10, 0 }), 0, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera3(new int[] { 3, 7, 0, 8, 0, 5 }), 1, "TEST 5");

        }
    }
}
