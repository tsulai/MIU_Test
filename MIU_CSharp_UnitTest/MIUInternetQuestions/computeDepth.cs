using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class computeDepth
    {
        [TestMethod]
        public void computeDepth1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.computeDepth(42);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 9);
        }
        [TestMethod]
        public void computeDepth2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.computeDepth(7);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 10);
        }
        [TestMethod]
        public void computeDepth3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.computeDepth(13);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 8);
        }
        [TestMethod]
        public void computeDepth4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.computeDepth(25);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 36);
        }
    }
}
