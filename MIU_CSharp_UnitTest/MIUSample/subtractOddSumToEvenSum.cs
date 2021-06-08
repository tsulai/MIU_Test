using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MIU_CSharp_Class;

namespace MIU_CSharp_UnitTest
{
   // [TestClass]
    public class MIUSampleUnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subtractOddSumToEvenSum(new int[] { 1});
            // Assert
            Assert.AreEqual(ans, 1);            
        }
        [TestMethod]
        public void TestMethod2()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subtractOddSumToEvenSum(new int[] { 1,2 });
            // Assert
            Assert.AreEqual(ans, -1);

        }
        [TestMethod]
        public void TestMethod3()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subtractOddSumToEvenSum(new int[] { 1,2,3 });
            // Assert
            Assert.AreEqual(ans, 2);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subtractOddSumToEvenSum(new int[] { 1, 2, 3, 4 });
            // Assert
            Assert.AreEqual(ans, -2);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subtractOddSumToEvenSum(new int[] {3,3,4,4 });
            // Assert
            Assert.AreEqual(ans, -2);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subtractOddSumToEvenSum(new int[] {3,2,3,4 });
            // Assert
            Assert.AreEqual(ans, 0);

        }
        [TestMethod]
        public void TestMethod7()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subtractOddSumToEvenSum(new int[] { 4, 1, 2, 3 });
            // Assert
            Assert.AreEqual(ans, -2);

        }
        [TestMethod]
        public void TestMethod8()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subtractOddSumToEvenSum(new int[] { 1,1 });
            // Assert
            Assert.AreEqual(ans, 2);

        }
        [TestMethod]
        public void TestMethod9()
        {
            int? ans = null;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subtractOddSumToEvenSum(new int[] { });
            // Assert
            Assert.AreEqual(ans, 0);

        }
    }
}
