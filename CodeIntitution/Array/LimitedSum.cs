using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeIntitution.Array
{
    internal class LimitedSum
    {
        public int TargetLimitedTwoSum(int[] arrr, int target)
        {
           // int[] arrr = { 34, 23, 1, 24, 75, 33, 54, 8 };

            arrr=arrr.OrderBy(x => x).ToArray();
            if(arrr == null || arrr.Length == 0) 
                return -1;
            int left = 0;
            int right = arrr.Length - 1;
            int result = -1;
            while(left < right)
            {
                
                int sum = arrr[left] + arrr[right];
                if(sum<target)
                {
                    result = result > sum ? result : sum;
                    left++;
                }
                right--;
            }
            return result;
        }
    }
}
