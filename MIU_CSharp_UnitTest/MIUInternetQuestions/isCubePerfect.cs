using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isCubePerfect
    {
        [TestMethod]
        public void isCubePerfect1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isCubePerfect(new int[] { 1,1,1,1 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isCubePerfect(new int[] { 64 }), 1, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isCubePerfect(new int[] { 63 }), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isCubePerfect(new int[] { -1,0,1 }), 1, "TEST 4");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isCubePerfect(new int[] { }), 1, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isCubePerfect(new int[] {3,7,21,36 }), 0, "TEST 6");
        }
    }
}
