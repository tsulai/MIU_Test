using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class henry
    {
        [TestMethod]
        public void henry1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.henry(1,3);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 502);
        }
    }
}
