using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class guthrieIndex
    {
        [TestMethod]
        public void guthrieIndex1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.guthrieIndex(1);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void guthrieIndex2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.guthrieIndex(7);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 16);
        }
        [TestMethod]
        public void guthrieIndex3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.guthrieIndex(3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 7);
        }
        [TestMethod]
        public void guthrieIndex4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.guthrieIndex(4);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 2);
        }
        [TestMethod]
        public void guthrieIndex5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.guthrieIndex(42);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 8);
        }        
    }
}
