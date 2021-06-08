using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class largestAdjacentSum
    {
        [TestMethod]
        public void largestAdjacentSum1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.largestAdjacentSum(new int[] { 1,2,3,4 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 7);
        }
        [TestMethod]
        public void largestAdjacentSum2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.largestAdjacentSum(new int[] { 18, -12, 9, -10 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 6);
        }
        [TestMethod]
        public void largestAdjacentSum3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.largestAdjacentSum(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 2);
        }
        [TestMethod]
        public void largestAdjacentSum4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.largestAdjacentSum(new int[] { 1, 1, 1, 1, 1, 2, 1, 1, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 3);
        }
    }
}
