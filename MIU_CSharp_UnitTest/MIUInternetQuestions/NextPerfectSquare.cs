using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MIU_CSharp_Class;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class NextPerfectSquare
    {
       [TestMethod]
        public void IsPerfectSquare1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.NextPerfectSquare(0);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void IsPerfectSquare2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.NextPerfectSquare(-5);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }

    }
}
