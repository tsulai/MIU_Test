using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class decodeArray
    {
        [TestMethod]
        public void decodeArray1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.decodeArray(new int[] { 2, -3, -2, 6, 9, 18 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 51839);
        }
        [TestMethod]
        public void decodeArray2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.decodeArray(new int[] { 0, -3, 0, -4, 0 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 3344);
        }
        [TestMethod]
        public void decodeArray3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.decodeArray(new int[] { -1, 5, 8, 17, 15 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, -6392);
        }
        [TestMethod]
        public void decodeArray4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.decodeArray(new int[] { 1, 5, 8, 17, 15 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 4392);
        }
        [TestMethod]
        public void decodeArray5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.decodeArray(new int[] { 111, 115, 118, 127, 125 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 4392);
        }
        [TestMethod]
        public void decodeArray6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.decodeArray(new int[] { 1,1});
            Console.WriteLine(ans);
            Assert.AreEqual(ans,0);
        }
    }
}
