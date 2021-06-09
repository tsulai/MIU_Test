using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIU_CSharp_Class
{
    public class MIUInternetQuestions
    {
        public static int areAnagrams(char[] a1, char[] a2)
        {
            if (a1.Length != a2.Length) return 0;
            if (a1.Length < 1 && a2.Length < 1) return 1;

            char[] a2Copy = new char[a2.Length];
            a2Copy = a2;
            for(int i=0; i <a1.Length; i++)
            {
                for(int j =0; j< a2Copy.Length; j++)
                {
                    if(a1[i] == a2Copy[j])
                    {
                        a2Copy = new string(a2Copy).Remove(j,1).ToCharArray();//remove to prevent duplicate char
                        break;
                    }
                    else if(a1[i] != a2Copy[j] && j == a2Copy.Length - 1)//a1 elm not in a2
                    {
                        return 0;
                    }
                }
            }
            if (a2Copy.Length == 0) return 1;
            else return 0;
        }
        public static int isHodder(int n)
        {
            if(isPrime(n) == 1)
            {
                int fact2 = 1;
                while (true)
                {
                    fact2 *= 2;
                    if (n == fact2 - 1) return 1;
                    else if (fact2 - 1 > n) return 0; 
                }
            }
            return 0;
        }
        public static int largestDifferenceOfEvens(int[] a)
        {
            int max = 0, min = 0, evenCount = 0;
            for(int i=0; i<a.Length; i++)
            {
                if(a[i]%2 == 0)
                {
                    evenCount++;
                    if(evenCount == 1)//min must have actually array value first
                    {
                        max = a[i];
                        min = a[i];
                    }
                    if (max < a[i]) max = a[i];
                    if (a[i] < min) min = a[i];
                }
            }
            if (evenCount < 2) return -1;
            else return max - min;
        }
        //must b prime
        //that prime must equal to factorial(n) + 1
        //if n =7, 7 is prime and equal to factorial(3)+1 which is (1*2*3) + 1
        public static int isFactorialPrime(int n)
        {
            if (isPrime(n) == 1)
            {
                int num = 1, factVal = 1;
                while (factVal < n)
                {
                    for (int i = 1; i < num; i++)
                    {
                        factVal *= i + 1; //1*2*3
                    }
                    if (factVal + 1 == n) return 1;
                    else if (factVal + 1 < n)
                    {
                        num++;
                        factVal = 1;//new num, need to clear old factVal
                    }
                    else return 0;
                }
            }            
            return 0;
        }
        public static int isSystematicallyIncreasing(int[] a)
        {
            int pointer = 0, isSysInc = 0;
            if (a[pointer] != 1) return 0;
            else isSysInc = 1;
            pointer++;
            int inc = 2;
            while (pointer < a.Length)
            {
                for(int i=1; i<= inc; i++)
                {
                    if (a[pointer] == i) isSysInc = 1;
                    else return 0;
                }
                inc++;                
            }
            return isSysInc;
        }
        public static int[] encodeArray(int n)
        {
            int digit, num1 = Math.Abs(n), num2 = Math.Abs(n), idx = 0, size = 0;
            if (n == 0) return new int[] { 1 }; //if n=0, while is not working
            while (num1 != 0)
            {
                digit = num1 % 10;
                num1 /= 10;
                size += digit + 1;// 3 = 0001, take 4 places
            }
            if (n < 0)
            {
                size += 1;
            }

            int[] encodedArr = new int[size];

            if (n < 0)
            {
                encodedArr[idx] = -1;
                idx++;
            }
            while (num2 != 0)
            {
                digit = num2 % 10;
                num2 /= 10;                
                if(digit == 0)
                {
                    encodedArr[idx] = 1;
                    idx++;
                }
                else
                {
                    for (int j = 0; j <= digit; j++)
                    {
                        if (j == digit) encodedArr[idx] = 1;
                        else encodedArr[idx] = 0;//place 0 as per digit times
                        idx++;
                    }
                }
                
            }
            return encodedArr;
        }
        public static int isPrimeHappy(int n)
        {
            if (n < 3) return 0;
            int primeCount = 0, primeSum = 0;
            for(int i=2; i<n; i++)
            {
                if(isPrime(i) == 1)
                {
                    primeCount++;
                    primeSum += i;
                }
            }
            if (primeCount > 1 && primeSum % n == 0) return 1;
            else return 0;
        }
        //if j >= 0 and k>= 0 and
        //j+k = length of array and (note* j,k is index no.)
        //j!= k then a[j]+a[k] <= 10
        // j+k = length of array means
        // {1,2,19,4,5} - array start from 0 zero, so lenght is 4
        //j=0 + k=4 == 4 == true, then a[0] + a[4] = 1+5 <= 10 also true, then onion array
        public static int isOnionArray(int[] a)
        {
            int lowerIdx = 0, upperIdx = a.Length - 1, isOnion = 1;
            while(lowerIdx< upperIdx)
            {
                if(a[lowerIdx] + a[upperIdx] <= 10)
                {
                    isOnion = 1;
                }
                else
                {
                    isOnion = 0;
                    break;
                }
                lowerIdx++;
                upperIdx--;
            }
            return isOnion;
        }
        // 1 = 01
        // 2 = 001
        // 3 = 0001
        // 4 = 00001
        // 5 = 000001
        // -(negative sign) = -1  
        // 0 = 1
        public static int decodeArray01(int[] a)
        {
            int noOfZero = 0; 
            string numStr = string.Empty;            
            for (int i = 0 ; i< a.Length; i++)
            {
                if (a[i] < 0) numStr += "-";
                if(a[i] != 0)//found 1
                {
                    if (noOfZero > 0)
                    {
                        numStr += noOfZero;
                        noOfZero = 0;
                    }
                    else numStr += "0";
                }
                else if(a[i] == 0)
                {
                    noOfZero++;
                }
            }
            return int.Parse(numStr);
        }
        //n between 1 to 9
        public static int isDigitIncreasing(int n)
        {
            int sum = 0, i, j = 1;
            while (j <= 9)
            {
                i = j;
                while (true)
                {                                    
                    sum += i;
                    if (sum == n) return 1;
                    else if (sum > n)
                    {
                        break;
                    }
                    else
                    {
                        i = (i * 10) + j;// 1 * 10 + 1 = 111
                        //seperate j need as to add + 1 when doing 1 + 11 + 111, +2 when 2+ 22+ 222
                    }
                }
                j++;
                sum = 0;//clear the sum again
            }
            return 0;
        }
        public static int isZeroPlentiful(int[] a)
        {
            if (a.Length < 1) return 0;
            int noOfZero = 0, count = 0;
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] != 0)
                {
                    if (noOfZero < 4)
                    { 
                        noOfZero = 0; 
                    }
                    else
                    {
                        count++; 
                        noOfZero = 0;
                    }
                }
                if (a[i] == 0)
                {
                    noOfZero++;
                }
                if (i == a.Length - 1 && noOfZero >= 4) count++;//for not miss counting till end with 0
            }            
            return count;
        }
        public static int decodeArray(int[] a)
        {
            if (a.Length < 2) return 0;
            string numStr = string.Empty;
            if (a[0] < 0) numStr += "-";
            for (int i =0; i<a.Length-1; i++)
            {                
                numStr += Math.Abs(a[i] - a[i + 1]);
            }
            return int.Parse(numStr);
        }
        public static int isCubePowerful(int n)
        {
            if (n < 1) return 0;
            int digit, sum = 0, num = n;
            while (num != 0)
            {
                digit = num % 10;
                num /= 10;
                sum += digit * digit * digit;
            }
            if (n == sum) return 1;
            else return 0;
        }
        public static void doIntegrBasedRounding(int[] a, int n)
        {
            if(a.Length > 1 && n > 0)
            {
                int factor, startR, endR;
                for(int i=0; i<a.Length; i++)
                {
                    factor = a[i] / n; //26/4 = 6
                    startR = n * factor; // startRound = 4 * 6 = 24
                    endR = n * (factor + 1); // endRound = 4 * 7 = 28
                    //a[i] is between 24 && 28
                    if(a[i] > 0)
                    {
                        if (a[i] - startR < endR - a[i])
                        {
                            a[i] = startR;
                        }
                        else if (a[i] - startR > endR - a[i])
                        {
                            a[i] = endR;
                        }
                        else
                        {
                            a[i] = endR;
                        }
                    }
                }
            }
            //Console.Write(String.Join(",", a));
        }
        public static int matchPattern(int[] a, int[] pattern)
        {
            // len is the number of elements in the array a, patternLen is the number of elements in the pattern.
            int i = 0; // index into a
            int k = 0; // index into pattern
            int matches = 0; // how many times current pattern character has been matched so far
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == pattern[k])
                    matches++; // current pattern character was matched
                else if (matches == 0 || k == pattern.Length - 1)
                    return 0; // if pattern[k] was never matched (matches==0) or at end of pattern (k==patternLen-1)
                else // advance to next pattern character {
                {
                    //!!You write this code!!
                    if (a[i] == pattern[k + 1])//when value change in a
                    {
                        matches++;
                        k = k + 1;
                    }
                    else return 0;
                    
                } // end of else
            } // end of for
            // return 1 if at end of array a (i==len) and also at end of pattern (k==patternLen-1)
            if (i==a.Length && k== pattern.Length-1) return 1; else return 0;
        }

        public static int?[] encodeNumber(int n)
        {
            if (n <= 1) return null;
            int divider = 2, count = 0, idx = 0;
            int?[] result = new int?[count];
            while (n!= 1)
            {
                if (isPrime(divider) == 1)
                {
                    if (n % divider == 0)//unless can divide, it's not factor
                    {//keep dividing the result so that it can get same factor 2*2*2*3*3
                        n /= divider;
                        count++;
                        Array.Resize(ref result, count);
                        result[idx] = divider;
                        idx++;
                    }
                    else
                    {
                        divider++;
                    }
                }
                else
                {
                    divider++;
                }
            }
            return result;
        }
        public static int largestPrimeFactor(int n)
        {
            if (n <= 1) return 0;
            int max = 0, divider = 2;
            while (n != 1)
            {
                if(n % divider == 0)//unless it can divide, it's not factor
                {//keep dividing the result so that it can get same factor 2*2*2*3*3
                    n /= divider;
                    if(isPrime(divider) == 1)
                    {
                        if (divider > max) max = divider;
                    }
                }
                else
                {
                    divider++;
                }
            }
            return max;
        }
        public static int isSequencedArray(int[] a, int m, int n)
        {
            if (m > n) return 0;
            if (a[0] != m || a[a.Length - 1] != n) return 0;
            int isSeq = 0;
            for(int i= 1; i < a.Length - 1; i++)
            {
                if (a[i - 1] <= a[i] && a[i] <= a[i + 1])
                {
                    if(a[i] > a[i - 1])//check if only 1 greater
                    {
                        if (a[i] == a[i - 1] + 1) isSeq = 1;
                        else return 0;//missing next greater num
                    }

                    if(a[i] < a[i+1])//check if only 1 lesser
                    {
                        if (a[i] == a[i + 1] - 1) isSeq = 1;
                        else return 0;//missing num
                    }
                }
                else return 0;
            }
            return isSeq;
        }

        /// <summary>
        /// **each of its digits** is concatenated twice and then summed
        /// Note * its own digit only. e.g. 198 = 1 & 9 & 8 - 3 digits only 
        /// n is the number and catlen is the number of times to concatenate each digit before summing.
        /// </summary>
        //           | digit * i   | catlen <= 2
        //---------------------------------
        //num = 198  | 8 * 1 = 8   |  1
        //digit = 8  | 8 * 10 = 80 |  2   => 88
        //---------------------------------
        //num = 19   | 9 * 1 = 9   |  1
        //digit = 9  | 9 * 10 = 90 |  2   => 99
        //---------------------------------
        //num = 0    | 1 * 1 = 1   |  1
        //digit = 1  | 1 * 10 = 10 |  2   => 11

        public static int checkConcatenatedSum(int n, int catlen)
        {
            int num = n, sum = 0;
            
            while (num > 0)
            {
                int digit = num % 10;
                num /= 10;
                for (int j = 1, i = 1; j <= catlen;j++ )
                {
                    sum += digit * i;// 1st => 8 * 1 = 8, 2nd => 8 * 10 = 80
                    i *= 10;
                }
            }
            if (n == sum) return 1;
            return 0;
        }
        public static int largestAdjacentSum(int[] a)
        {
            int largest = 0;
            for(int i=0; i<a.Length-1; i++)
            {
                if(a[i] + a[i + 1]> largest)
                {
                    largest = a[i] + a[i + 1];
                }                
            }
            return largest;
        }
        /// <summary>
        ///change n to binary representation(base 2),
        ///see in fullnessQuotient function,
        ///extract exponent values from binary result 
        ///e.g. 88 = 1011000 = (1 * 2^6) + (0* 2^5) + (1* 2^4) + (1* 2^3) + (0 * 2^2) + (0 * 2^1) + (0 * 2^0)
        ///= 2^6 + 2^4 + 2^3
        ///get the exponent number 6,4,3
        ///extract value from a array, use exponent no. as array indexes
        /// </summary>        
        ///int?[] - all the return array must do null int - as there is a condition to return null
        public static int?[] filterArray(int[] a, int n)
        {
            if (n < 1) return new int?[0];
            int base10 = n, b2Idx = 0, b2Len = 0, rIdx = 0, count1 = 0;
            int[] b2Arr = new int[0];
            //calculate base 2 representation of n
            base10 = n;
            do
            {
                b2Len++;
                Array.Resize(ref b2Arr, b2Len);
                b2Arr[b2Idx] = base10 % 2;
                if(b2Arr[b2Idx] == 1) count1++;
                base10 /= 2;
                b2Idx++;                
            }
            while (base10 > 0); //got base 2 result
            //{0,0,0,1,1,0,1} - result arr in reverse order
            //but it become exponent value is same as array index
            
            //int? must do as there is condition to return null
            int?[] result = new int?[count1];

            for(int i =0; i< b2Arr.Length; i++)
            {
                if(b2Arr[i] == 1)
                {
                    if (i > a.Length - 1) return null;                    
                    result[rIdx] = a[i];
                    rIdx++;
                }
            }

            return result;
        }
           
        //elements are either 1 or 2 and it begins with one or more 1s followed by a one or more 2s
        //and then ends with the same number of 1s that it begins with
        public static int is121Array(int[] a)
        {
            if (a == null || a.Length < 1) return 0;
            if (a[0] != 1 || a[a.Length - 1] != 1) return 0;
            if (Array.IndexOf(a, 1) == -1 || Array.IndexOf(a, 2) == -1) return 0;
            int is121 = 0;
            int lowerIndex = 0, upperIndex = a.Length - 1, lowerChkVal = a[0], upperChkVal = a[a.Length -1];
            while (lowerIndex <= upperIndex)
            {
                if(a[lowerIndex] == lowerChkVal && a[upperIndex] == upperChkVal)
                {
                    if (a[lowerIndex] == a[upperIndex])
                    {
                        is121 = 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else//track value change
                {
                    if(lowerIndex == upperIndex)//{1,2,1}
                    {
                        //if change from 1 to 2 is ok
                        if (lowerChkVal == 1 && upperChkVal == 1) is121 = 1;
                        else return 0; //if change from 2 to 1 at lower & upper same position - 0
                    }
                    //if value different in lower & upper indexes mirrorring places - 0
                    else if (a[lowerIndex] != a[upperIndex] && lowerIndex == a.Length - 1 - upperIndex) return 0;

                    lowerChkVal = a[lowerIndex];
                    upperChkVal = a[upperIndex];
                }
                
                lowerIndex++;
                upperIndex--;
            }
            
        return is121;
        }
        //return largest exponent, px evenly divides n
        //getExponent(162, 3) returns 4 because 162 = 2 power 1 * 3 power 4,
        //therefore the value of x here is 4. bcos 3 power 4 equally divide 162, 3 power 5 cannot.
        public static int getExponent(int n, int p)
        {
            if (p <= 1) return -1;
            int result = 1, count = 0;
            while (result < Math.Abs(n))
            {
                result *= p;
                if (Math.Abs(n) % result ==0 && result <= Math.Abs(n)) count++;
                
            }
            return count;
        }
        public static int isOddHeavy(int[] a)
        {
            if (a == null || a.Length < 1) return 0;
            int isOddHvy = 0;
            for(int i = 0; i<a.Length; i++)
            {
                if (a[i] % 2 != 0)//odd
                {
                    isOddHvy = 1;//{1} , {1,1,1,1} odd only array
                    for (int j=0; j<a.Length; j++)
                    {
                        if(a[j]%2 == 0)
                        {
                            if (a[i] < a[j]) return 0;
                            else isOddHvy = 1;
                        }
                    }
                }
            }
            return isOddHvy;
        }
        //{2, 2, 3, 3, 3}
        //2 must occur 2 times consecutive, so does 3
        public static int isPacked(int[] a)
        {
            if (a.Length < 1) return 1;
            int chkVal = a[0], boundCount = 0;

            int idx = 0, hLen = 1, hIdx = 0;
            int[] historyArr = new int[hLen];
            historyArr[hIdx] = a[0];
            while (idx < a.Length)
            {
                if (a[idx] < 0) return 0;
                if (a[idx] == chkVal)
                {
                    boundCount++;
                    if (boundCount > chkVal) return 0;
                    
                }
                else
                {
                    //chk if prev elm has same bound count as its value
                    if (chkVal != boundCount) return 0;// not meet to occur same times as its value
                    //chk changed elm has history 
                    if (Array.IndexOf(historyArr, a[idx]) == -1)//not in history
                    {
                        chkVal = a[idx];
                        boundCount = 1;

                        //keep as record
                        hLen++;
                        hIdx++;
                        Array.Resize(ref historyArr, hLen);
                        historyArr[hIdx] = a[idx];

                    }
                    else return 0;
                }
                idx++;
            }
            return 1;
        }
        //n = 9 to base 2
        //Base 2  | Quotient | Remainder
        //=================================
        // 9/2    |   4      | 1
        // 4/2    |   2      | 0
        // 2/2    |   1      | 0
        // 1/2    |   0      | 1  ^ take upward (1001)
        // *divide till the quotient 0
        // 9 base 2 = 1001 = (2^3 * 1) + (2^2 * 0) + (2^1 * 0) + (2^0 * 1) = 6+2 = 8 base 10
        //
        public static int fullnessQuotient(int n)
        {
            if (n < 1) return -1;
            int base10 = n, count = 0;
            string result = string.Empty;            
            //calculate base 2 to 9 values of n
            for(int i=2; i<10; i++)
            {
                base10 = n;
                do
                {
                    result = "0123456789ABCDEF"[base10 % i] + result;                    
                    base10 /= i;
                }
                while (base10 > 0); //got 1 base result

                if (result.Contains("0") == false) count++;               
                result = string.Empty;
                
            }   
            return count;
        }
        public static int isRailroadTie(int [] a)
        {
            int isTie = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    if(i > 0)
                    {//Every non-zero element has exactly one non-zero neighbor                   
                        if ((i == a.Length - 1 && a[i - 1] != 0) || (a[i - 1] == 0 && a[i + 1] != 0) || (a[i - 1] != 0 && a[i + 1] == 0) )
                        {
                            isTie = 1;
                        }
                        else
                        {
                            isTie = 0;
                            break;
                        }
                    }                    
                }
                else if (a[i] == 0)
                {
                    if (i == 0 || i == a.Length - 1) { isTie = 0; break; }//a[0], a[end] - must have two non-zero neighbors
                    else
                    {
                        if (a[i - 1] != 0 && a[i + 1] != 0) 
                        { 
                            isTie = 1; 
                        }
                        else { 
                            isTie = 0; 
                            break; 
                        }
                    }
                }
            }
            return isTie;
        }
        public static int[] clusterCompression(int[] a)
        {
            int numCluster = 0;
            int[] result = new int[numCluster];
            for(int i = 0; i<a.Length; i++)
            {
                for(int j=i+1; j<=a.Length -1; j++)
                {
                    if (a[i] != a[j])                    
                    {                        
                        numCluster++;
                        Array.Resize(ref result, numCluster);
                        result[numCluster - 1] = a[i];
                        
                        i = j -1;
                        break;
                    }
                }
                if (i == a.Length - 1)//last item is seperate cluster
                {
                    numCluster++;
                    Array.Resize(ref result, numCluster);
                    result[numCluster - 1] = a[i];
                }
            }
            return result;
        }
        public static int smallest(int n)
        {
            int num = 623 , factor = 1, mul, itemLen, found2Count = 0;
            while (found2Count< n)
            {
                
                mul = 0;
                mul = num * factor;

                itemLen = mul.ToString().Length;
                if (mul < 0) itemLen -= itemLen - 1;
                
                for(int i=0; i<itemLen; i++)//for one factor result
                {
                    if (mul % 10 == 2) 
                    {
                        found2Count++;
                        factor++;
                        break;
                    }
                    else
                    {
                        if(i == itemLen - 1 && found2Count > 0) { found2Count = 0; break; }//if no consecutive 2 digit found
                        else mul = mul / 10;
                    }
                    
                }
                if(found2Count == 0) { num++; factor = 1; } //no 2 found, increase num, reset factor                
            }
            return num;
        }
        public static int isMinMaxDisjoint(int[] a)
        {
            if (a.Length < 3) return 0; //not adjacent, not 1 elm
            int maxPos = 0, minPos = 0;
            int max = a[0], min = a[0];
            for(int i =0; i<a.Length; i++)
            {
                if(a[i] >= max )
                {
                    if (i != 0 && a[i] == max) return 0;//to occur once only
                    else max = a[i]; maxPos = i;
                }
                else
                {
                    if (i != 0 && a[i] == min) return 0;
                    else
                    {
                        if (a[i] < min)
                        {
                            min = a[i];
                            minPos = i;
                        }
                    }
                }
            }
            if (max != min && maxPos != minPos && maxPos != minPos + 1 && maxPos != minPos-1) return 1;
            return 0;
        }
        public static int isSequentiallyBounded(int[] a)
        {
            if (a.Length < 1) return 1;
            bool isSorted = false;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i - 1] > a[i]) { isSorted = false; break; } 
                else { isSorted = true; }
            }                      
            if (!isSorted) return 0;

            //chk
            int chkVal = a[0], boundCount = 0;
            for(int t= 0; t<a.Length; t++)
            {
                if (a[t] < 0) return 0;
                //count first
                if(a[t] == chkVal)
                {
                    boundCount++;
                    if (boundCount >= chkVal)//for 1st item '1', 1 must show less than 1 times
                    {
                        return 0;
                    }                    
                }
                else
                {
                    chkVal = a[t];
                    boundCount = 1;
                }
            }

            return 1;
        }
        //1,2,5,10,20
        public static int countRepresentations(int numRupees)
        {
            int count = 0;
            for (int rupee20 = 0; rupee20 <= (numRupees) / 20; rupee20++)
            {
                for (int rupee10 = 0; rupee10 <= (numRupees - (rupee20 * 20)) / 10; rupee10++)
                {
                    for (int rupee5 = 0; rupee5 <= (numRupees - (rupee10 * 10 + rupee20 * 20)) / 5; rupee5++)
                    {
                        for (int rupee2 = 0; rupee2 <= (numRupees - (rupee5 * 5 + rupee10 * 10 + rupee20 * 20)) / 2; rupee2++)
                        {
                            for (int rupee1 = 0; rupee1 <= numRupees - (rupee2 * 2 + rupee5 * 5 + rupee10 * 10 + rupee20 * 20); rupee1++)
                            {
                                if ((rupee1 + rupee2 * 2 + rupee5 * 5 + rupee10 * 10 + rupee20 * 20) == numRupees)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            return count;
        }
        public static int isTrivalent(int[] a)
        {
            if (a.Length < 1) return 0;
            int?[] threeVal = new int?[3];//null array
            int idx = 0, isTrivalent = 0;
            for(int i = 0; i< a.Length; i++)
            {
                if(i == 0)
                {
                    threeVal[idx] = a[i];
                    idx++;
                }else
                {
                    if(Array.IndexOf(threeVal, a[i]) == -1)//not same element exists in array
                    {
                        if(idx < 3)
                        {
                            threeVal[idx] = a[i];
                            idx++;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        isTrivalent = 1;
                    }
                }
                
            }
            if (idx < 3) isTrivalent = 0;
            return isTrivalent;
        }
        public static int isVanilla(int[] a)
        {
            if (a.Length < 1) return 1;
            int trackNum = 0, lastDigit = 0, aItem, itemLen, isVan = 0;
            for(int i=0; i<a.Length; i++)
            {
                itemLen = a[i].ToString().Length;
                if (a[i] < 0) itemLen -= itemLen - 1;

                aItem = Math.Abs(a[i]);

                for (int j=0; j< itemLen; j++)
                {
                    if(i == 0 && j == 0)
                    {
                        trackNum = aItem % 10;
                        isVan = 1;//for array has only one element
                    }
                    else
                    {
                        lastDigit = aItem % 10;
                        if(lastDigit == trackNum)
                        {
                            isVan = 1;
                        }
                        else
                        {
                            isVan = 0;
                            return isVan;
                        }
                    }
                    aItem = aItem / 10;
                }
            }
            return isVan;
        }
        public static int isIsolated(long n)
        {
            if (n > 2097151 || n < 1) return -1;
            long square, cube;
            int sqLen, cuLen, isIsolated = 0; //0,1,-1
            
            square = n * n;
            cube = n * n * n;

            sqLen = square.ToString().Length;
            cuLen = cube.ToString().Length;
            int [] sqArr = new int[sqLen];

            for (int i = 0; i < sqLen; i++)
            {           
                sqArr[i] = Convert.ToInt32(square % 10);
                square = square / 10;
            }
             
            for (int j = 0; j< cuLen; j++)
            {
                if(Array.IndexOf(sqArr,Convert.ToInt32(cube % 10)) == -1)
                {
                    isIsolated = 1;
                }
                else
                {
                    isIsolated = 0;
                    break;
                }
                cube = cube / 10;
            }
            return isIsolated;
            
        }
        public static int isSumSafe(int [] a)
        {
            if (a.Length < 1) return 0;
            int sum = 0, isSafe = 0;
            for(int i =0; i<a.Length; i++)
            {
                sum += a[i];
            }
            if(Array.IndexOf(a, sum) == -1)
            {
                isSafe = 1;
            }
            else
            {
                isSafe = 0;
            }
            return isSafe;
        }
        public static int isStacked(int n)
        {
            int stackSum = 0;
            for(int i = 1; i<= n; i++)
            {
                if(stackSum > n)
                {
                    return 0;
                }
                if(stackSum == n)
                {
                    return 1;
                }
                stackSum += i;
            }
            return 0;
        }
        public static int matches_while(int[] a, int[] p)
        {
            int pSum = 0, isMatch = 0, aIdx = 0;
            for (int i = 0; i < p.Length; i++)
            {
                while (aIdx < Math.Abs(p[i]))
                {
                    if (p[i] > 0)
                    {
                        if (a[aIdx] < 0) return 0;
                        else isMatch = 1;
                    }
                    else if (p[i] < 0)
                    {
                        if (a[aIdx] > 0) return 0;
                        else isMatch = 1;
                    }
                    aIdx++;
                }
                if (p[i] < 0)
                {
                    p[i] = Math.Abs(p[i]);
                }
                pSum += p[i];
            }
            if (pSum == a.Length) isMatch = 1;
            else isMatch = 0;
            return isMatch;
        }
        //A = { 1,2,3,-5,-5,2,3,18 }, P = {3, -2,3 });        
        public static int matches(int[] a, int[] p)
        {
            //P is the legal pattern, the absolute value of its elements sum to the length of A
            //and contains no zeros.
            int pSum = 0, isMatch = 0, aIndex = 0;
            for(int i=0; i<p.Length; i++)
            {                    
                for(int j= 0; j< Math.Abs(p[i]); j++)
                {
                    if (p[i] > 0)
                    {
                        if (a[aIndex] < 0) return 0;
                        else isMatch = 1;
                    }
                    else if (p[i] < 0)
                    {
                        if (a[aIndex] > 0) return 0;
                        else isMatch = 1;
                    }
                    aIndex++;
                    //to keep track of how many elm in a been checked as j started from 0 again
                }
                
                if (p[i] < 0)
                {
                    p[i] = Math.Abs(p[i]);
                }
                pSum += p[i];
            }

            if (pSum == a.Length) isMatch = 1;
            else isMatch = 0;
            return isMatch;
        }
        public static int computeDepth(int n)
        {
            int factor = 1, mX = 0, lastDigit = 0, mxLen = 0;
            int?[] digitArray = new int?[10];
            int index = 0;
                        
            while (true)
            {
                mX = n* factor;
                mxLen = mX.ToString().Length;
                for (int i = 1; i <= mxLen; i++)
                {
                    lastDigit = mX % 10;
                    mX = mX / 10;
                    //check elm already in array 
                    if(Array.IndexOf(digitArray, lastDigit) == -1)//digit not in array
                    {
                        digitArray[index] = lastDigit;
                        if(index == 9)//array full
                        {
                            return factor;
                        }                        
                        index++;
                        
                    }
                    else//already in array
                    {
                        if(index == 10)
                        {
                            return factor;                            
                        }
                    }
                        
                }
                factor++;
            }
        }
        public static int arrayHasNoZeroes(int[] a)
        {
            if (Array.IndexOf(a, 0) != -1)
            {
                return 0;
            }               
            return 1;
        }
        public static int convertToBase10(int[] a, int n)
        {
            if(isLegalNumber(a,n)!= 1) { return 0; }
            int sum = 0;
            //[3][2][1][0]
            for(int i=a.Length-1; i>=0; i--)
            {
                //a[3] => do nothing // j= 0 ; j< 0
                //a[2] => a[2] * n // j= 0 ; j< 1
                //a[3] => a[3] * n * n // j=0; j< 2
                for(int j=0; j<(a.Length -1)-i; j++)
                {
                    a[i] *= n;
                }
                sum += a[i];
            }
            return sum;
        }
        public static int isLegalNumber(int[] a,int n)
        {
            for(int i=0; i<a.Length; i++)
            {
               if(a[i] > n)
                {
                    return 0;
                }
            }
            return 1;
        }
        public static int isSquare(int n)
        {
            for(int i=0; i<=n; i++)
            {
                if(i*i == n)
                {
                    return 1;
                }

            }
            return 0;
        }
        public static int isNUnique(int[] a, int n)
        {
            if (a == null || a.Length < 2) return 0;
            int isUnique = 0;
            for(int i=0; i < a.Length-1; i++)
            {
                for(int j=i+1; j<a.Length; j++)
                {
                    if(a[i]+a[j] == n)
                    {
                        if(isUnique < 1)
                        {
                            isUnique++;
                        }
                        else
                        {
                            return 0;
                        }
                        
                    }
                }
            }
            return isUnique;
        }
        public static int isDivisible(int[]a, int divisor)
        {
            int isDivisible = 1;
            for( int i=0; i<a.Length; i++)
            {
                if(a[i]%divisor == 0)
                {
                    isDivisible = 1;
                }
                else
                {
                    isDivisible = 0;
                    break;
                }
            }
            return isDivisible;
        }
        public static int henry(int i, int j)
        {
            int pfnumIndex = 0, num = 6, sum = 0, sumCount = 0;
            if (i == 0 && j == 0) return 0;
            if(i == 0 || j==0)
            {
                sumCount++;
            }
            while (sumCount <2)
            {
                //find perfect number first
                int factors = 0;                
                for (int k = 2; k <= num; k++)
                {
                    if (num % k == 0)
                    {
                        factors += num / k;
                    }
                }
                if (factors == num)//chk pfnumber found is in ith or jth place
                {
                    pfnumIndex++;                 
                    if(pfnumIndex == i || pfnumIndex == j)
                    {
                        sum += num;
                        sumCount++;
                    }
                }
                num++;
            }
            return sum;
        }
        public static int isCentered15(int[] a)
        {
            int isCentered15 = 0;
            int lowerIndex = 0;
            int upperIndex = 0;
            int sum = 0;
            //[0],[1],[2],[3],[4],[5]
            //{a,b,c,d,e,f}
            //lowerIndex = (6/2) - 1 = 2 <- 2 is the index number which is a[2]=c 
            //NOT start counting from 1, 2, 3 ... of array elements.
            if(a.Length % 2 == 0)
            {
                lowerIndex = (a.Length / 2) - 1;
                upperIndex = a.Length / 2;
            }
            //since array start from 0, odd Length can get exact middle index by dividing (length -1)/2
            //{0,1,2,3,4,5,6,7}
            else
            {
                lowerIndex = (a.Length - 1) / 2;
                upperIndex = lowerIndex;
            }
            while (lowerIndex >=0 && upperIndex < a.Length)
            {
                sum = 0;
                //{3,2,10,4,1,6,9}
                //this 'for' always maintain center
                //for odd array - taking 1/3/5..elements to be centered sum
                //i=2; i<=4 means a[2]a[3]a[4] cover within for loop (betn: lowerIndex and upperIndex)
                //for even array - taking 2/4/6 ... elements to be centered sum
                //so no need to check how many left elem and right elem for sum result
                for (int i = lowerIndex; i <= upperIndex; i++){
                    sum += a[i];
                }
                if(sum == 15)
                {
                    isCentered15 = 1;
                    break;
                }
                lowerIndex--;
                upperIndex++;
            }
            return isCentered15;
        }
        public static int isCentered15_MyWork(int[] a)
        {
            int sum = 0;
            for (int i = 0; i<a.Length; i++)
            {
                sum = a[i];
                int rightElm = i - 0;
                int leftElm = a.Length - 1 - i;
                for (int j = i+1; j<a.Length; j++)
                {
                    if(sum < 15)
                    {
                        sum += a[j];
                    }
                    if (sum > 15)
                    {
                        break;
                    }
                    if (sum == 15)
                    {
                        if (a[i] != 15)
                        {
                            leftElm = a.Length - 1 - j;
                        }
                        if(rightElm == leftElm)
                        {
                            return 1;
                        }
                        else if(rightElm > leftElm)
                        {
                            return 0;
                        }
                        else if (rightElm < leftElm)
                        {
                            break;
                        }
                    }
                    
                }
            }
            return 0;
        }
        public static int repsEqual(int[]a, int n)
        {
            int repsEqual = 0;
            //start with last elm in array & last digit of n
            for (int lastIndex = a.Length - 1; lastIndex >= 0; lastIndex--)
            {
                int lastDigit = n % 10;
                n = n / 10;
                if (lastDigit == a[lastIndex])
                {
                    repsEqual = 1;
                }
                else
                {
                    repsEqual = 0;
                    break;//once diff, no more loop
                }
            }
            return repsEqual;
        }
        public static int repsEqual_MyWork(int[]a, int n)
        {
            List<int> listOfInts = new List<int>();
            while (n > 0)
            {
                listOfInts.Add(n % 10);
                n = n / 10;
            }
            listOfInts.Reverse();
            int[] nArray = new int[listOfInts.Count];
            nArray = listOfInts.ToArray();
            int pointerN = 0, startFlag = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (pointerN == nArray.Length && i < a.Length) return 0;//extra elm in array a
                if (pointerN < nArray.Length)
                {
                    if (startFlag == 0 && a[i] == nArray[pointerN])
                    {
                        startFlag = 1;
                        pointerN++;
                    }
                    else if(startFlag == 0 && a[i] > 0)//extra elm in leading place (not 0 leading)
                    {
                        return 0;
                    }
                    else if (startFlag == 1 && a[i] != nArray[pointerN])//subsequent elm is different
                    {
                        return 0;
                    }
                    else if (startFlag == 1 && a[i] == nArray[pointerN])
                    {
                        if (pointerN == nArray.Length - 1 && i == a.Length -1)//last index
                        {
                            return 1;
                        }
                        else
                        {
                            pointerN++;
                        }
                        
                    }
                }                
            }
             return 0;
        }           
        public static int[] solve10()
        {
            int[] xyArr = new int[2];
            //find 10 factorial
            int fact10 = 10;
            for (int i = 1; i< 10; i++)
            {
                fact10 = fact10 * i;
            }
            //x=1 -> y=1, y=2, y=3, ...
            int factX = 1; 
            for (int j = 0; j<10; j++)
            {
                factX = factX * j;
                int factY = 1;
                for (int k = 1; k<= 10; k++)
                {
                    
                    factY = factY * k;

                    if (fact10 == factX + factY)
                    {
                        xyArr[0] = j;
                        xyArr[1] = k;
                        return xyArr;
                    }
                }
            }
            return xyArr;
        }
        public static int guthrieIndex(int n)
        {
            if (n == 1) return 0;
            int i = 1;
            while(true)
            {
                
                if (n % 2 == 0)//even
                {
                    n = n / 2;
                    if (n == 1) return i;
                    i++;
                }
                else//odd
                {
                    n = (n * 3) + 1;
                    if (n == 1) return i;
                    i++;
                }
            }
        }
        public static int sumFactor(int[] a)
        {
            if (a.Length == 0) return 0;
            int sum = 0, sumFactor = 0;
            for(int i= 0; i<a.Length; i++)
            {
                sum += a[i];
            }
            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] == sum) sumFactor++;
            }
            return sumFactor;
        }
        //Step 1. Count the number of 1s in the array. Let this count be n.
        //Step 2. The Stanton measure is the number of times that n appears in the array.
        //{1, 4, 3, 2, 1, 2, 3, 2}
        //Step 1. Count the number of 1s => 2 <= n
        //Step 2. number of times that n appears => find how many 2 in the array =>ans: 3

        //{1}
        //Step 1. Count the number of 1s => 1 <= n
        //Step 2. number of times that n appears => find how many 1 in the array? =>ans: 1

        //{0}
        //Step 1. Count the number of 1s => 0 <= n
        //Step 2. number of times that n appears => find how many 0 in the array? =>ans: 1

        //{3, 1, 1, 4}
        //Step 1. Count the number of 1s => 2 <= n
        //Step 2. number of times that n appears => find how many 2 in the array? =>ans: 0
        public static int statonMeasure(int[] a)
        { 
            int count1s = 0, statonMsr = 0;
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] == 1) count1s++;
            }
            for(int j=0; j<a.Length; j++)
            {
                if (a[j] == count1s) statonMsr++;
            }
            return statonMsr;
        }
        public static int isGuthrieSequence(int[] a)
        {
            if (a == null || a[0] < 1) return 0;
            for (int i=0; i< a.Length; i++)
            {
                if(i == a.Length - 1)
                {
                    if (a[i] == 1) { return 1; } else { return 0; }
                }
                if (a[i] % 2 == 0)//even
                {
                    if(a[i+1] != a[i] / 2)
                    { 
                        return 0;
                    }
                }
                else//odd
                {
                    if (a[i + 1] != (a[i] *3) + 1)
                    {
                        return 0;
                    }
                }
            }

            return 1;
        }
        public static int findPorcupineNumber(int n)
        {
            //find next prime
            int firstPrime;
            while (true)
            {
                n++;
                if (isPrime(n) == 1)
                {                    
                    if (n % 10 == 9)//chk last digit
                    {
                        firstPrime = n;
                        while (true)//chk next prime follow is end with 9
                        {
                            n++;
                            if(isPrime(n) == 1)
                            {
                                if (n % 10 == 9)
                                {
                                    return firstPrime;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                
            }
        }
        /// <summary>
        /// Check the number is prime or not,
        /// accepts positive integer argument
        /// </summary>
        /// <param name="n">accepts positive integer argument</param>
        /// <returns>1 or 0</returns>
        public static int isPrime(int n)
        {
            if (n < 2) return 0;          
            for (int j = 2; j <= n; j++)//divide with 2,3,4,5,..till its own number reach
            {
                if (n == j)  return 1;                
                if (n % j == 0) break;//can divide means no prime
            }
            return 0;
        }
        public static int countSquarePairs(int[] a)
        {
            if (a.Length < 2) return 0;
            int count = 0;
            for (int i =0; i < a.Length -1; i++)
            {
                for(int j=i+1; j <a.Length; j++)
                {
                    if(a[i] >0 && a[j] > 0) { 
                        if(isPerfectSquare( a[i] + a[j]) == 1)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
        public static int isPerfectSquare(int n)
        {
            int root = (int)Math.Floor(Math.Sqrt(n));
            if ((int)Math.Pow(root, 2) == n) return 1;
            else return 0;
        }
        public static int isIntertial(int[] a)
        {
            if (a == null || a.Length < 2) return 0;
            bool hasOdd = false, maxEven = false; int maxVal = a[0];
            int[] oddArr = new int[a.Length];
            int[] evenArr = new int[a.Length];
            int j = 0, k = 0;
            for (int i = 0; i<a.Length; i++)
            {
                if (a[i] % 2 != 0) { 
                    hasOdd = true;
                    oddArr[j] = a[i];
                    j++;
                }
                else
                {
                    evenArr[k] = a[i];
                    k++;
                }
                
                if (a[i] > maxVal) maxVal = a[i];
                
            }

            if (maxVal % 2 == 0) maxEven = true;
            int[] optOddArr = new int[j];
            int[] optEvenArr = new int[k];
            for (int t = 0; t < j; t++)
            {
                optOddArr[t] = oddArr[t];
            }
            for (int v = 0; v < k; v++)
            {
                optEvenArr[v] = evenArr[v];
            }
            // every odd value > every even except maxVal
            for (int q = 0; q <optOddArr.Length; q++)
            {
                for (int r= 0; r<optEvenArr.Length; r++)
                {                    
                    if (optOddArr[q] < optEvenArr[r] && optEvenArr[r] != maxVal) return 0;
                }
            }

            if (hasOdd && maxEven) { return 1; } else { return 0; }
        }
        public static int isMadhavArray(int[] a)
        {
            if (a == null || a.Length < 3)
                return 0;
            bool lenChk = false;
            int pairCount = 0;
            for(int i = 2; i <= a.Length; i++)
            {
                if (a.Length == i * (i + 1) / 2)
                {
                    lenChk = true;
                    pairCount = i;//a[0] = a[1] + a[2] = a[3] + a[4] + a[5]
                    break;
                }
            }
            if (!lenChk) return 0;
            //a[0] => i = 1
            //a[1]+a[2] => i=2
            //a[3]+a[4]+a[5] =>i=3
            int  pointer = 1, FirstSum = a[0], SecondSum = 0;
            for (int i = 2; i <= pairCount; i++)
            {
                if (pointer == a.Length) break;
                
                for (int j=1; j<=i; j++)
                {    
                    SecondSum += a[pointer];
                    pointer++;
                    
                    if(j==i)
                    {    
                        if (FirstSum != SecondSum) return 0;
                        SecondSum = 0;
                    }
                }
            }
            return 1;

        }
        public static int isMadhavArray_Hubby(int[] a)
        {
            // prerequisite check.
            if (a == null || a.Length == 0 || a.Length < 3)
                return 0;

            bool isMad = false;
            int idx = 0; // to know maximum array pairs. 
                         // E.g. [0] = [1]+[2] is 2 array pairs.
                         // [0] = [1]+[2] = [3]+[4]+[5] is 3 array pairs.
                         // [0] = [1]+[2] = [3]+[4]+[5] = [6]+[7]+[8]+[9] is 4 array pairs.

            // check Madhav Array with n*(n+1)/2
            for (int i = 2; i <= a.Length; i++)
            {
                if (a.Length == i * (i + 1) / 2)
                {
                    isMad = true;
                    idx = i; // record maximum array pair count.
                    i = a.Length + 1; // to exit from for loop checking
                }
            }

            if (isMad == false) // array is not Madhav
                return 0; 

            int firstarraystart = 0; // to record first array start index
            int secondarraystart = 0; // to record second array start index

            // loop array and get sum of pair count to check array is Madhav array
            for (int i = 0; i < idx-1; i++)
            {
                int firstsum = 0;
                int secondsum = 0;

                for (int j = firstarraystart; j < firstarraystart + i + 1; j++)
                {
                    firstsum = firstsum + a[j];
                    secondarraystart = j + 1;
                }

                firstarraystart = secondarraystart;
                for (int j = secondarraystart; j < secondarraystart + (i + 2); j++)
                {
                    secondsum = secondsum + a[j];
                }

                if (firstsum != secondsum)
                    return 0;
            }

            #region reverse checking
            /*
            int firstarraystart = a.Length-1; // to do reverse count
            int secondarraystart =0;
            // loop array pair count to check Madhav proporty
            for (int i= idx; i>1; i--)
            {
                int firstsum =0;
                int secondsum =0;
                
                for(int j= firstarraystart; j > firstarraystart - i; j--)
                {
                    firstsum = firstsum + a[j];
                    secondarraystart = j-1;
                }
                firstarraystart = secondarraystart;
                for (int j = secondarraystart; j > secondarraystart -(i-1); j--)
                {
                    secondsum = secondsum + a[j];
                }

                if (firstsum != secondsum)
                    return 0;
            }
            */
            #endregion

            // all negative checking is passed. Therefore, this is a Madhav array
            return 1;

        }

        public static int primeCount(int start, int end)
        {
            int count = 0;
            for (int i = start; i < end+1; i++)
            {
                for (int j = 2; j <= i; j++)//divide with 2,3,4,5,..till its own number reach
                {
                    if(i > 1)
                    {
                        if (i == j)
                        {
                            count++;
                        }
                        if (i % j == 0)//can divide means no prime
                        {
                            break;
                        }                        
                    }                    
                }  
            }
            return count;
        }
        public static int NUpCount_Smart(int[] a, int n)
        {
            int nUpCount = 0;
            int partialSum = 0;
            int previousPartialSum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                previousPartialSum = partialSum;
                partialSum += a[i];
                if (previousPartialSum <= n && partialSum > n)
                {
                    nUpCount++;
                }
            }
            return nUpCount;
        }
        public static int NUpCount(int[] a, int n)
        {
            int sum = a[0], upCount = 0, partialSum = 0;
            for (int i = 0; i<a.Length; i++)
            {
                if(upCount >= 1)
                {
                    if (a[i] < 0 || partialSum < n)
                    {
                        partialSum += a[i];
                        if (partialSum > n)
                        {
                            upCount++;
                        }
                    }
                }
                else
                {
                    partialSum += a[i];
                    if (partialSum > n)
                    {
                        upCount++;
                    }
                }                               
                
                
            }
            return upCount;
        }
        public static int NextPerfectSquare(int n)
        {
            if (n >= 0)
            {
                int nextN = (int)Math.Floor(Math.Sqrt(n)) + 1;
                //int result =  nextN * nextN;
                return (int)Math.Pow(nextN, 2);
            }
            else
            {
                return 0;
            }
        }

    }
}
