using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class closestFibonacci
    {
        [TestMethod]
        public void closestFibonacci1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.closestFibonacci(13);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 13);
        }
        [TestMethod]
        public void closestFibonacci2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.closestFibonacci(33);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 21);
        }
        [TestMethod]
        public void closestFibonacci3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.closestFibonacci(34);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 34);
        }
    }
}
