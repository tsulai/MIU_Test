using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MIU_CSharp_Class;

namespace MIU_CSharp_UnitTest
{
    //[TestClass]
    public class MIUSampleUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.isCenteredArray(new int[] { 1, 2, 3, 4, 5 });
            // Assert
            Assert.AreEqual(ans, 0);            
        }
        [TestMethod]
        public void TestMethod2()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.isCenteredArray(new int[] { 3, 2, 1, 4, 5 });
            // Assert
            Assert.AreEqual(ans, 1);

        }
        [TestMethod]
        public void TestMethod3()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.isCenteredArray(new int[] { 3, 2, 1, 4, 1 });
            // Assert
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.isCenteredArray(new int[] { 1, 2, 3, 4 });
            // Assert
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.isCenteredArray(new int[] { });
            // Assert
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.isCenteredArray(new int[] { 10 });
            // Assert
            Assert.AreEqual(ans, 1);

        }
        [TestMethod]
        public void TestMethod7()
        {
            //int? ans = null;

        }
    }
}
