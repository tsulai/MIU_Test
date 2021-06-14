using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class computeHMS
    {
        [TestMethod]
        public void computeHMS1()
        {
            int[] ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.computeHMS(3735);
            Console.Write(String.Join(",", ans));
            CollectionAssert.AreEqual(ans, new int[] { 1, 2, 15 });
        }
        [TestMethod]
        public void computeHMS2()
        {
            int[] ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.computeHMS(380);
            Console.Write(String.Join(",", ans));
            CollectionAssert.AreEqual(ans, new int[] {0,6,20 });
        }
        [TestMethod]
        public void computeHMS3()
        {
            int[] ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.computeHMS(3650);
            Console.Write(String.Join(",", ans));
            CollectionAssert.AreEqual(ans, new int[] { 1,0,50 });
        }
        [TestMethod]
        public void computeHMS4()
        {
            int[] ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.computeHMS(55);
            Console.Write(String.Join(",", ans));
            CollectionAssert.AreEqual(ans, new int[] { 0,0,55 });
        }
        [TestMethod]
        public void computeHMS5()
        {
            int[] ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.computeHMS(0);
            Console.Write(String.Join(",", ans));
            CollectionAssert.AreEqual(ans, new int[] { 0,0,0});
        }
    }
}
