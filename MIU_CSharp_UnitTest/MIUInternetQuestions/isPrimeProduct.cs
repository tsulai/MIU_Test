using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isPrimeProduct
    {
        [TestMethod]
        public void isPrimeProduct1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isPrimeProduct(1219), 1, "TEST 1");
        }
    }
}
