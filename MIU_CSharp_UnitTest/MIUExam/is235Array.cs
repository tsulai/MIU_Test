using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUExam
{
    [TestClass]
    public class is235Array
    {
        [TestMethod]
        public void is235Array1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUExam.is235Array(new int[] { 2, 3, 5, 7, 11 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void is235Array2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUExam.is235Array(new int[] { 2, 3, 6, 7, 11 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void is235Array3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUExam.is235Array(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void is235Array4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUExam.is235Array(new int[] { 2, 4, 8, 16, 32 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void is235Array5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUExam.is235Array(new int[] { 3, 9, 27, 7, 1, 1, 1, 1, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void is235Array6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUExam.is235Array(new int[] { 7, 11, 77, 49 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void is235Array7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUExam.is235Array(new int[] { 2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void is235Array8()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUExam.is235Array(new int[] { });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void is235Array9()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUExam.is235Array(new int[] { 7, 2, 7, 2, 7, 2, 7, 2, 3, 7, 7 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
