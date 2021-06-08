using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class repsEqual
    {
        [TestMethod]
        public void repsEqual1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.repsEqual(new int[] { 3,2,0,5,3}, 32053);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void repsEqual2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.repsEqual(new int[] { 3, 2, 0, 5 }, 32053);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void repsEqual3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.repsEqual(new int[] { 3, 2, 0, 5, 3,4}, 32053);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void repsEqual4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.repsEqual(new int[] { 2,3,0,5,3 }, 32053);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void repsEqual5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.repsEqual(new int[] { 9,3,1,1,2 }, 32053);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void repsEqual6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.repsEqual(new int[] { 0,3,2,0,5,3 }, 32053);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void repsEqual_MyTest()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.repsEqual(new int[] { 0,0,0, 3, 2, 0, 5, 3,0 }, 32053);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
