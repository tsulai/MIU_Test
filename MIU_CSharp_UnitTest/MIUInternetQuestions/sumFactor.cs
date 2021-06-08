using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class sumFactor
    {
        [TestMethod]
        public void sumFactor1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.sumFactor(new int[] { 1, -1,1,-1,1,-1,1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 4);
        }
        [TestMethod]
        public void sumFactor2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.sumFactor(new int[] { 3,0,2,-5,0});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 2);
        }
        [TestMethod]
        public void sumFactor3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.sumFactor(new int[] { 9,-3,-3,-1,-1});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void sumFactor4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.sumFactor(new int[] { 1});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void sumFactor5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.sumFactor(new int[] { 0,0,0 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 3);
        }
        [TestMethod]
        public void sumFactor6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.sumFactor(new int[] {  });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);

        }
    }
}
