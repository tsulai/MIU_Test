using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class hasNValues
    {
        [TestMethod]
        public void hasNValues1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.hasNValues(new int[] { 1, 2, 2, 1 }, 2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void hasNValues2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.hasNValues(new int[] { 1, 1, 1, 8, 1, 1, 1, 3, 3 }, 3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void hasNValues3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.hasNValues(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void hasNValues4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.hasNValues(new int[] { 1, 2, 2, 1 }, 3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void hasNValues5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.hasNValues(new int[] { 1, 1, 1, 8, 1, 1, 1, 3, 3 }, 2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void hasNValues6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.hasNValues(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 20);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
