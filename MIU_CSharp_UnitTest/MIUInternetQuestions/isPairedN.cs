using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isPairedN
    {
        [TestMethod]
        public void isPairedN1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPairedN(new int[] { 1, 4, 1, 4, 5, 6 }, 5);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isPairedN2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPairedN(new int[] { 1, 4, 1, 4, 5, 6 }, 6);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isPairedN3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPairedN(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 6);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isPairedN4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPairedN(new int[] { 1, 4, 1 }, 5);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isPairedN5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPairedN(new int[] { 8, 8, 8, 8, 7, 7, 7 }, 15);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isPairedN6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPairedN(new int[] { 8, -8, 8, 8, 7, 7, -7 },-15);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isPairedN7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPairedN(new int[] { 3 }, 3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isPairedN8()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPairedN(new int[] { }, 0);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
