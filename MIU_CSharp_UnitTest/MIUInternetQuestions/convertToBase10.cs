using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class convertToBase10
    {
        [TestMethod]
        public void convertToBase10_1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.convertToBase10(new int[] { 1,0,1,1 }, 2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 11);
        }
        [TestMethod]
        public void convertToBase10_2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.convertToBase10(new int[] { 1, 1, 2 }, 3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 14);
        }
        [TestMethod]
        public void convertToBase10_3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.convertToBase10(new int[] { 3,2,5 }, 8);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 213);
        }
        [TestMethod]
        public void convertToBase10_4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.convertToBase10(new int[] { 3, 7, 1 }, 6);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
