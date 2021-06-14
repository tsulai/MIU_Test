using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class eval
    {
        [TestMethod]
        public void eval1()
        {
            double ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.eval(1.0, new int[] { 0, 1, 2, 3, 4 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 10.0);
        }
        [TestMethod]
        public void eval2()
        {
            double ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.eval(3.0, new int[] { 3, 2, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 18.0);
        }
        [TestMethod]
        public void eval3()
        {
            double ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.eval(2.0, new int[] { 3, -2, -1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, -5.0);
        }
        [TestMethod]
        public void eval4()
        {
            double ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.eval(-3.0, new int[] { 3, 2, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 6.0);
            //
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.eval(2.0, new int[] { 3, 2 }), 7.0, "Test 5");
            //
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.eval(2.0, new int[] { 4,0,9 }), 40.0, "Test 6");
            //
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.eval(2.0, new int[] {10}), 10.0, "Test 7");
            //
            Assert.AreEqual(MIU_CSharp_Class.MIUInternetQuestions.eval(10.0, new int[] { 0,1}), 10.0, "Test 8");
            
        }
    }
}
