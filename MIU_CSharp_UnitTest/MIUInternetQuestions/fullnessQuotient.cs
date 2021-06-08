using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class fullnessQuotient
    {
        [TestMethod]
        public void fullnessQuotient1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.fullnessQuotient(94);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 6);
        }
        [TestMethod]
        public void fullnessQuotient2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.fullnessQuotient(1);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 8);
        }
        [TestMethod]
        public void fullnessQuotient3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.fullnessQuotient(9);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 5);
        }
        [TestMethod]
        public void fullnessQuotient4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.fullnessQuotient(360);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void fullnessQuotient5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.fullnessQuotient(-4);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, -1);
        }       
    }
}
