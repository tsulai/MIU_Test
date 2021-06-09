using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class decodeArray01
    {
        [TestMethod]
        public void decodeArray01_1()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.decodeArray01(new int[] { 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 1234);
        }
        [TestMethod]
        public void decodeArray01_2()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.decodeArray01(new int[] {1 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void decodeArray01_3()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.decodeArray01(new int[] { 0, 1 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void decodeArray01_4()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.decodeArray01(new int[] { -1,0,1 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void decodeArray01_5()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.decodeArray01(new int[] { 0, 1, 1, 1, 1, 1, 0, 1 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 100001);
        }
        [TestMethod]
        public void decodeArray01_6()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.decodeArray01(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 999);
        }
    }
}
