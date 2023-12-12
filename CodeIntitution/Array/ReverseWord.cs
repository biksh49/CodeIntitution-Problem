using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CodeIntitution.Array
{
    internal class ReverseWord
    {
        public string ReverseWords(string word)
        {

            char[] inputArr = word.ToCharArray();
            int currentPosition = 0;
            for (int start = 0; start < inputArr.Length; start++)
            {
                if (inputArr[start] == ' ' || start==inputArr.Length-1)
                {
                    int left = currentPosition;
                    int right = start==inputArr.Length-1?start:start-1;
                    while(left < right)
                    {
                        char temp = inputArr[left];
                        inputArr[left] = inputArr[right];
                        inputArr[right] = temp;
                        left++;
                        right--;
                    }
                    currentPosition = start+1;
                }
            }
            string output = new string(inputArr);
            return output;
           
       }
    }
}
