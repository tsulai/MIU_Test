using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isRailroadTie
    {
        [TestMethod]
        public void isRailroadTie1()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isRailroadTie(new int[] { 1, 2, 0, 3, -18, 0, 2, 2 });
            Console.WriteLine(ans);
            //Assert
           Assert.AreEqual(ans,1);
        }
        [TestMethod]
        public void isRailroadTie2()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isRailroadTie(new int[] { 1, 2 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isRailroadTie3()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isRailroadTie(new int[] { 1, 2, 0, 1, 2, 0, 1, 2 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isRailroadTie4()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isRailroadTie(new int[] { 3, 3, 0, 3, 3, 0, 3, 3, 0, 3, 3 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isRailroadTie5()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isRailroadTie(new int[] { 0,0,0,0 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isRailroadTie6()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isRailroadTie(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 0);

        }
        [TestMethod]
        public void isRailroadTie7()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isRailroadTie(new int[] { 1, 3, 0, 3, 5, 0 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 0);
        }
    }
}
