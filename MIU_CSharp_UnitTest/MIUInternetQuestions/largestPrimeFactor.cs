using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class largestPrimeFactor
    {
        [TestMethod]
        public void largestPrimeFactor1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.largestPrimeFactor(10);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 5);
        }
        [TestMethod]
        public void largestPrimeFactor2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.largestPrimeFactor(6936);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 17);
        }
        [TestMethod]
        public void largestPrimeFactor3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.largestPrimeFactor(1);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
