using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUExam
{
    [TestClass]
    public class isSelfReferential
    {
        [TestMethod]
        public void isSelfReferential1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.isSelfReferential(new int[] { 1, 2, 1, 0 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.isSelfReferential(new int[] { 2,0,0 }), 0, "TEST 2");
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.isSelfReferential(new int[] { 0 }), 0, "TEST 3");
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.isSelfReferential(new int[] { 1 }), 0, "TEST 4");

            Assert.AreEqual(MIU_CSharp_Class.MIUExam.isSelfReferential(new int[] { 2,0,2,0}), 1, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.isSelfReferential(new int[] { 2, 0, 2, 0 }), 1, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.isSelfReferential(new int[] { 2, 1, 2, 0, 0 }), 1, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.isSelfReferential(new int[] { 3, 2, 1, 1, 0, 0, 0 }), 1, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.isSelfReferential(new int[] { 4, 2, 1, 0, 1, 0, 0, 0 }), 1, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.isSelfReferential(new int[] { 5, 2, 1, 0, 0, 1, 0, 0, 0 }), 1, "TEST 5");
            Assert.AreEqual(MIU_CSharp_Class.MIUExam.isSelfReferential(new int[] { 6, 2, 1, 0, 0, 0, 1, 0, 0, 0 }), 1, "TEST 5");
        }
    }
}
