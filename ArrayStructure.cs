using System;

namespace Algorithm2021
{
    public static class ArrayStructure
    {
        /// <summary>
        /// fuction That returns number of consecutive 1's in an array
        /// time complexity is O(n) spave
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int NumberOfConsecutiveOnes(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int prevlength = 0;
            int sublength = 0;
            foreach (var item in nums)
            {
                if (item == 1)
                {
                    prevlength++;
                    sublength = Math.Max(prevlength, sublength);
                }
                else
                {
                    sublength = Math.Max(prevlength, sublength);
                    prevlength = 0;
                }
            }

            return sublength;
        }

        /// <summary>
        /// fuction to find numbers with even numbers of digits in an array
        /// </summary>
        /// <returns></returns>

        public static int FindNumbersWithEvenNumberofdigits(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int evencount = 0;
            foreach (var item in nums)
            {
                var curnum = item;
                int numcount = 0;
                while (curnum != 0)
                {
                    numcount++;
                    curnum = curnum / 10;
                }

                if (numcount % 2 == 0)
                {
                    evencount++;
                }
            }
            return evencount;
        }

        public static int[] SquareofArr(int[] nums)
        {
            if (nums.Length == 0)
            {
                return new int[] { };
            }
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i] * nums[i];
            }
             Array.Sort(result);
            return result;
        }
    }
}