using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isPrimeHappy
    {
        [TestMethod]
        public void isPrimeHappy1()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPrimeHappy(5);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isPrimeHappy2()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPrimeHappy(25);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isPrimeHappy3()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPrimeHappy(32);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isPrimeHappy4()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPrimeHappy(8);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isPrimeHappy5()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPrimeHappy(2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
