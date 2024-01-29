using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeIntitution.Array
{
    internal class TwoSum
    {
        public int[] TwoSums(int[] arr, int target)
        {
           arr=arr.OrderBy(x => x).ToArray();
           if(arr.Length == 0) return new int[0];
           int left = 0;
           int right=arr.Length-1;
            while (left < right)
            {
                int sum = arr[left] + arr[right];
                if (sum == target)
                {

                    // Found a pair that sums up to the target
                    return new int[] { arr[left], arr[right] };
                }
                else if (sum < target)
                {
                    // Move the left pointer to increase the sum
                    left++;
                }
                else
                {
                    // Move the right pointer to decrease the sum
                    right--;
                }

            }
            return new int[0];

        }
    }
}
