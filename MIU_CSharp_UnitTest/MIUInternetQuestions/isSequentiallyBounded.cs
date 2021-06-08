using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isSequentiallyBounded
    {
        [TestMethod]
        public void isSequentiallyBounded1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequentiallyBounded(new int[] { 2, 3, 3, 99, 99, 99, 99, 99 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isSequentiallyBounded2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequentiallyBounded(new int[] { 1,2,3 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSequentiallyBounded3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequentiallyBounded(new int[] { 2, 3, 3, 3, 3 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSequentiallyBounded4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequentiallyBounded(new int[] { 0,1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSequentiallyBounded5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequentiallyBounded(new int[] { -1,2});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isSequentiallyBounded6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequentiallyBounded(new int[] { });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isSequentiallyBounded7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequentiallyBounded(new int[] { 5, 5, 5, 5 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isSequentiallyBounded8()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isSequentiallyBounded(new int[] { 5,5,5,2,5 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }          
        
    }
}
