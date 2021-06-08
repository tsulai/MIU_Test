using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class countRepresentations
    {
        [TestMethod]
        public void TestMethod1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.countRepresentations(12);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 15);
        }
    }
}
