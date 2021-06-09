using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class checkConcatenatedSum
    {
        [TestMethod]
        public void checkConcatenatedSum1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.checkConcatenatedSum(198, 2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void checkConcatenatedSum2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.checkConcatenatedSum(198, 3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void checkConcatenatedSum3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.checkConcatenatedSum(2997, 3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void checkConcatenatedSum4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.checkConcatenatedSum(2997, 2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void checkConcatenatedSum5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.checkConcatenatedSum(13332, 4);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void checkConcatenatedSum6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.checkConcatenatedSum(9, 1);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
