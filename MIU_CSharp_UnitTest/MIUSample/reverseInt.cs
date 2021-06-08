using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MIU_CSharp_Class;

namespace MIU_CSharp_UnitTest
{
    //[TestClass]
    public class reverseInt
    {
        [TestMethod]
        public void TestMethod1()
        {
            int ans ;
            int n = 1234;
            // Act
            ans = MIU_CSharp_Class.MIUSample.reverseInt(n);
            //Assert
            Assert.AreEqual(ans, 4321);            
        }
        [TestMethod]
        public void TestMethod2()
        {
            int ans;
            int n = 12005;
            // Act
            ans = MIU_CSharp_Class.MIUSample.reverseInt(n);
            //Assert
            Assert.AreEqual(ans, 50021);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int ans;
            int n = 1;
            // Act
            ans = MIU_CSharp_Class.MIUSample.reverseInt(n);
            //Assert
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int ans;
            int n = 1000;
            // Act
            ans = MIU_CSharp_Class.MIUSample.reverseInt(n);
            //Assert
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int ans;
            int n = 0;
            // Act
            ans = MIU_CSharp_Class.MIUSample.reverseInt(n);
            //Assert
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int ans;
            int n = -12345;
            // Act
            ans = MIU_CSharp_Class.MIUSample.reverseInt(n);
            //Assert
            Assert.AreEqual(ans, -54321);
        }

    }
}
