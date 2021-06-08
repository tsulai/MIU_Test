using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isVanilla
    {
        [TestMethod]
        public void isVanilla1()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isVanilla(new int[] { 1, 1, 11, 1111, 1111111 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isVanilla2()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isVanilla(new int[] { 11, 101, 1111, 11111 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isVanilla3()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isVanilla(new int[] { 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isVanilla4()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isVanilla(new int[] { 11, 22, 13, 34, 125 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isVanilla5()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isVanilla(new int[] {  9, 999, 99999, -9999 } );
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isVanilla6()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isVanilla(new int[] {  });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
