using System;

namespace Algorithm2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 3456, 2, 6, 7896 };
          var ans =  ArrayStructure.FindNumbersWithEvenNumberofdigits(arr);
            Console.WriteLine(ans);
        }
    }
}
