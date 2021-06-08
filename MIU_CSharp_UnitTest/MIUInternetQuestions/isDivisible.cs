using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isDivisible
    {
        [TestMethod]
        public void isDivisible1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isDivisible(new int[] { 3,3,6,36 }, 3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isDivisible2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isDivisible(new int[] { 4 }, 2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isDivisible3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isDivisible(new int[] { 3, 4, 3,6,36}, 3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isDivisible4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isDivisible(new int[] { 6,12,24,36 }, 12);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isDivisible5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isDivisible(new int[] {}, 3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
