using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isCubePowerful
    {
        [TestMethod]
        public void isCubePowerful1()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isCubePowerful(153);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isCubePowerful2()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isCubePowerful(370);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isCubePowerful3()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isCubePowerful(371);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isCubePowerful4()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isCubePowerful(407);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isCubePowerful5()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isCubePowerful(87);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isCubePowerful6()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isCubePowerful(0);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isCubePowerful7()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isCubePowerful(-81);
            Assert.AreEqual(ans, 0);
        }
    }
}
