using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isFibonacci
    {
        [TestMethod]
        public void isFibonacci1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isFibonacci(13);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isFibonacci2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isFibonacci(27);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
