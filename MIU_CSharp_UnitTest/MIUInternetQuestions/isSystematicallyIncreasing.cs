using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isSystematicallyIncreasing
    {
        [TestMethod]
        public void isSystematicallyIncreasing1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSystematicallyIncreasing(new int[] { 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isSystematicallyIncreasing2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSystematicallyIncreasing(new int[] { 1,2,1,2,3 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSystematicallyIncreasing3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSystematicallyIncreasing(new int[] {1,1,3});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSystematicallyIncreasing4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSystematicallyIncreasing(new int[] { 1,2,1,2,1,2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSystematicallyIncreasing5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSystematicallyIncreasing(new int[] { 1,2, 3,1,2,1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSystematicallyIncreasing6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSystematicallyIncreasing(new int[] { 1, 1, 2,3 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
