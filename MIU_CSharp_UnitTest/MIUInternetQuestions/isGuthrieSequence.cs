using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class isGuthrieSequence
    {
        [TestMethod]
        public void isGuthrieSequence1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isGuthrieSequence(new int[] {8,4,2,1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 1);
        }
        [TestMethod]
        public void isGuthrieSequence2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isGuthrieSequence(new int[] { 8, 17, 4, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans,0);
        }
        [TestMethod]
        public void isGuthrieSequence3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isGuthrieSequence(new int[] { 8, 4, 1 });
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
        [TestMethod]
        public void isGuthrieSequence4()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.isGuthrieSequence(new int[] { 8, 4, 2});
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 0);
        }
    }
}
