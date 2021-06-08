using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIU_CSharp_Class
{
    public class MIUSample
    {
        public static int getPOEOfArray(int[] A)
        {
            int POE = 1, FS = 0, RS = A[A.Length - 1], RearIdx = A.Length - 1;
            do
            {
                FS += A[POE - 1];
                if (FS > RS)
                {
                    while (RS < FS)
                    {
                        RS += A[RearIdx - 1];
                        RearIdx--;
                    }
                }
               if (FS < RS)
                {
                    POE ++;
                }
                if(FS == RS)
                {
                    if(POE == RearIdx - 1)
                    {
                        return POE;
                    }
                    else
                    {
                        POE++;
                    }
                }

            } while (POE < RearIdx);

            return -1;
        }
        public static int[] subSetArray(int[] first, int[] second)
        {
            if(first != null && second != null)
            {
                int minLen = 0;
                if (first.Length > second.Length)
                {
                    minLen = first.Length;
                }
                else
                {
                    minLen = second.Length;
                }
                int[] subsetArr = new int[minLen];
                int k = 0;
                for (int i = 0; i < first.Length; i++)
                {
                    for (int j = 0; j < second.Length; j++)
                    {
                        if (first[i] == second[j])
                        {
                            subsetArr[k] = first[i];
                            k++;
                        }
                    }

                }
                int[] resultArr = new int[k];
                for (int t = 0; t < k; t++)
                {
                    resultArr[t] = subsetArr[t];
                }
                return resultArr;
            }
            else
            {
                return null;
            }
            
        }
        public static int reverseInt(int n)
        {
            int reverse = 0;
            bool isNegative = false;

            if (n < 0)
                isNegative = true;

            n = Math.Abs(n);
            while (n > 0)
            {
                int rem = n % 10;
                reverse = (reverse * 10) + rem;
                n = n / 10;
            }

            if (isNegative)
                reverse = reverse * (-1);

            return reverse;

        }
        public static char[] getCharArrayByStartIndexnLength_Smart(char[] a, int start, int len)
        {
            //he function should do error checking on the start position and the length and return null if the either value is not legal.
            if (len < 0 || start < 0 || start + len > a.Length)
            {
                return null;
            }
            char[] arr = new char[len];
            for (int i = start, j = 0; j < len; i++, j++)
            {
                arr[j] = a[i];
            }
            return arr;
        }
        public static char[] getCharArrayByStartIndexnLength(char[] a, int start, int len){
            
            int totalLength = a.Length;
            int availableLength; 
            if(start >= 0 && len >= 0 && len <= totalLength)
            {
                if (start == 0)
                {
                    availableLength = totalLength;
                }
                else if( start > 0 && len < totalLength)
                {
                    availableLength = totalLength - start;
                }
                else
                {
                    return null;
                }
            }
            else {
                return null;
            }
            char[] arr = new char[len];
            if(len <= availableLength)
            {
                for (int i = 0; i < len; i++)
                {
                    arr[i] = a[start + i];
                }
                return arr;
            }
            else
            {
                return null;
            }          

        }
        public static int subtractOddSumToEvenSum(int[] a)
        {
            int X = 0; int Y = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)//odd
                {
                    X = X + a[i];
                }
                else
                {
                    Y = Y + a[i];
                }
            }
            return X - Y;

        }
        public static int isCenteredArray(int[] a)
        {
            int r = 0;
            if (a.Length % 2 != 0)//odd
            {
                int midIdx = a.Length / 2;
                int midElm = a[midIdx];

                for (int i = 0; i < a.Length; i++)
                {
                    if ((a[i] > midElm && i != midIdx) || i == midIdx)
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
