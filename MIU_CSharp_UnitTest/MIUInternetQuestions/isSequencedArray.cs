using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isSequencedArray
    {
        [TestMethod]
        public void isSequencedArray1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequencedArray(new int[]  { 2, 2, 3, 4, 4, 4, 5 }, 2,5 );
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isSequencedArray2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequencedArray(new int[] { 2, 2, 3, 5, 5 }, 2, 5);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSequencedArray3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequencedArray(new int[] { 0, 2, 2, 3, 3 }, 2, 3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSequencedArray4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequencedArray(new int[] { 1, 1, 3, 2, 2, 4 }, 1, 4);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSequencedArray5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequencedArray(new int[] { 1, 2, 3, 4, 5 }, 1, 5);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isSequencedArray6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequencedArray(new int[] { 1, 3, 4, 2, 5 }, 1, 5);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSequencedArray7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequencedArray(new int[] { -5, -5, -4, -4, -4, -3, -3, -2, -2, -2 }, -5, -2);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isSequencedArray8()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequencedArray(new int[] { 0, 1, 2, 3, 4, 5 }, 1, 5);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSequencedArray9()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequencedArray(new int[] { 1, 2, 3, 4 }, 1, 5);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSequencedArray10()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequencedArray(new int[] { 1, 2,5 }, 1, 5);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSequencedArray11()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequencedArray(new int[] { 5,4,3,2,1 }, 1, 5);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
