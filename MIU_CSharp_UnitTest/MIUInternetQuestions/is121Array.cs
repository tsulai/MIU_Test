using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class is121Array
    {
        [TestMethod]
        public void is121Array1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.is121Array(new int[] { 1,2,1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void is121Array2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.is121Array(new int[] { 1, 1, 2, 2, 2, 1, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void is121Array3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.is121Array(new int[] { 1, 1, 2, 2, 2, 1, 1, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void is121Array4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.is121Array(new int[] { 1, 1, 2, 1, 2, 1, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans,0);
        }
        [TestMethod]
        public void is121Array5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.is121Array(new int[] { 1, 1, 1, 2, 2, 2, 1, 1, 1, 3 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void is121Array6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.is121Array(new int[] { 1, 1, 1, 1, 1, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void is121Array7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.is121Array(new int[] { 2, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void is121Array8()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.is121Array(new int[] { 1, 1, 1, 2, 2, 2, 1, 1, 2, 2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void is121Array9()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.is121Array(new int[] { 2, 2, 2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
