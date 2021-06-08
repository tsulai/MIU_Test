using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MIU_Test_CSharp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] Arr = { 1, 2, 3, 4, 5 };
            var v = IsCenteredArr(new int[] { 10});
            this.Inp_Txt.Text = v.ToString();

        }
        static int IsCenteredArr(int[] a)
        {
            int r = 0;
            if (a.Length % 2 != 0)//odd
            {
                int midIdx = a.Length / 2;
                int midElm = a[midIdx];
                
                for (int i = 0; i< a.Length; i++)
                {
                    if((a[i] > midElm && i != midIdx) || i == midIdx)
                    {
                        r = 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return r;
        }
    }
}