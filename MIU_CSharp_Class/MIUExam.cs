using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIU_CSharp_Class
{
    public class MIUExam
    {
        //testing class structure ...
        public static int checkConcatenatedSum(int n, int catlen)
        {
            int num = n, sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                num /= 10;
                for (int j = 1, i = 1; j <= catlen; j++)
                {
                    sum += digit * i;// 1st => 8 * 1 = 8, 2nd => 8 * 10 = 80
                    i *= 10;
                }
            }
            if (n == sum) return 1;
            return 0;
        }
    }
}
