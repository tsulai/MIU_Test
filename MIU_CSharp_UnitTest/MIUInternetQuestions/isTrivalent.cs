using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isTrivalent
    {
        [TestMethod]
        public void isTrivalent1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isTrivalent(new int[] { 22, 19, 10, 10, 19, 22, 22, 10 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isTrivalent2()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isTrivalent(new int[] { 1, 2, 2, 2, 2, 2, 2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isTrivalent3()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isTrivalent(new int[] { 2, 2, 3, 3, 3, 3, 2, 41, 65 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isTrivalent4()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isTrivalent(new int[] { -1, 0, 1, 0, 0, 0 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isTrivalent5()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isTrivalent(new int[] {  });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isTrivalent6()
        {

            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isTrivalent(new int[] { 2147483647, -1, -1, -2147483648});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
