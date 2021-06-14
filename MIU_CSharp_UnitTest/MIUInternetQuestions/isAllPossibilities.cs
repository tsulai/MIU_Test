using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isAllPossibilities
    {
        [TestMethod]
        public void isAllPossibilities1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isAllPossibilities(new int[] { 1,2,0,3 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isAllPossibilities(new int[] { 3, 2, 1, 0 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isAllPossibilities(new int[] { 1, 2, 4, 3 }), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isAllPossibilities(new int[] { 0,2,3 }), 0, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isAllPossibilities(new int[] { 0}), 1, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isAllPossibilities(new int[] { }), 0, "TEST 6");


        }
    }
}
