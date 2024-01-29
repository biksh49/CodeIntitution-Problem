using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;


namespace CodeIntitution.Array
{
    internal class DuplicateTwoAwareSum
    {
        public int[][] DuplicateAwareTwoSums(int[] arr, int target)
        {
            // why do you sort an array?
            // sorting benefits 
            arr=arr.OrderBy(x => x).ToArray();
            List<int[]>resultSet=new List<int[]>();
            int left = 0;
            int right= arr.Length-1;
            while (left < right)
            {
                int sum = arr[left] + arr[right];
                if (sum == target)
                {
                    // Found a pair that sums up to the target
                    resultSet.Add(new int[] { arr[left], arr[right] });

                    // Skip duplicates for the left pointer
                    while (left < right && arr[left] == arr[left + 1])
                    {
                        left++;
                    }

                    // Skip duplicates for the right pointer
                    while (left < right && arr[right] == arr[right - 1])
                    {
                        right--;
                    }

                    left++;
                    right--;
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
            return resultSet.ToArray();
        }
    }
}
