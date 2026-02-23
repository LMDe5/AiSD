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
            List<List<int>> ultraList = new List<List<int>>
            {
                new List<int> {1, 2, 3},
                new List<int> {3, 4, 5, 8},
                new List<int> {6, 8, 12},
                new List<int> {5, 23, 146},
            };
            List<int> megaList = MegaList(ultraList);
            Console.WriteLine(ShowList(megaList));


            //task 2 i guess
            List<int> numbers = new List<int> { 21, 111, 9, 69, 14, 88, 05, 67, 27, 14, 16, 09};
            string largest = GetLargestNumber(numbers);
            Console.WriteLine(largest);
        }
        public static List<int> MegaList(List<List<int>> list)
        {
            List<int> megaList = new List<int>();
            foreach (List<int> internalList in list)
            {
                foreach (int i in internalList)
                {
                    megaList.Add(i);
                }
            }
            megaList.Sort();
            return megaList;
        }
        public static string ShowList(List<int> list)
        {
            string regularString = "";
            foreach(int i in list)
            {
                regularString = regularString + $"{i}, ";
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
