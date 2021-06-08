using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isIntertial
    {
        [TestMethod]
        public void isIntertial1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isIntertial(new int[] { 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isIntertial2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isIntertial(new int[] { 2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isIntertial3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isIntertial(new int[] { 1,2,3,4 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isIntertial4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isIntertial(new int[] { 1,1,1,1,1,1,2});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isIntertial5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isIntertial(new int[] { 2,12,4,6,8,11 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isIntertial6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isIntertial(new int[] { 2,12,12,4,6,8,11 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isIntertial7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isIntertial(new int[] { -2, -4,-6, -8, -11 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isIntertial8()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isIntertial(new int[] { 2,3,5,7 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isIntertial9()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isIntertial(new int[] { 2, 4,6,8,10});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
