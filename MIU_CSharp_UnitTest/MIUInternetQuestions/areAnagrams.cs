using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class areAnagrams
    {
        [TestMethod]
        public void areAnagrams1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.areAnagrams(new char[] { 'p','o','o','l' }, new char[] { 'p', 'o', 'l', 'l' } );
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void areAnagrams2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.areAnagrams(new char[] { 's', 'i', 't' }, new char[] { 'i', 't', 's' });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void areAnagrams3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.areAnagrams(new char[] { 's', 'i', 't' }, new char[] { 'i', 'd', 's' });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void areAnagrams4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.areAnagrams(new char[] { 'b', 'i', 'g' }, new char[] { 'b', 'i', 't' });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void areAnagrams5()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.areAnagrams(new char[] { 'b', 'o', 'g' }, new char[] { 'b', 'o', 'o' });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void areAnagrams6()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.areAnagrams(new char[] {  }, new char[] {  });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void areAnagrams7()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.areAnagrams(new char[] { 'b', 'i', 'g' }, new char[] { 'b', 'i', 'g' });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
    }
}
