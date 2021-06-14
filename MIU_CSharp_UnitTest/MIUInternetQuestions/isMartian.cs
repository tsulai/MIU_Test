using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isMartian
    {
        [TestMethod]
        public void isMartian1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMartian(new int[] { 1, 3 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isMartian2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMartian(new int[] {1, 2, 1, 2, 1, 2, 1, 2, 1});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }

        [TestMethod]
        public void isMartian3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMartian(new int[] { 1, 3, 2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isMartian4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMartian(new int[] { 1, 3, 2, 2, 1, 5, 1, 5 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isMartian5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMartian(new int[] { 1, 2, -18, -18, 1, 2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isMartian6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMartian(new int[] { });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isMartian7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMartian(new int[] { 1});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isMartian8()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMartian(new int[] {2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
