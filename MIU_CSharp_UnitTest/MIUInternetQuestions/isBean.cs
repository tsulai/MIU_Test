using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isBean
    {
        [TestMethod]
        public void isBean1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBean(new int[] { 1, 2, 3, 9, 6, 13 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBean(new int[] { 3, 4, 6, 7, 13, 15 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBean(new int[] { 1, 2, 3, 4, 10, 11, 12 }), 1, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBean(new int[] { 3, 6, 9, 5, 7, 13, 6, 17 }), 1, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBean(new int[] { 9, 6, 18 }), 0, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBean(new int[] { 4, 7, 16 }), 0, "TEST 6");
        }
    }
}
