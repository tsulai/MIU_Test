using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class doIntegrBasedRounding
    {
        [TestMethod]
        public void doIntegrBasedRounding1()
        {
            
             MIU_CSharp_Class.MIUInternetQuestions.doIntegrBasedRounding(new int[] { 1, 2, 3, 4, 5 }, 2);
            MIU_CSharp_Class.MIUInternetQuestions.doIntegrBasedRounding(new int[] { 1, 2, 3, 4, 5 }, 3);
            MIU_CSharp_Class.MIUInternetQuestions.doIntegrBasedRounding(new int[] { 1, 2, 3, 4, 5 }, -3);
            MIU_CSharp_Class.MIUInternetQuestions.doIntegrBasedRounding(new int[] { -1, -2, -3, -4, -5 }, 3);
            MIU_CSharp_Class.MIUInternetQuestions.doIntegrBasedRounding(new int[] { -18, 1, 2, 3, 4, 5 }, 4);
            MIU_CSharp_Class.MIUInternetQuestions.doIntegrBasedRounding(new int[] { 1, 2, 3, 4, 5 }, 5);
            MIU_CSharp_Class.MIUInternetQuestions.doIntegrBasedRounding(new int[] { 1, 2, 3, 4, 5 }, 100);

        }
    }
}
