using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isSumSafe
    {
        [TestMethod]
        public void isSumSafe1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSumSafe(new int[] { 5,-5,0 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSumSafe2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSumSafe(new int[] { 5, -2, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isSumSafe3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSumSafe(new int[] { 5, 6, -2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
