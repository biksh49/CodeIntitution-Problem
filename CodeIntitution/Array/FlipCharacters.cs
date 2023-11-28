using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeIntitution.Array
{
    internal class FlipCharacters
    {
        public void FlipCharacterss(char[] arr)
        {
            int left=0, right=arr.Length-1;

            while(left<right)
            {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
            Console.WriteLine(arr.ToString());
            Console.ReadLine();
        }
    }
}


