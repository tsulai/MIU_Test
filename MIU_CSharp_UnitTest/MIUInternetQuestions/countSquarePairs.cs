using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class countSquarePairs
    {
        [TestMethod]
        public void countSquarePairs1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.countSquarePairs(new int[] { 11,5,4,20 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 3);
        }
        [TestMethod]
        public void countSquarePairs2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.countSquarePairs(new int[] { 9,0,2,-5,7 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 2);
        }
        [TestMethod]
        public void countSquarePairs3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.countSquarePairs(new int[] { 9});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
