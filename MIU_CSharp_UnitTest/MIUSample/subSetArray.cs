using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MIU_CSharp_Class;

namespace MIU_CSharp_UnitTest
{
  // [TestClass]
    public class subSetArray
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] ans ;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subSetArray(new int[] { 1, 8, 3, 2 }, new int[] { 4, 2, 6, 1 });
            //Assert
            CollectionAssert.AreEqual(ans,new int [] {1,2});            
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subSetArray(new int[] { 1, 8, 3, 2, 6 }, new int[] { 2, 6, 1 });
            Console.Write(String.Join(",", ans));          
            //Assert
            CollectionAssert.AreEquivalent(ans, new int[] { 2, 6, 1 } );
            
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subSetArray(new int[] { 1, 3, 7, 9 }, new int[] { 7,9,1,3 });
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEqual(ans, new int[] { 1, 3, 7, 9 });
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subSetArray(new int[] { 1, 2 }, new int[] { 3,4 });
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEqual(ans, new int[] { });
        }
       [TestMethod]
        public void TestMethod5()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subSetArray(new int[] {  }, new int[] { 1,2,3 });
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEqual(ans, new int[] {  });
        }
        [TestMethod]
        public void TestMethod6()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subSetArray(new int[] { 1,2 }, new int[] { });
            //Assert
            CollectionAssert.AreEqual(ans, new int[] {  });
        }
        [TestMethod]
        public void TestMethod7()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subSetArray(new int[] { 1,2}, null);
            //Assert
            CollectionAssert.AreEqual(ans, null);
        }
        [TestMethod]
        public void TestMethod8()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subSetArray(null, new int[] {  });
            //Assert
            CollectionAssert.AreEqual(ans, null);
        }
       [TestMethod]
        public void TestMethod9()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUSample.subSetArray(null, null);
            //Assert
            CollectionAssert.AreEqual(ans,null);
        }


    }
}
