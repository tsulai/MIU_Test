using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isTriangular
    {
        [TestMethod]
        public void isTriangular1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isTriangular(1);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isTriangular2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isTriangular(3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isTriangular3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isTriangular(6);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isTriangular4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isTriangular(10);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isTriangular5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isTriangular(55);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
