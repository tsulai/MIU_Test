using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUExam
{
    [TestClass]
    public class closestFibonacci
    {
        [TestMethod]
        public void closestFibonacci1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.closestFibonacci(12), 8, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.closestFibonacci(33), 21, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.closestFibonacci(34), 34, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.closestFibonacci(0), 0, "TEST 4");
        }
    }
}
