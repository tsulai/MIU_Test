using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isSquare
    {
        [TestMethod]
        public void isSquare1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSquare(4);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isSquare2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSquare(25);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isSquare3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSquare(-4);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSquare4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSquare(8);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSquare5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSquare(0);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
