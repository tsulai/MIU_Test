using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isNPrimeable
    {
        [TestMethod]
        public void isNPrimeable1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isNPrimeable(new int[] { 5,15,27 }, 2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans,1);
        }
        [TestMethod]
        public void isNPrimeable2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isNPrimeable(new int[] { 5, 15, 27 }, 3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isNPrimeable3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isNPrimeable(new int[] { 5, 15, 26 }, 2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isNPrimeable4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isNPrimeable(new int[] {1,1,1,1,1,1,1 }, 4);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isNPrimeable5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isNPrimeable(new int[] { }, 2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
