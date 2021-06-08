using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isNUnique
    {
        [TestMethod]
        public void isNUnique1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isNUnique(new int[] { 7,3,3,2,4 }, 6);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isNUnique2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isNUnique(new int[] { 7, 3, 3, 2, 4 }, 10);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isNUnique3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isNUnique(new int[] { 7, 3, 3, 2, 4 }, 11);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isNUnique4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isNUnique(new int[] { 7, 3, 3, 2, 4 }, 8);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isNUnique5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isNUnique(new int[] { 7, 3, 3, 2, 4 }, 4);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isNUnique6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isNUnique(new int[] {  }, 7);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isNUnique7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isNUnique(new int[] {2,5 }, 7);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
