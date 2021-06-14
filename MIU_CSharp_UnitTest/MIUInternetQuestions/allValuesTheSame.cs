using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class allValuesTheSame
    {
        [TestMethod]
        public void allValuesTheSame1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.allValuesTheSame(new int[] { 1,1,1,1});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }

        [TestMethod]
        public void allValuesTheSame2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.allValuesTheSame(new int[] { 83,83,83 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void allValuesTheSame3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.allValuesTheSame(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void allValuesTheSame4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.allValuesTheSame(new int[] { 1, -2343456, 1, -2343456 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void allValuesTheSame5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.allValuesTheSame(new int[] { 0, 0, 0, 0, -1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void allValuesTheSame6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.allValuesTheSame(new int[] { 432123456 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void allValuesTheSame7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.allValuesTheSame(new int[] { -432123456 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void allValuesTheSame8()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.allValuesTheSame(new int[] {  });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
