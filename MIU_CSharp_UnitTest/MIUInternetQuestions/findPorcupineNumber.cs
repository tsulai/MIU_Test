using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class findPorcupineNumber
    {
        [TestMethod]
        public void findPorcupineNumber1()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.findPorcupineNumber(0);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 139);
        }
        [TestMethod]
        public void findPorcupineNumber2()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.findPorcupineNumber(139);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 409);
        }
        [TestMethod]
        public void findPorcupineNumber3()
        {
            int ans;
            ans = MIU_CSharp_Class.MIUInternetQuestions.findPorcupineNumber(30);
            Console.WriteLine(ans);
            Assert.AreEqual(ans, 139);
        }
    }
}
