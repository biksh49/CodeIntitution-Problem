using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CodeIntitution.Array
{
    internal class ReverseSegment
    {
        
        public string ReverseSegments(string s, int k)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            int n= s.Length;
            if (k > s.Length)
            {
                s=ReverseString(s.ToCharArray());
                return s;
            }
            char[] inputArr= s.ToCharArray();
            for(int start=0; start<n; start += 2 * k)
            {
                int left = start;
                int right = 0;
                if(start < n)
                {
                    right = start+k-1;
;                }
                else
                {
                    right = 0;
                }
               
                while (left < right)
                {

                    char temp = inputArr[left];
                    inputArr[left] = inputArr[right];
                    inputArr[right] = temp;
                    left++;
                    right--;
                }
            }
            return inputArr.ToString();

            
        }
        private string ReverseString(char[] input)
        {
            int left = 0; int right=input.Length;
            while (left < right)
            {
                char temp = input[left];
                input[left] = input[right];
                input[right] = temp;
                left++;
                right--;
            }
            return input.ToString();
            

        }
    }
}
