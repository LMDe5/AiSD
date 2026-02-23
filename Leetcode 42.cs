using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AISD
{
    internal class Leetcode_42
    {
        public Leetcode_42()
        {
        }

        public int Trap(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxLeft = 0;
            int maxRight = 0;
            int result = 0;

            while (left <= right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] > maxLeft)
                    {
                        maxLeft = height[left];
                    }
                    else
                    {
                        result += maxLeft - height[left];
                    }
                    left++;
                }
                else
                {
                    if (height[right] >  maxRight)
                    {
                        maxRight = height[right];
                    }
                    else
                    {
                        result += maxRight - height[right];
                    }
                    right--;
                }
            }
            return result;
        }
    }
}
