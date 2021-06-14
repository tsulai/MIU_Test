using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class pairwiseSum
    {
        [TestMethod]
        public void pairwiseSum1()
        {
            int?[] ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.pairwiseSum(new int[] { 2, 1, 18, -5 } );            
            CollectionAssert.AreEqual(ans, new int[] { 3,13 });
        }
        [TestMethod]
        public void pairwiseSum2()
        {
            int?[] ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.pairwiseSum(new int[] { 2, 1, 18, -5, -5, -15, 0, 0, 1, -1 });
            CollectionAssert.AreEqual(ans, new int[] { 3, 13, -20, 0, 0 });
        }
        [TestMethod]
        public void pairwiseSum3()
        {
            int?[] ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.pairwiseSum(new int[] { 2, 1, 18 });
            CollectionAssert.AreEqual(ans, null);
        }
        [TestMethod]
        public void pairwiseSum4()
        {
            int?[] ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.pairwiseSum(new int[] {});
            CollectionAssert.AreEqual(ans, null);
        }
    }
}
