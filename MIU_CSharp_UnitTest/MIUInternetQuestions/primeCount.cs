using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class primeCount
    {
        [TestMethod]
        public void PrimeCount1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.primeCount(10, 30);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 6);
        }
        [TestMethod]
        public void PrimeCount2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.primeCount(11, 29);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 6);
        }
        [TestMethod]
        public void PrimeCount3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.primeCount(20, 22);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void PrimeCount4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.primeCount(1, 1);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void PrimeCount5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.primeCount(5, 5);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void PrimeCount6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.primeCount(6, 2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void PrimeCount7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.primeCount(-10, 6);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 3);
        }
    }
}
