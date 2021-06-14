using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class sameNumberOfFactors
    {
        [TestMethod]
        public void sameNumberOfFactors1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.sameNumberOfFactors(-6, 21);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void sameNumberOfFactors2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.sameNumberOfFactors(6, 21);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void sameNumberOfFactors3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.sameNumberOfFactors(8, 12);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void sameNumberOfFactors4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.sameNumberOfFactors(23, 97);
            Console.WriteLine(ans);
            Assert.AreEqual(ans,1);
        }
        [TestMethod]
        public void sameNumberOfFactors5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.sameNumberOfFactors(0, 1);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void sameNumberOfFactors6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.sameNumberOfFactors(0, 0);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
