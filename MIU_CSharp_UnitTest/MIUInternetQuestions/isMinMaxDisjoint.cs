using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isMinMaxDisjoint
    {
        [TestMethod]
        public void isMinMaxDisjoint1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMinMaxDisjoint(new int[] { 5,4,1,3,2});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isMinMaxDisjoint2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMinMaxDisjoint(new int[] { 18, -1, 3, 4, 0 } );
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isMinMaxDisjoint3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMinMaxDisjoint(new int[] { 9, 0, 5, 9 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isMinMaxDisjoint4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMinMaxDisjoint(new int[] { 0, 5, 18, 0, 9 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isMinMaxDisjoint5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMinMaxDisjoint(new int[] { 7,7,7,7 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isMinMaxDisjoint6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMinMaxDisjoint(new int[] { });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isMinMaxDisjoint7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMinMaxDisjoint(new int[] { 1,2});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isMinMaxDisjoint8()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMinMaxDisjoint(new int[] { 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
