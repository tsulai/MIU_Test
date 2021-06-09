using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class matchPattern
    {
        [TestMethod]
        public void matchPattern1()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.matchPattern(new int[] { 1, 1, 1, 2, 2, 1, 1, 3 }, new int[] { 1, 2, 1, 3 });
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void matchPattern2()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.matchPattern(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1});
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void matchPattern3()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.matchPattern(new int[] { 1 }, new int[] { 1 });
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void matchPattern4()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.matchPattern(new int[] { 1, 1, 2, 2, 2, 2 }, new int[] { 1,2 });
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void matchPattern5()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.matchPattern(new int[] { 1, 2, 3 }, new int[] { 1,2 });
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void matchPattern6()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.matchPattern(new int[] { 1,2 }, new int[] { 1,2,3 });
            Assert.AreEqual(ans,0);
        }
        [TestMethod]
        public void matchPattern7()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.matchPattern(new int[] { 1, 1, 2, 2, 2, 2, 3 }, new int[] { 1,3 });
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void matchPattern8()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.matchPattern(new int[] { 1, 1, 1, 1 }, new int[] { 1,2 });
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void matchPattern9()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.matchPattern(new int[] { 1, 1, 1, 1, 2, 2, 3, 3 }, new int[] { 1,2 });
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void matchPattern10()
        {
            int ans;
            // Act
            ans = MIU_CSharp_Class.MIUInternetQuestions.matchPattern(new int[] { 1, 1, 10, 4, 4, 3 }, new int[] { 1,4,3 });
            Assert.AreEqual(ans, 0);
        }
    }
}
