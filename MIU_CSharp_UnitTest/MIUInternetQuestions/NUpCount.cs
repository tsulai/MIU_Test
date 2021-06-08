using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class NUpCount
    {
        [TestMethod]
        public void NUpCount1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.NUpCount_Smart(new int [] { 2, 3, 1, -6, 8, -3, -1, 2 }, 5);
            Console.WriteLine(ans);
           Assert.AreEqual(ans, 3);
        }
        [TestMethod]
        public void NUpCount_Smart()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.NUpCount_Smart(new int[] { 6,3,1 }, 6);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void NUpCount3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.NUpCount_Smart(new int[] { 1, 2, -1, 5, 3, 2, -3 }, 20);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
