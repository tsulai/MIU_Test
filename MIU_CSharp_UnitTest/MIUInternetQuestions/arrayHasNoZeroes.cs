using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class arrayHasNoZeroes
    {
        [TestMethod]
        public void arrayHasNoZeroes1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.arrayHasNoZeroes(new int[] { 1,2,3 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void arrayHasNoZeroes2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.arrayHasNoZeroes(new int[] { 1, 0,4,0 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void arrayHasNoZeroes3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.arrayHasNoZeroes(new int[] { 1, 2,3,0});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void arrayHasNoZeroes4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.arrayHasNoZeroes(new int[] { 0,0,0,0 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void arrayHasNoZeroes5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.arrayHasNoZeroes(new int[] { });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
