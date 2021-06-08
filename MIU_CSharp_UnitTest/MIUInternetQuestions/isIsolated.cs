using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isIsolated
    {
        [TestMethod]
        public void isIsolated1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isIsolated(2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isIsolated2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isIsolated(162);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isIsolated3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isIsolated(2097152);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void isIsolated4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isIsolated(63);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
