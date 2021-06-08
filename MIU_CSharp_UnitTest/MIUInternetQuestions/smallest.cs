using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class smallest
    {
        [TestMethod]
        public void smallest1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.smallest(4);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 624);
        }
        [TestMethod]
        public void smallest2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.smallest(5);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 624);
        }
        [TestMethod]
        public void smallest3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.smallest(6);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 642);
        }
        [TestMethod]
        public void smallest4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.smallest(7);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 4062);
        }
    }
}
