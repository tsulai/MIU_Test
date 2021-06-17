using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isDaphne2
    {
        [TestMethod]
        public void isDaphne2_1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDaphne2(new int[] { 4, 8, 6, 3, 2, 9, 8, 11, 8, 13, 12, 12, 6 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDaphne2(new int[] { 2, 4, 6, 8, 6 }), 0, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isDaphne2(new int[]{2, 8, 7, 10, 4, 6}), 0, "TEST 3");

        }
    }
}
