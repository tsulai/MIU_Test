using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class encodeNumber
    {
        [TestMethod]
        public void encodeNumber1()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.encodeNumber(6936);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int?[] { 2, 2,2,3,17,17 });
        }
        [TestMethod]
        public void encodeNumber2()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.encodeNumber(2);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int?[] { 2 });
        }
        [TestMethod]
        public void encodeNumber3()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.encodeNumber(6);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int?[] { 2,3 });
        }
        [TestMethod]
        public void encodeNumber4()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.encodeNumber(14);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int?[] { 2, 7 });
        }
        [TestMethod]
        public void encodeNumber5()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.encodeNumber(24);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int?[] { 2, 2, 2, 3 });
        }
        [TestMethod]
        public void encodeNumber6()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.encodeNumber(1200);
            Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, new int?[] { 2, 2, 2, 2,3,5,5});
        }
        [TestMethod]
        public void encodeNumber7()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.encodeNumber(1);
            //Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, null);
        }
        [TestMethod]
        public void encodeNumber8()
        {
            int?[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.encodeNumber(-18);
            //Console.Write(String.Join(",", ans));
            //Assert
            CollectionAssert.AreEquivalent(ans, null);
        }
    }
}
