using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MIU_CSharp_UnitTest.MIUInternetQuestions
{
    [TestClass]
    public class updateMileagecounter
    {
        [TestMethod]
        public void updateMileagecounter1()
        {
            //MIU_CSharp_Class.MIUInternetQuestions.updateMileagecounter(new int [] { 8, 9, 9, 5, 0},  1);
            //MIU_CSharp_Class.MIUInternetQuestions.updateMileagecounter(new int[] { 8, 9, 9, 5, 0 }, 2);
            //MIU_CSharp_Class.MIUInternetQuestions.updateMileagecounter(new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, 1);
           MIU_CSharp_Class.MIUInternetQuestions.updateMileagecounter(new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, 13);
        }
    }
}
