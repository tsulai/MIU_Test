using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isStacked
    {
        [TestMethod]
        public void isStacked1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isStacked(10);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isStacked2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isStacked(7);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isStacked3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isStacked(15);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
