using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isCentered15
    {
        [TestMethod]
        public void isCentered15_1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isCentered15(new int[] { 3,2,10,4,1,6,9 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isCentered15_2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isCentered15(new int[] { 2,10,4,1,6,9 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isCentered15_3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isCentered15(new int[] { 3,2,10,4,1,6 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isCentered15_4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isCentered15(new int[] { 1,1,8,3,1,1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isCentered15_5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isCentered15(new int[] { 9,15,6 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isCentered15_6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isCentered15(new int[] { 1,1,2,2,1,1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isCentered15_7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isCentered15(new int[] { 1,1,15,-1,-1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
