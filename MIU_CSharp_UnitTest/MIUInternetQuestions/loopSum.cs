using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class loopSum
    {
        [TestMethod]
        public void loopSum1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.loopSum(new int[] { 1, 2, 3 }, 2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 3);
        }
        [TestMethod]
        public void loopSum2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.loopSum(new int[] { -1, 2, -1 }, 7);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void loopSum3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.loopSum(new int[] { 1,4,5,6 }, 4);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 16);
        }
        [TestMethod]
        public void loopSum4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.loopSum(new int[] { 3}, 10);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 30);
        }
    }
}
