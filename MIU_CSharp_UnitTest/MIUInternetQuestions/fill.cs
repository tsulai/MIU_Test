using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class fill
    {
        [TestMethod]
        public void fill1()
        {
            CollectionAssert.AreEquivalent(MIU_CSharp_Class.MIUInternetQuestions.fill(new int[] { 1,2,3,5, 9, 12,2,1}, 3, 10), new int?[] { 1,2,3,1,2,3,1,2,3,1}, "TEST 1");
            CollectionAssert.AreEquivalent(MIU_CSharp_Class.MIUInternetQuestions.fill(new int[] { 4,2,-3,12 }, 1, 5), new int?[] { 4,4,4,4,4 }, "TEST 2");
            CollectionAssert.AreEquivalent(MIU_CSharp_Class.MIUInternetQuestions.fill(new int[] { 2,6,9,0,-3 }, 0, 4), null, "TEST 3");
        }
    }
}
