using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIU_CSharp_Class
{
    public class MIUExam
    {
        public static int isSelfReferential(int[] a)
        {
            int count = 0, result = 0;
            for(int i = 0; i<a.Length; i++)
            {
                count = 0;
                foreach(int k in a)
                {
                    if(k == i)
                    {
                        count++;
                    }
                }
                if (count != a[i]) return 0;
                else result = 1;
            }
            return result;
        }
        public static int is235Array(int[] a)
        {
            int div2Count = 0, div3Count = 0, div5Count = 0, nonDivCount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0) div2Count++;
                if (a[i] % 3 == 0) div3Count++;//use 'if' again as 6 is divisible by both 2 and 3
                if (a[i] % 5 == 0) div5Count++;//with else if, only either one work
                if (a[i] % 2 != 0 && a[i] % 3 != 0 && a[i] % 5 != 0) nonDivCount++;
            }
            if (a.Length == div2Count + div3Count + div5Count + nonDivCount) return 1;
            else return 0;
        }
        public static int closestFibonacci(int n)
        {
            if (n < 1) return 0;
            int fbn1 = 1, fbn2 = 1, nextFbn = 0;
            for (int i = 3; i <= n; i++)
            {
                nextFbn = fbn1 + fbn2;

                if (nextFbn > n) return fbn2;
                fbn1 = fbn2;
                fbn2 = nextFbn;
            }
            return nextFbn;
        }
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
