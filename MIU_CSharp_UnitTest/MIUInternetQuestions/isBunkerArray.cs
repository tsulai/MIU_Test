using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isBunkerArray
    {
        [TestMethod]
        public void isBunkerArray1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBunkerArray(new int[] {4,9,6,7,3 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isBunkerArray(new int[] { 4, 9, 6, 15, 21 }), 0, "TEST 2");
        }
    }
}
