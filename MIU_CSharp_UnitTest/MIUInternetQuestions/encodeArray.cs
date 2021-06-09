using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class encodeArray
    {
        [TestMethod]
        public void encodeArray1()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.encodeArray(0);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int[] {1});
        }
        [TestMethod]
        public void encodeArray2()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.encodeArray(1);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int[] { 0,1 });
        }
        [TestMethod]
        public void encodeArray3()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.encodeArray(-1);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int[] { -1, 0, 1 });
        }
        [TestMethod]
        public void encodeArray4()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.encodeArray(100001);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int[] { 0, 1, 1, 1, 1, 1, 0, 1 });
        }
        [TestMethod]
        public void encodeArray5()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.encodeArray(999);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });
        }
    }
}
