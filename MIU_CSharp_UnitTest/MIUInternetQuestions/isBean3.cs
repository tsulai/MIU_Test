using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isBean3
    {
        [TestMethod]
        public void isBean3_1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBean3(new int[] {4,9,8 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBean3(new int[] { 2, 2, 5,11,23 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBean3(new int[] { 7,7,3,6 }), 1, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBean3(new int[] { 0 }), 1, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBean3(new int[] { 3, 8,4 }), 0, "TEST 5");
        }
    }
}
