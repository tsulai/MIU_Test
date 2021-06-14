using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isOneBalanced
    {
        [TestMethod]
        public void isOneBalanced1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOneBalanced(new int[] { 1, 1, 1, 2, 3, -18, 45, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isOneBalanced2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOneBalanced(new int[] { 1, 1, 1, 2, 3, -18, 45, 1, 0 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isOneBalanced3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOneBalanced(new int[] { 1, 1, 2, 3, 1, -18, 26, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isOneBalanced4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOneBalanced(new int[] {  });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);       
        }
        [TestMethod]
        public void isOneBalanced6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOneBalanced(new int[] { 3, 4, 1, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isOneBalanced7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOneBalanced(new int[] { 1, 1, 3, 4 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isOneBalanced8()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOneBalanced(new int[] { 3, 3, 3, 3, 3, 3 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isOneBalanced9()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOneBalanced(new int[] { 1, 1, 1, 1, 1, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
