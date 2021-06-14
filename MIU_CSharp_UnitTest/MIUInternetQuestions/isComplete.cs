using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isComplete
    {
        [TestMethod]
        public void isComplete1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isComplete(new int[] { 36, -28 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isComplete2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isComplete(new int[] { 36, 28 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isComplete3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isComplete(new int[] {4 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isComplete4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isComplete(new int[] { 3, 2, 1, 1, 5, 6 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isComplete5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isComplete(new int[] { 3, 7, 23, 13, 107, -99, 97, 81 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
