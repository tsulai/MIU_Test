using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class solve10
    {
        [TestMethod]
        public void solve101()
        {
            int[] ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.solve10();
            Console.Write(String.Join(",", ans));
            //Assert.AreEqual(ans, 3);
        }
    }
}
