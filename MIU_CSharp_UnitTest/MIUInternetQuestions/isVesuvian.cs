using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isVesuvian
    {
        [TestMethod]
        public void isVesuvian1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isVesuvian(50);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isVesuvian2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isVesuvian(65);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isVesuvian3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isVesuvian(85);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isVesuvian4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isVesuvian(1000);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isVesuvian5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isVesuvian(123);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
