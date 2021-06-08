using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isLegalNumber
    {
        [TestMethod]
        public void isLegalNumber1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isLegalNumber(new int[] { 3,2,1},4 );
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isLegalNumber2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isLegalNumber(new int[] { 3, 7, 1 }, 6);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
