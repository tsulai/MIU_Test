using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MIU_CSharp_Class;

namespace MIU_CSharp_UnitTest
{
    [TestClass]
    public class getPOEOfArray
    {
        [TestMethod]
        public void TestMethod1()
        {
            int ans ;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getPOEOfArray(new int[] { 1, 8, 3, 7, 10, 2 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans,3);            
        }
        [TestMethod]
        public void TestMethod2()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getPOEOfArray(new int[] { 1, 5,3,1,1,1,1,1,1 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getPOEOfArray(new int[] { 2, 1, 1, 1, 2, 1, 7 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 5);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getPOEOfArray(new int[] { 1,2,3 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getPOEOfArray(new int[] { 3, 4, 5, 10 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getPOEOfArray(new int[] { 1, 2, 10, 3, 4 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, -1);
        }

    }
}
