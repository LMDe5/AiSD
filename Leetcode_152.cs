using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD
{
    internal class Leetcode_152
    {
        public Leetcode_152()
        {
        }
        //{28, 150, -10, -69, -67, 14, 88};
        public int MaxInternalArray(int[] ints)
        {
            if (ints.Length == 0)
            {
                return 0;
            }
            int maxResult = 0;
            int minResult = 0;
            int result = ints[0];

            if (result < 0)
            {
                minResult = result;
            }
            else
            {
                maxResult = result;
            }


            for (int i = 1; i < ints.Length; i++)
            {
                int current = ints[i];
                int minIntermediateResult = minResult * current;
                int maxIntermediateResult = maxResult * current;

                int newMax = 0;
                if (current > minIntermediateResult && current > maxIntermediateResult)
                {
                    newMax = current;
                }
                else if (minIntermediateResult > current && minIntermediateResult > maxIntermediateResult)
                {
                    newMax = minIntermediateResult;
                }
                else
                {
                    newMax = maxIntermediateResult;
                }


                int newMin = 0;
                if (current < minIntermediateResult && current < maxIntermediateResult)
                {
                    newMin = current;
                }
                else if (minIntermediateResult < current && minIntermediateResult < maxIntermediateResult)
                {
                    newMin = minIntermediateResult;
                }
                else
                {
                    newMin = maxIntermediateResult;
                }

                maxResult = newMax;
                minResult = newMin;

                if (maxResult > result) 
                {
                    result = maxResult;
                }
            }

            return result;
        }

    }
}
