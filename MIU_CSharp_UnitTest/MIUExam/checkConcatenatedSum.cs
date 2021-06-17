using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUExam
{
    [TestClass]
    public class checkConcatenatedSum
    {
        [TestMethod]
        public void checkConcatenatedSum1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.checkConcatenatedSum(198, 2), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.checkConcatenatedSum(198, 3), 0, "TEST 2");
        }
    }
}
