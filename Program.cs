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
            Console.WriteLine("LeetCode_42");
            Leetcode_42 leetcode_42 = new Leetcode_42();

            Console.WriteLine("Массив: {12, 10, 28, 69, 14, 88}");
            int[] columnes = new int[] { 12, 10, 28, 69, 14, 88 };
            Console.WriteLine(leetcode_42.Trap(columnes));

            Console.WriteLine("Массив: { 0, 1, 2, 3, 2, 1, 0 }");
            int[] columnes1 = new int[] { 0, 1, 2, 3, 2, 1, 0 };
            Console.WriteLine(leetcode_42.Trap(columnes1));

            Console.WriteLine("Массив: { 4, 1, 2, 3, 2, 1, 4 }");
            int[] columnes2 = new int[] { 4, 1, 2, 3, 2, 1, 4 };
            Console.WriteLine(leetcode_42.Trap(columnes2));

            //task Leetcode_152 :D
            Console.WriteLine("LeetCode_152");
            Leetcode_152 leetcode_152 = new Leetcode_152();

            Console.WriteLine("Массив: {2, 3, -4, 2}");
            int[] ints = new int[] {2, 3, -4, 2};
            Console.WriteLine(leetcode_152.MaxInternalArray(ints));

            Console.WriteLine("Массив: {2, 3, -4, 2, -8}");
            int[] ints1 = new int[] { 2, 3, -4, 2, -8 };
            Console.WriteLine(leetcode_152.MaxInternalArray(ints1));

            Console.WriteLine("Массив: {-28, 5, 4, -2, 14, 16, 12, -4}");
            int[] ints2 = new int[] {-28, 5, 4, -2, 14, 16, 12, -4};
            Console.WriteLine(leetcode_152.MaxInternalArray(ints2));

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
                string a = nums[i].ToString();
                string b = nums[i + 1].ToString();

                if (CompareStrings(a + b, b + a) == false)
                {
                    int y = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = y;
                }
            }

            string result = "";
            foreach (int num in nums)
            {
                result += num.ToString();
            }
            return result;
        }

        public static bool CompareStrings(string a, string b)
        {
            string ab = a + b;
            string ba = b + a;
            for (int i = 0; i < ab.Length; i++)
            {
                if (ab[i] > ba[i]) return true;  
                if (ab[i] < ba[i]) return false; 
            }
            return true; 
        }

    }
}
