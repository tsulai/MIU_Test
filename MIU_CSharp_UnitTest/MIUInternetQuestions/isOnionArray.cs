using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isOnionArray
    {
        [TestMethod]
        public void isOnionArray1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOnionArray(new int[] { 1, 2, 19, 4, 5 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isOnionArray2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOnionArray(new int[] { 1, 2, 3, 4, 15 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isOnionArray3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOnionArray(new int[] { 1, 3,9,8 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isOnionArray4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOnionArray(new int[] {2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isOnionArray5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOnionArray(new int[] { });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isOnionArray6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOnionArray(new int[] { -2, 5, 0, 5, 12 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
