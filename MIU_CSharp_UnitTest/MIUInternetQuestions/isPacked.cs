using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isPacked
    {
        [TestMethod]
        public void isPacked1()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] { 2,2,3,3,3 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isPacked2()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] { 2, 3, 2, 3, 3 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isPacked3()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] { 2, 2, 2, 3, 3, 3 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isPacked4()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] { 2, 2, 1 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isPacked5()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] { 2, 2, 1, 2, 2 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isPacked6()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] { 4,4,4,4,1,2,2,3,3,3});
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isPacked7()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] { 7,7,7,7,7,7,7,1});
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isPacked8()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] { 7,7,7,7,1,7,7,7});
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isPacked9()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] { 7, 7, 7, 7, 7, 7, 7 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isPacked10()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] {  });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isPacked11()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] {1,2,1 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isPacked12()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] { 2, 1,1});
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isPacked13()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] { -3,-3,-3 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isPacked14()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] { 0,2,2 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isPacked15()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.isPacked(new int[] { 2,1,2 });
            Console.WriteLine(ans);
            //Assert
            Assert.AreEqual(ans, 0);
        }

    }
}
