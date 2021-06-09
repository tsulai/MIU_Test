using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isHodder
    {
        [TestMethod]
        public void isHodder1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isHodder(31);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isHodder2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isHodder(3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isHodder3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isHodder(7);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isHodder4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isHodder(127);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isHodder5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isHodder(33);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
