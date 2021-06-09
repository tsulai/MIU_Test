using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isFactorialPrime
    {
        [TestMethod]
        public void isFactorialPrime1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isFactorialPrime(2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isFactorialPrime2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isFactorialPrime(3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isFactorialPrime3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isFactorialPrime(7);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isFactorialPrime4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isFactorialPrime(8);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isFactorialPrime5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isFactorialPrime(11);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isFactorialPrime6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isFactorialPrime(721);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
