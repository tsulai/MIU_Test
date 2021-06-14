using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isLayered
    {
        [TestMethod]
        public void isLayered1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isLayered(new int[] { 1, 1, 2, 2, 2, 3, 3 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isLayered(new int[] { 3,3,3,3,3 ,3, 3 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isLayered(new int[] { 1, 2, 2, 2, 3, 3 }), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isLayered(new int[] { 2, 2, 2, 3, 3, 1, 1 }), 0, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isLayered(new int[] { 2}), 0, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isLayered(new int[] { }), 0, "TEST 6");
        }
    }
}
