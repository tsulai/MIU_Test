using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class statonMeasure
    {
        [TestMethod]
        public void statonMeasure1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.statonMeasure(new int[] { 1,4,3,2,1,2,3,2 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 3);
        }
        [TestMethod]
        public void statonMeasure2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.statonMeasure(new int[] { 1});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void statonMeasure3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.statonMeasure(new int[] { 0 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void statonMeasure4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.statonMeasure(new int[] { 3,1,1,4 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void statonMeasure5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.statonMeasure(new int[] { 1,3,1,1,3,3,2,3,3,3,4 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 6);
        }
        [TestMethod]
        public void statonMeasure6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.statonMeasure(new int[] { });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
