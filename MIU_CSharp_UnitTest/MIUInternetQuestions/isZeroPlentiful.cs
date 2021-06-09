using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isZeroPlentiful
    {
        [TestMethod]
        public void isZeroPlentiful1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isZeroPlentiful(new int[] { 0,0,0,0,0});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isZeroPlentiful2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isZeroPlentiful(new int[] { 1, 2, 0, 0, 0, 0, 2, -18, 0, 0, 0, 0, 0, 12 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 2);
        }
        [TestMethod]
        public void isZeroPlentiful3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isZeroPlentiful(new int[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 3);
        }
        [TestMethod]
        public void isZeroPlentiful4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isZeroPlentiful(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isZeroPlentiful5()
        {
            int ans;
            //given test array is { 1, 0, 0, 0, 2, 0, 0, 0 , 0 } then result should be 1 but its say 0; whose length is less<4
            ans = MIU_CSharp_Class.MIUInternetQuestions.isZeroPlentiful(new int[] { 1, 0, 0, 0, 2, 0, 0, 0 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isZeroPlentiful6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isZeroPlentiful(new int[] {0});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isZeroPlentiful7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isZeroPlentiful(new int[] { });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
