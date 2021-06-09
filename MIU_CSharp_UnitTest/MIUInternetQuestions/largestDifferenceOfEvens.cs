using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class largestDifferenceOfEvens
    {
        [TestMethod]
        public void largestDifferenceOfEvens1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.largestDifferenceOfEvens(new int[] { -2,3,4,9 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 6);
        }
        [TestMethod]
        public void largestDifferenceOfEvens2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.largestDifferenceOfEvens(new int[] { 1, 3, 5, 9 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void largestDifferenceOfEvens3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.largestDifferenceOfEvens(new int[] { 1, 18, 5, 7, 33 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void largestDifferenceOfEvens4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.largestDifferenceOfEvens(new int[] { 2,2,2,2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void largestDifferenceOfEvens5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.largestDifferenceOfEvens(new int[] { 1, 2, 1, 2, 1, 4, 1, 6, 4 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 4);
        }

    }
}
