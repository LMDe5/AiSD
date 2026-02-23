using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math; 
namespace AISD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            int[][] ultraArray =
            {
                new int[] {1, 2, 3},
                new int[] {3, 4, 5, 8},
                new int[] {6, 8, 12},
                new int[] {5, 23, 146},
            };
            int[] megaArray = MegaArray(ultraArray);
            Console.WriteLine(ShowArray(megaArray));

            //task 2 i guess
            List<int> numbers = new List<int> { 21, 111, 9, 50, 69, 14, 88};
            string largest = GetLargestNumber(numbers);
            Console.WriteLine(largest);

            //task LeetCode_42 :D
            Leetcode_42 leetcode_42 = new Leetcode_42();
            int[] columnes = new int[] {12, 10, 28, 69, 14, 88};
            Console.WriteLine(leetcode_42.Trap(columnes));

            //task Leetcode_152 :D
            Leetcode_152 leetcode_152 = new Leetcode_152();
            int[] ints = new int[] { -28, 5, 4, -2, 14, 16, 12, -4};
            Console.WriteLine(leetcode_152.MaxInternalArray(ints));

        }
        public static int[] MegaArray(int[][] list)
        {
            int totalLength = 0;
            foreach (int[] innerArray in list)
            {
                totalLength += innerArray.Length;
            }

            int[] megaArray = new int[totalLength];
            int position = 0;

            foreach (int[] innerArray in list)
            {
                foreach (int item in innerArray)
                {
                    megaArray[position++] = item;
                }
            }

            BubbleSort(megaArray);

            return megaArray;
        }

        public static void BubbleSort(int[] array)
        {
            bool flag;
            for (int i = 0; i < array.Length - 1; i++)
            {
                flag = false;
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = true;
                    }
                }
                if (!flag)
                    break;
            }
        }

        public static string ShowArray(int[] array)
        {
            string regularString = "";
            for (int i = 0; i < array.Length; i++)
            {
                regularString = regularString + array[i] + ", "; 
            }
            return regularString;
        }
        public static string GetLargestNumber(List<int> nums)
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                for (int j = 0; j < nums.Count - 1 - i; j++)
                {
                    string a = nums[j].ToString();
                    string b = nums[j + 1].ToString();

                    if (CompareStrings(b + a, a + b) > 0)
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            if (nums.Count > 0 && nums[0] == 0)
            {
                return "0";
            }

            string result = "";
            foreach (int num in nums)
            {
                result += num.ToString();
            }
            return result;
        }

        public static int CompareStrings(string x, string y)
        {
            int minLength;
            if (x.Length < y.Length)
            {
                minLength = x.Length;
            }
            else
            {
                minLength = y.Length;
            }
            for (int i = 0; i < minLength; i++)
            {
                if (x[i] > y[i]) { return 1; }
                if (x[i] < y[i]) { return -1; }
            }

            if (x.Length > y.Length) { return 1; }
            if (x.Length < y.Length) { return -1; }

            return 0;
        }

    }
}
