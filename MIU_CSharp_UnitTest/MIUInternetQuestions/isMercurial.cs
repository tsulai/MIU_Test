using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isMercurial
    {
        [TestMethod]
        public void isMercurial1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMercurial(new int[] { 1, 2, 10, 3, 15, 1, 2, 2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isMercurial2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMercurial(new int[] { 5, 2, 10, 3, 15, 1, 2, 2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isMercurial3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMercurial(new int[] { 1, 2, 10, 3, 15, 16, 2, 2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isMercurial4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMercurial(new int[] { 3, 2, 18, 1, 0, 3, -11, 1, 3 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isMercurial5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMercurial(new int[] { 2, 3, 1, 1, 18 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isMercurial6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMercurial(new int[] { 8, 2, 1, 1, 18, 3, 5 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isMercurial7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMercurial(new int[] { 3, 3, 3, 3, 3, 3 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isMercurial8()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMercurial(new int[] { 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isMercurial9()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMercurial(new int[] { });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
