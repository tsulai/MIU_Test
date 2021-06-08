using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class IsMadhavArray
    {
       [TestMethod]
        public void isMadhavArrray()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMadhavArray(new int[] { 2, 1,1});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isMadhavArrray2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMadhavArray(new int[] { 2, 1, 1, 4, -1, -1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        
        [TestMethod]
        public void isMadhavArrray3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMadhavArray(new int[] { 6,2,4,2,2,2,1,5,0,0});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        
        [TestMethod]
        public void isMadhavArrray4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMadhavArray(new int[] { 18,9,10,6,6,6 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        
        [TestMethod]
        public void isMadhavArrray5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMadhavArray(new int[] { -6,-3,-3,8,-5,-4});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        
      [TestMethod]
        public void isMadhavArrray6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMadhavArray(new int[] { 0,0,0,0,0,0,0,0,0,0,1,1,1,-2,-1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        
        [TestMethod]
        public void isMadhavArrray7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isMadhavArray(new int[] { 3,1,2,3,0 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
