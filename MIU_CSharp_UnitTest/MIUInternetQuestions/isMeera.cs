using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isMeera
    {
        [TestMethod]
        public void isMeera1()
        {
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera(new int[] { 3,5,-2 }), 1, "TEST 1");
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.isMeera(new int[] {8,3,4 }), 0, "TEST 2");
        }
    }
}
