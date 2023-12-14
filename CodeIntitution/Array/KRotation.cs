using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeIntitution.Array
{
    internal class KRotation
    {
        public void KRotations(int[] arr, int k)
        {
            //int lastTerm = arr[arr.Length - 1];
            //for(int i = arr.Length - 2; i<0; i--)
            //{
            //    arr[i] = arr[i + 1];    //1,2,3,4,4  //1,2,3,3,4 //1,2,2,3,4 //1,1,2,3,4


            //}

            //arr=[1,2,3,4,5]--->k=3
            //arr[5,1,2,3,4]
            //arr[4,5,1,2,3]
            //arr[3,4,5,1,2]


            int n = arr.Length;

            // set k to be in the range of [0, n)
            k %= n;

            // reverse the entire array
            reverse(arr, 0, n - 1);

            // reverse the first k elements
            reverse(arr, 0, k - 1);

            // reverse the remaining elements
            reverse(arr, k, n - 1);

            // helper function to reverse the array within the range [start, end]
            




        }
        void reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
