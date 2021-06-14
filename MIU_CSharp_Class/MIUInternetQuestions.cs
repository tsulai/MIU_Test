using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIU_CSharp_Class
{
    public  class MIUInternetQuestions
    {

        //a. If it contains a 9 then it also contains a 13.
        //b.If it contains a 7 then it does not contain a 16.
        public static int isBean(int[] a)
        {
           if(Array.IndexOf(a,9) != -1)
            {
                if (Array.IndexOf(a, 13) == -1) return 0;
            }
           if(Array.IndexOf(a, 7) != -1)
            {
                if (Array.IndexOf(a, 16) != -1) return 0;
            }
            return 1;
        }
        //which does not contain two even numbers or two odd numbers in adjacent locations
        //{2, 6, 3, 4} is not a wave array
        public static int isWave(int[] a)
        {
            if (a.Length < 2) return 1;
            int isWaveArr = 0;
            for(int i=0; i<a.Length-1; i++)
            {
                if(a[i] % 2 == 0)
                {
                    if (a[i + 1] % 2 == 0) return 0;//even again
                    else isWaveArr = 1;
                }else
                {
                    if (a[i + 1] % 2 != 0) return 0;
                    else isWaveArr = 1;
                }
            }
            return isWaveArr;
        }
        //returns the smallest distance between two factors of a number
        //13013 = 1*7*11*13 return 2 (13 11 = 2)
        public static int minDistance(int n)
        {
            int divider = 1;
            int diff = 0, preVfactor = 0;
            while (divider <= n)
            {
                if (n % divider == 0)
                {
                    if (preVfactor == 0) preVfactor = divider;
                    else
                    {
                        if (diff == 0)
                        {
                            diff = divider - preVfactor;
                            preVfactor = divider;
                        }
                        else if (divider - preVfactor < diff)
                        { 
                            diff = divider - preVfactor;
                            preVfactor = divider;
                        }
                    }
                }
                divider++;
            }
            return diff;
        }
        //It returns an integer array arr2 of length n whose first k elements are the same as the first k elements of arr, and whose remaining elements consist of repeating blocks
        //fill({1,2,3,5, 9, 12,2,1}, 3, 10) returns {1,2,3,1,2,3,1,2,3,1}.
        public static int?[] fill(int[] arr, int k, int n)
        {
            if (k < 1 || n < 1) return null;
            int?[] arr2 = new int?[n] ;
            int idx = 0;
            for (int i = 0; i < n; i++)
            {                
                arr2[i] = arr[idx];
                idx++;
                if (idx == k) idx = 0;            
            }
            return arr2;
        }
        //hasKSmallFactors(7, 30) is true (since 5*6 = 30 and 5 < 7, 6 < 7).
        public static bool hasKSmallFactors(int k, int n)
        {
            if (k < 0 || n < 0) return false;
            int divider = 2;
            while (divider <= n)
            {
                if(n % divider == 0)
                {
                    if (divider < k && n / divider < k) return true;
                }
                divider++;
            }
            return false;
        }
        //An array with an odd number of elements is said to be centered if all elements (except the middle one) are strictly greater than the value of the middle element
        //{5, 3, 3, 4, 5} is not a centered array (the middle element 3 is not strictly less than all other elements)
        public static int isCentered(int[] a)
        {
            if (a.Length < 1) return 0;
            if (a.Length % 2 == 0) return 0;
            
            int isCentered = 0;
            int lowerIndex = 0;
            int upperIndex = 0;
            int centerVal = 0;
            
            lowerIndex = (a.Length - 1) / 2;
            upperIndex = lowerIndex;

            while (lowerIndex >= 0 && upperIndex < a.Length)
            {
                if (lowerIndex == upperIndex)
                {
                    centerVal = a[lowerIndex];
                    isCentered = 1;
                }
                else if (a[lowerIndex] <= centerVal || a[upperIndex] <= centerVal) return 0;
                else isCentered = 1;

                lowerIndex--;
                upperIndex++;
            }
            return isCentered;
            }

        //its even numbered elements (a[0], a[2], etc.) are even and its odd numbered elements(a[1], a[3], etc.) are odd.
        public static int isBalanced2(int[] a)
        {
            for(int i = 0; i<a.Length; i++)
            {
                if(i % 2 == 0)
                {
                    if (a[i] % 2 != 0) return 0;
                }
                else
                {
                    if (a[i] % 2 == 0) return 0;
                }
            }
            return 1;
        }
        //a positive integer that is the product of exactly two primes greater than 1.
        // 22 = 2 * 11, both 2 and 11 are primes
        public static int isPrimeProduct(int n)
        {
            int p1 = 2, p2 = 2, product;
            while(p1 <= n)
            {
                if(isPrime(p1) == 1)
                {
                    p2 = 2;//one p1 increase, p2 need to start from beginning, as it maintain its previous value
                    while (p2 <= n)
                    {
                        if (isPrime(p1) == 1)
                        {
                            product = p1 * p2;
                            if (product == n) return 1;
                        }
                        p2++;  
                    }
                }
                p1++;               
            }
            return 0;
        }
        //a. The array contains even numbers (*** NOT must only even)
        //b.Let min be the smallest even number in the array.
        //c.Let max be the largest even number in the array.
        //d.min does not equal max
        //e. All numbers between min and max are in the array
        public static int isComplete2(int[] a)
        {
            int? min = null, max = null, count = 0;
            int isComp = 0;
            bool hasEven = false;
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] % 2 == 0)//even
                {
                    hasEven = true; 
                    if (max == null)
                    {
                        max = a[i];
                        min = max;
                    } else {
                        if (a[i] > max) max = a[i];
                        if (a[i] < min) min = a[i];
                    }                                     
                }
            }
            if(hasEven && min != max)
            {
                count = max - min;
                for (int j=1; j<count; j++)
                {
                    if (Array.IndexOf(a, min + j) == -1) return 0;
                    else isComp = 1;
                }
            }
            return isComp;            
        }
        //if the sum of the primes in the array is equal to the first element of the array.If there are no primes in the array, the first element must be 0.
        public static int isMagicArray(int[] a)
        {
            int sum = 0;
            bool hasPrime = false;
            for(int i=0; i<a.Length; i++)
            {
                if(isPrime(a[i]) == 1)
                {
                    sum += a[i];
                    hasPrime = true;
                }
            }
            if(hasPrime)
            {
                if (sum == a[0]) return 1;
                else return 0;
            }
            else
            {
                if (a[0] == 0) return 1;
                else return 0;
            }
        }
        //all digit must even
        public static int isEvens(int n)
        {
            int digit;
            while (n != 0)
            {
                digit = n % 10;
                if (digit % 2 != 0) return 0;
                n /= 10;
            }
            return 1;
        }
        //an array where for every value n in the array, n also is in the array
        //{-2,3, 2, -3}is a balanced array.So is {-2,2, 2, 2}.
        public static int isBalanced(int[] a)
        {
            int opposite = 0;
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] > 0) opposite = a[i] * -1;
                else if (a[i] < 0) opposite = Math.Abs(a[i]);
                if(Array.IndexOf(a, opposite) == -1)
                    return 0;
                
            }
            return 1;
        }
        //A Fine array is defined to be an array in which every prime in the array has its twin in the array
        public static int isFineArray(int[] a)
        {
            int twinP = 0;
            for(int i=0; i<a.Length; i++)
            {
                if (isPrime(a[i]) == 1)
                {
                    if (isPrime(a[i] + 2) == 1 || isPrime(a[i] - 2) == 1)
                    {
                        twinP = a[i]+2;
                    }
                }
            }
            if (twinP != 0)
            {
                if (Array.IndexOf(a, twinP) != -1) return 1;
                else return 0;
            }
            else//no prime
                return 1;
            
        }

        //returns 1 if sum of all digits of the first argument is less than the second argument and 0 otherwise
        //isDigitSum(32121,10 ) would return 1
        //because 3+2+1+2+1 = 9 < 10.
        public static int  isDigitSum(int n, int m)
        {
            if (n < 0 || m < 0) return -1;
            int digit, sum = 0;
            while(n != 0)
            {
                digit = n % 10;
                n /= 10;
                sum += digit;
            }
            if (sum < m) return 1;
            else return 0;
        }
        //a. If it contains 9 then it also contains 11.
        //b.If it contains 7 then it does not contain 13.
        public static int isFilter(int[] a)
        {
            if (a.Length < 1) return 0;
            for(int i =0; i<a.Length; i++)
            {
                if (a[i] == 9)
                {
                    if (Array.IndexOf(a, 11) == -1)//if no 11
                        return 0;
                }
                if(a[i] == 7)
                {
                    if (Array.IndexOf(a, 13) != -1)//if has 13
                        return 0;
                }
            }
            return 1;
        }
        //be one that has no odd factors, except for 1 and possibly itself.
        public static int isNormal(int n)
        {
            int divider = 2;
            while (divider < n)
            {
                if (n % divider == 0)
                {
                    if (divider % 2 != 0) return 0;//odd
                }
                divider++;
            }
            return 1;
        }
        //a. It contains a value that occurs more than once
        //b.It contains an odd number
        public static int isOddValent(int[] a)
        {
            int isMore = 0, hasOdd = 0;
            for(int i=0; i<a.Length; i++)
            {
                if(Array.IndexOf(a, a[i]) != i && Array.IndexOf(a, a[i]) != -1)
                {
                    isMore = 1;
                }
                if (a[i] % 2 != 0) hasOdd = 1;
            }
            if (isMore == 1 && hasOdd == 1) return 1;
            else return 0;
        }
        //an array that contains either all odd numbers or all even numbers
        public static int isDaphne(int[] a)
        {
            if (a.Length < 1) return 0;
            bool isEven; int isDph = 0;
            if (a[0] % 2 == 0) isEven = true;
            else isEven = false;
            for (int i=0; i<a.Length; i++)
            {                
               if(isEven)
                {
                    if (a[i] % 2 == 0) isDph = 1;
                    else return 0;
                }
               else
                {
                    if (a[i] % 2 != 0) isDph = 1;
                    else return 0;
                }   
            }
            return isDph;
        }
        //countOnes(5) returns 2 because binary 101 equals 5
        public static int countOnes(int n)
        {
            if (n < 1) return 0;
            int digit, count = 0;
            while(n !=0)
            {
                digit = n % 2;
                n /= 2;
                if (digit == 1) count++;
            }
            return count; 
        }
        //-1 = -1 * -1 * -1
        //1 = 1 * 1 * 1
        //-8 = -2 * -2 * -2
        public static int isCubePerfect(int[] a)
        {
            if (a.Length < 1) return 1;
            int n, cube, isCube = 0;
            for(int i=0; i<a.Length; i++)
            {
                n = 0; cube = 0;
                while(n <= Math.Abs(a[i]))
                {
                    cube = n * n * n;
                    if (cube == a[i])
                    {
                        isCube = 1;
                        break;
                    }
                    n++;
                }
                if (cube == Math.Abs(a[i])) isCube = 1;
                else return 0;
            }           
            return isCube;
        }
        //a[3*n+1] == 0 && the rest must not 0
        //a[3*0+1]= a[1] == 0
        //a[3*1+1] = a[4] ==0
        //a[3*2+1] = a[7] == 0
        //a[3*3+1] = a[10] == 0
        //the rest must 0 a[0], a[2], a[3], a[5] ...
        public static int isZeroLimited(int[] a)
        {
            if (a.Length < 1) return 1;
            int isZLmt = 0; bool isCond1 = false;
            for(int i=0; i<a.Length; i++)
            {
                for(int j = 0; j<a.Length; j++)
                {
                    if (i == 3 * j + 1)
                    {
                        if (a[i] == 0)
                        {
                            isZLmt = 1;
                            isCond1 = true;
                            break;
                        }
                    }
                    else
                    {
                        isCond1 = false;
                    }
                }
                if (!isCond1)
                {
                    if (a[i] == 0) return 0;
                    else isZLmt = 1;
                }
                
            }
            return isZLmt;
        }
        //whose cube contains exactly four 6’s.
        //806 is a BEQ number because 806*806*806 = 523,606,616 which has four 6’s
        public static int findSmallestBEQnumber()
        {
            int n = 2, cube = 0, digit, count6 = 0;
            while (true)
            {
                cube = n * n * n;

                while(cube != 0)
                {
                    digit = cube % 10;
                    cube /= 10;
                    if (digit == 6) count6++;
                }
                if (count6 >= 4) 
                    return n;
                else count6 = 0;
                n++;                
            }
        }
        //its elements sum to 0 and for each positive element n, there exists another element that is the negative of n
        //{3, 4, -2, -3, -2} 0 because even though this sums to 0, there is no element whose value is -4
        public static int isZeroBalanced(int[] a)
        {
            if (a.Length < 1) return 0;
            int sum = 0, opposite = 0;
            for(int i=0; i<a.Length; i++)
            {
                sum += a[i];
                if (a[i] > 0) opposite = a[i] * -1;// if +, need to find - value
                else if (a[i] < 0) opposite = Math.Abs(a[i]);// if - , find + same value
                if (Array.IndexOf(a, opposite) == -1) return 0;
            }
            if (sum == 0) return 1;
            else return 0;
        }
        //5 yes, 5 is prime, 5+2 is prime
        //7 yes, 7 is prime, 7-2 is prime
        public static int isTwinPrime(int n)
        {
            if (n < 2) return 0;
            int isTP = 0;
            if(isPrime(n) == 1)
            {
                if(isPrime(n+2) == 1 || isPrime(n-2) == 1)
                {
                    isTP = 1;
                }else
                {
                    isTP = 0;
                }
            }
            return isTP;
        }
        //24 = 2*3*4 and 3 = 2 + 1
        //there have two factors which are consecutive
        public static int isConsectiveFactored(int n)
        {
            if (n < 1) return 0;
            int divider = 2, factor1 = 0, factor2 = 0;
            while (divider <= n)
            {
                if (n % divider == 0)
                {
                    if (factor1 == 0) factor1 = divider;
                    else
                    {
                        factor2 = divider;
                        if (factor2 == factor1 + 1) return 1;
                        else
                        {
                            factor1 = factor2;
                            factor2 = 0;
                        }
                    }
                }
                divider++;
            }
            return 0;

        }
        //if it contains 3 or more zeros in the middle that are preceded and followed by the same number of non-zero elements
        public static int isHollow(int[] a)
        {
            int isCentered = 0;
            int lowerIndex = 0;
            int upperIndex = 0;
            int count = 0;
            bool aftNonZero = false;
            //[0],[1],[2],[3],[4],[5]
            //{a,b,c,d,e,f}
            //lowerIndex = (6/2) - 1 = 2 <- 2 is the index number which is a[2]=c 
            //NOT start counting from 1, 2, 3 ... of array elements.
            if (a.Length % 2 == 0)
            {
                lowerIndex = (a.Length / 2) - 1;
                upperIndex = a.Length / 2;
            }
            //since array start from 0, odd Length can get exact middle index by dividing (length -1)/2
            //{0,1,2,3,4,5,6,7}
            // start from middle <<= lowerIndex -- && upperIndex ++ =>>
            else
            {
                lowerIndex = (a.Length - 1) / 2;
                upperIndex = lowerIndex;
            }
            while (lowerIndex >= 0 && upperIndex < a.Length)
            {
                if (a[lowerIndex] == 0 && a[upperIndex] == 0)
                {
                    if (aftNonZero) return 0;
                    else
                    {
                        if (lowerIndex == upperIndex) count++;
                        else count += 2;
                        isCentered = 1;
                    }
                    
                }
                else if (a[lowerIndex] != 0 && a[upperIndex] == 0) return 0;
                else if (a[lowerIndex] == 0 && a[upperIndex] != 0) return 0;
                else if (a[lowerIndex] != 0 && a[upperIndex] != 0) aftNonZero = true;

                lowerIndex--;
                upperIndex++;
            }
            if (isCentered == 1 && count >= 3) return 1;
            else return 0;
        }
        //adds a given number of miles to the array
        //the mileage counter is "backwards" in the array, a[0] represents ones, a[1] represents tens, a[2] represents hundreds, etc.
        //{8, 9, 9, 5, 0} + 1 = {9, 9, 9, 5, 0}
        //{9,9,9,9,9} + 13 = {2,1,0,0,0}
        public static void updateMileagecounter(int[] a, int miles)
        {
            if (miles < 0) return;
            for (int m = 1; m <= miles; m++)
            {
                a = addOneMile(a);
            }

            //int[] result = new int[a.Length];
            //result = a;
        }
        public static int[] addOneMile(int[] a)
        {
            int add = 0, carry = 0;
            for (int i = 0; i < a.Length; i++)
            {
                add = a[i] + 1 + carry;
                if (add >= 10)
                {
                    a[i] = 0;
                    if (add % 10 != 0) carry = add % 10;
                    else carry = 0;
                }
                else
                {//if not more than 10, no carry sum for next array elm
                    a[i] = add;
                    break;
                }
            }
            return a;
        }
        //elements are in ascending order and each element appears two or more times
        //{1, 1, 2, 2, 2, 3, 3} is layered but {1, 2, 2, 2, 3, 3} is not
        public static int isLayered(int[] a)
        {
            if (a.Length < 2) return 0;
            bool isSorted = false; int appear = 1;
            for (int i = 1; i < a.Length; i++)            {

                if (a[i - 1] != a[i])//vale changed
                {
                    if (appear < 2) return 0;
                    if (a[i - 1] > a[i]) return 0;
                    isSorted = true;
                    appear = 1;
                }
                else if (a[i - 1] == a[i])
                {
                    appear++;
                    isSorted = true;
                }
            }
            if (isSorted) return 1;
            else return 0;
        }
        //if it contains all numbers between 0 and a.length-1 inclusive
        //{1, 2, 0, 3} => 1
        public static int isAllPossibilities(int[] a)
        {
            if (a.Length < 1) return 0;
            int isPossible = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0 && a[i] <= a.Length - 1) isPossible = 1;
                else return 0;
            }
            return isPossible;
        }
        //polynomial {0, 1, 2, 3, 4}, x = 1
        //4x^4 + 3x^3 + 2x^2 + x^1 + 0x^0 
        //=10.0
        public static double eval(double x, int[] a)
        {
            double sum = 0, xTimes = 1;
            for(int i = 0; i<a.Length; i++)
            {//i = 0, x^0 = 1
                //i = 2, x^2 = x*x
                for(int j=0; j<i; j++)
                {
                    xTimes *= x;
                }
                sum += (a[i] * xTimes);
                xTimes = 1;//need to clear for next number times calculation
            }
            return sum;
        }

        //if they have the same number of factors
        //6 & 21, 6 has 4 factors(1,2,3,6), 21 has 4 factors(1,3,7,21)
        public static int sameNumberOfFactors(int n1, int n2)
        {
            if (n1 < 0 || n2 < 0) return 0;
            if (n1 == n2) return 1;
            if (numOfFactors(n1) == numOfFactors(n2)) return 1;
            else return 0;
        }
        public static int numOfFactors(int n)
        {
            int divider = 1, count = 0;
            while(divider <= n)
            {
                if (n % divider == 0) count++;
                divider++;
            }
            return count;
        }
        //all the elements of the array are one of n different values
        //{1, 1, 1, 8, 1, 1, 1, 3, 3} - 3 differnt values inside array 1,3,8
        public static int hasNValues(int[] a, int n)
        {
            int?[] resultArr = new int?[n];
            int idx = 0;            
            for(int i=0; i<a.Length; i++)
            {
                if(Array.IndexOf(resultArr,a[i]) == -1)
                {
                    if(idx < n)
                    {
                        resultArr[idx] = a[i];
                        idx++;
                    }
                    else//more diff val than n 
                    {
                        return 0;
                    }
                    
                }
            }
            if (idx == n) return 1;
            else return 0;
        }
        public static int allValuesTheSame(int[] a)
        {
            if (a.Length < 1) return 0;
            int isSame = 0;
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] != a[0]) return 0;
                else if (a[i] == a[0]) isSame = 1;
            }
            if (isSame == 1) return 1;
            else return 0;
        }
        //If n is greater than the number of elements in the array, the function loops back to the beginning
        //of the array and continues summing until it has summed n elements
        public static int loopSum(int[] a, int n)
        {
            if (a.Length < 1 || n < 1) return 0;
            int sum = 0, loop, num = n;
            if (num % a.Length == 0) loop = num / a.Length; 
            else loop = num / a.Length + 1;//7/3 = 2 mod 1 - need 3 round loop
            for(int i = 1; i<= loop; i++)
            {
                for (int j = 0; j < a.Length && num > 0; j++, num--)//after one sum - reduce n count;
                {
                    sum += a[j];
                }
            }
            return sum;
        }
        //contains an even element, a perfect square and two different elements that sum to 8.
        //{3, 2, 9, 5} is complete because 2 is even, 9 is a perfect square and a[0] + a[3] = 8.
        public static int isComplete(int[] a)
        {
            if (a.Length < 2) return 0;
            bool isEven = false, isSq = false, is8 = false;
            for(int i = 0; i<a.Length-1; i++)
            {
                if (a[i] % 2 == 0) isEven = true;
                if (a[i] != 1 && isPerfectSquare(a[i]) == 1) isSq = true;//question assume 1 is not perfect square
                if (!is8) { 
                for(int j = 1; j<a.Length; j++)
                    {
                        if (a[i] + a[j] == 8)
                        {
                            is8 = true;
                            break;
                        }
                    }
                }
                if (isEven && isSq && is8) return 1;
            }
            if (isEven && isSq && is8) return 1;
            else return 0;
        }
        //an array with an even number of elements as a parameter and
        //returns an array that
        //contains the pairwise sums of the elements of its parameter array.
        //{2, 1, 18, -5} return {3, 13}
        public static int?[] pairwiseSum(int[] a)
        {
            if (a.Length < 2 || a.Length % 2 != 0) return null;
            int?[] resultArr = new int?[a.Length / 2];
            int idx = 0;
            for(int i= 0; i<a.Length; i= i + 2)
            {
                resultArr[idx] = a[i] + a[i + 1];
                idx++;
            }
            return resultArr;
        }
        //{5, 15, 27}, n = 2
        //5+2=7 is prime, and 15+2=17 is prime, and 27+2=29 is prime
        public static int isNPrimeable(int[] a, int n)
        {
            if(a.Length < 1)
            {
                if (isPrime(n) == 1) return 1;
                else return 0;
            }
            for(int i=0; i<a.Length; i++)
            {
                if (isPrime(a[i] + n) != 1) return 0;
            }
            return 1;
        }
        //{1, 4, 1, 4, 5, 6}
        //a[2] + a[3] == 5 and 2+3==5.
        //the sum of the values is equal to the sum of
        //the corresponding indexes and both are equal to n (5 in this case).
        public static int isPairedN(int[] a, int n)
        {
            if (a.Length < 2) return 0;
            if (n < 0) return 0;
            for(int i = 0; i<a.Length-1; i++)
            {
                for(int j=1; j<a.Length; j++)
                {
                    if(a[i]+a[j] == n)
                    {
                        if (i + j == n)
                            return 1;
                    }
                }
            }
            return 0;
        }
        public static int isMartian(int[] a)
        {
            int count1 = 0, count2 = 0;
            for(int i= 0; i<a.Length; i++)
            {
                if (a[i] == 1) count1++;
                else if (a[i] == 2) count2++;
                if (i != a.Length -1 && a[i] == a[i + 1]) return 0;                
            }
            if (count1 > count2) return 1;
            else return 0;
        }
        public static int[] computeHMS(int seconds)
        {
            if (seconds < 0) return new int[] { 0, 0, 0 };
            int[] hmsArr = new int[3];
            hmsArr[0] = seconds / 3600;
            hmsArr[1] = (seconds % 3600) / 60;
            hmsArr[2] = seconds % 60;

            return hmsArr;
        }
        //{2, 3, 4, 5, 6, 7, 8, 9, 10}, length = 9
        //2 divisible => 2,4,6,8,10 => 5 counts
        //3 divisible => 3,6,9 => 3 counts
        //5 divisible => 5,10 => 2 counts
        //not divisible by 2,3,5 => 7 => 1 counts
        // 5 + 3 + 2 + 1 = 11
        // 11 != 9 (length) 
        //not 235 array
        public static int is235Array(int[] a)
        {
            int div2Count = 0, div3Count = 0, div5Count = 0, nonDivCount = 0;
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] % 2 == 0) div2Count++;
                if (a[i] % 3 == 0) div3Count++;//use 'if' again as 6 is divisible by both 2 and 3
                if (a[i] % 5 == 0) div5Count++;//with else if, only either one work
                if(a[i]%2 != 0 && a[i]%3 != 0 && a[i]%5 !=0) nonDivCount++;
            }
            if (a.Length == div2Count + div3Count + div5Count + nonDivCount) return 1;
            else return 0;
        }
        //array if a 3 does not occur between any two 1s
        public static int isMercurial(int[] a)
        {
            if (a.Length < 1) return 1;
            int? found3Idx = null, found1Lower = null, found1Upper = null;
            int isMercu = 0;
            for (int i=0; i<a.Length; i++)
            {
                if (a[i] == 3)
                {
                    found3Idx = i; 
                }
                else if (a[i] == 1)
                {
                    if (found1Lower == null)
                        found1Lower = i;
                    else if (found1Lower != null && found1Upper == null)
                        found1Upper = i;
                    else if (found1Lower != null && found1Upper != null)
                        found1Upper = i;
                }
                if(found3Idx != null)
                {
                    //1,1, is in front of 3 or behind 3
                    if (found1Upper == null || found3Idx < found1Lower && found3Idx < found1Upper || found3Idx > found1Lower && found3Idx > found1Upper)
                        isMercu = 1;
                    else                        
                        return 0;  //no more checking whether rule is valid more
                }
                
            }
            if (found3Idx == null || found1Upper == null) isMercu = 1;  //3 not in betn;

            return isMercu;
        }
        //n = 1+2+3+4+ ... j
        public static int isTriangular(int n)
        {
            int sum = 0;
            for(int i= 1; i<= n; i++)
            {
                sum += i;
                if (sum == n) return 1;
                else if (sum > n) return 0;
            }
            return 0;
        }
        public static int isFibonacci(int n)
        {
            int fbn1 = 1, fbn2 = 1, nextFbn = 0;
            for (int i = 3; i <= n; i++)//count is 1 by 1
            {
                nextFbn = fbn1 + fbn2;

                if (nextFbn == n) return 1;
                else if (nextFbn < n)
                {
                    fbn1 = fbn2;
                    fbn2 = nextFbn;
                }
                else
                    return 0;
                
            }
            return 0;
        }
        //one-balanced if begins with zero or more 1s followed by zero or more non-1s and
        //concludes with zero or more 1s
        //meaning is not 0 or 1, how many number of one(1) inside array, that must same with how many number of non 1
        //and conclude with 1 or without 1(zero number of 1)
        public static int isOneBalanced(int[] a)
        {
            if (a.Length < 1) return 1;
            int oneCount = 0, nOneCount = 0;
            for(int i= 0;i<a.Length; i++)
            {
                if(a[i] != 1)
                {
                    nOneCount++;
                }else if(a[i] == 1)
                {
                    if(oneCount > 0)
                    {
                        if (i == a.Length - 1)//last elm, last item chk should come first to avoid index out of bound for i+1 chk case
                            oneCount++;
                        else if (a[i - 1] == 1 || a[i + 1] == 1)//have siblings
                            oneCount++;                        
                        else
                            return 0;//another seq start
                    }
                    else
                    {
                        oneCount++;
                    }
                    
                }
            }
            if (nOneCount == oneCount) return 1;
            else return 0;
        }

        // 50 = (25+25) || (1+49) = vesuvian
        //must be different square pair
        // (1*1) + (7*7)
        public static int isVesuvian(int n)
        {
            int i = 1, sum = 0;
            while (i<n)
            {
                for(int j = 1; j <= n; j++){
                    if(i != j)
                    {
                        sum = (i * i) + (j * j);
                    }
                    if (sum == n) return 1;
                    else if (sum > n) break;
                }
                i++;             
            }
            return 0;
        }
        public static int closestFibonacci(int n)
        {
            int fbn1 = 1, fbn2 = 1, nextFbn = 0;
            for(int i=3; i<=n; i++)//count is 1 by 1
            {
                nextFbn = fbn1 + fbn2;
                
                if (nextFbn > n) return fbn2;//it reach faster
                fbn1 = fbn2;
                fbn2 = nextFbn;
            }
            return nextFbn;
        }
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
        //{1, 2, 3, 4} = 7 because 3+4 is larger than either 1+2 or 2+3
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
        //n = 9 to base 2 (binary representation)
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
            if (n < 0) return 0;
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
        //isPerfectSquare(4) returns 1 and isPerfectSquare(8) returns 0
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
