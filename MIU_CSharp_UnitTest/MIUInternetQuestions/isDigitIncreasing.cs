using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isDigitIncreasing
    {
        [TestMethod]
        public void isDigitIncreasing1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isDigitIncreasing(24);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isDigitIncreasing2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isDigitIncreasing(7);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isDigitIncreasing3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isDigitIncreasing(36);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isDigitIncreasing4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isDigitIncreasing(984);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isDigitIncreasing5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isDigitIncreasing(7404);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
