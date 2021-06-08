using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class getExponent
    {
        [TestMethod]
        public void getExponent1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.getExponent(162, 3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 4);
        }
        [TestMethod]
        public void getExponent2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.getExponent(27, 3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 3);
        }
        [TestMethod]
        public void getExponent3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.getExponent(28, 3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void getExponent4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.getExponent(280, 7);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void getExponent5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.getExponent(-250, 5);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 3);
        }
        [TestMethod]
        public void getExponent6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.getExponent(18, 1);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void getExponent7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.getExponent(128, 4);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 3);
        }
    }
}
