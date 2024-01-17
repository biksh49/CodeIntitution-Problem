using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeIntitution.Array
{
    internal class Container
    {
        public int LargestContainer(/*int[] heights*/)
        {

            int[] arr = new int[] { 2, 4, 3, 3, 5, 2, 4, 3, 2 };
            int left = 0;
            int right = arr.Length - 1;
            int maxArea = 0;
            while (left < right)
            {
                int area = 0;
                int difference = right - left;
                if (arr[left] < arr[right])
                {
                    area = arr[left] * difference;
                    left++;
                }
                else
                {
                    area= arr[right] * difference;
                    right--;
                }
                maxArea = maxArea>area ? maxArea : area;

            }
            return maxArea;
            
        }
    }
}
