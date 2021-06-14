using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class findSmallestBEQnumber
    {
        [TestMethod]
        public void findSmallestBEQnumber1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.findSmallestBEQnumber(), 716, "TEST 1");
        }
    }
}
