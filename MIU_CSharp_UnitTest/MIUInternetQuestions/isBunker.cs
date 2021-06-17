using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isBunker
    {
        [TestMethod]
        public void isBunker1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBunker(new int[] { 7, 6, 10, 1 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBunker(new int[] { 7, 6, 10 }), 0, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBunker(new int[] { 6,10,1 }), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBunker(new int[]{ 3,7, 1, 8, 1}), 1, "TEST 4");
        }
    }
}
