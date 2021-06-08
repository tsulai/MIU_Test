using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class matches
    {
        [TestMethod]
        public void matches1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.matches(new int[] { 1,2,3,-5,-5,2,3,18 }, new int[] {3, -2,3 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void matches2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.matches(new int[] { 1, 2, 3, -5, -5, 2, 3, 18 }, new int[] { 2, 1, -1, -1, 2, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void matches3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.matches(new int[] { 1, 2, 3, -5, -5, 2, 3, 18 }, new int[] { 1, 2, -1, -1, 1, 2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void matches4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.matches(new int[] { 1, 2, 3, -5, -5, 2, 3, 18 }, new int[] { 2, 1, -2, 3 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void matches5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.matches(new int[] { 1, 2, 3, -5, -5, 2, 3, 18 }, new int[] { 1, 1, 1, -1, -1, 1, 1, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void matches6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.matches(new int[] { 1, 2, 3, -5, -5, 2, 3, 18 }, new int[] { 4,-1,3 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void matches7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.matches(new int[] { 1, 2, 3, -5, -5, 2, 3, 18 }, new int[] { 2, -3, 3 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void matches8()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.matches(new int[] { 1, 2, 3, -5, -5, 2, 3, 18 }, new int[] { 8 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
