using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class clusterCompression
    {
        [TestMethod]
        public void clusterCompression1()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.clusterCompression(new int[] { 3, 3, 3, 4, 4, 3, 2, 2, 2, 2, 4 });
            //Assert
            CollectionAssert.AreEqual(ans, new int[] { 3, 4, 3, 2, 4 });
        }
        [TestMethod]
        public void clusterCompression2()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.clusterCompression(new int[] { 0, 0, 0, 2, 0, 2, 0, 2, 0, 0 });
            //Assert
            CollectionAssert.AreEqual(ans, new int[] { 0, 2, 0, 2, 0, 2, 0 });
        }
        [TestMethod]
        public void clusterCompression3()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.clusterCompression(new int[] { 18});
            //Assert
            CollectionAssert.AreEqual(ans, new int[] { 18 });
        }
        [TestMethod]
        public void clusterCompression4()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.clusterCompression(new int[] { });
            //Assert
            CollectionAssert.AreEqual(ans, new int[] {  });
        }
        [TestMethod]
        public void clusterCompression5()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.clusterCompression(new int[] { -5, -5, -5, -5, -5 });
            //Assert
            CollectionAssert.AreEqual(ans, new int[] { -5 });
        }
        [TestMethod]
        public void clusterCompression6()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.clusterCompression(new int[] { 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1 });
            //Assert
            CollectionAssert.AreEqual(ans, new int[] { 1,2,1});
        }
        [TestMethod]
        public void clusterCompression7()
        {
            int[] ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.clusterCompression(new int[] { 8, 8, 6, 6, -2, -2, -2 });
            //Assert
            CollectionAssert.AreEqual(ans, new int[] { 8, 6, -2 });
        }

    }
        
}
