using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isOddHeavy
    {
        [TestMethod]
        public void isOddHeavy1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOddHeavy(new int[] { 11, 4, 9, 2, 8 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isOddHeavy2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOddHeavy(new int[] { 11, 4, 9, 2, 3, 10 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isOddHeavy3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOddHeavy(new int[] { 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isOddHeavy4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOddHeavy(new int[] { 2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isOddHeavy5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOddHeavy(new int[] { 1,1,1,1,1,1});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isOddHeavy6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOddHeavy(new int[] { 2,4,6,8,11 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);

        }
        [TestMethod]
        public void isOddHeavy7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isOddHeavy(new int[] {-2, -4, -6,-8, -11});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
