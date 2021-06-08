using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class filterArray
    {
        [TestMethod]
        public void filterArray1()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.filterArray(new int[] { 8,4,9,0,3,1,2 }, 88 );
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int[] { 0,3,2 });
        }
        [TestMethod]
        public void filterArray2()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.filterArray(new int[] { 18 }, 88);
            //Console.Write(String.Join(",", ans));
            //Assert
            Assert.AreEqual(ans,null);
        }
        [TestMethod]
        public void filterArray3()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.filterArray(new int[] { 9,-9}, 0);
            //Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int?[] { });
        }
        [TestMethod]
        public void filterArray4()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.filterArray(new int[] { 9, -9 }, 1);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int[] { 9 });
        }
        [TestMethod]
        public void filterArray5()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.filterArray(new int[] { 9, -9 }, 2);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int[] { -9 });
        }
        [TestMethod]
        public void filterArray6()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.filterArray(new int[] { 9, -9 }, 3);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int[] { 9,-9 });
        }
        [TestMethod]
        public void filterArray7()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.filterArray(new int[] { 9, -9 }, 4);
            //Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, null);
        }
        [TestMethod]
        public void filterArray8()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.filterArray(new int[] { 9, -9 , 5}, 3);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int[] { 9, -9 });
        }
        [TestMethod]
        public void filterArray9()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.filterArray(new int[] { 0, 9,12,18,-6 }, 11);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int[] { 0,9,18 });
        }
    }
}
