using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeIntitution.Array
{
    internal class ReverseWordString
    {
        public String ReverseWordOrder(String s)
        {
            s = "a good   example";
            char[] inputArr = s.ToCharArray();
            string output = string.Empty;
            int n = inputArr.Length;
            int currentPosition = n;
            for (int end = n - 1; end >=0 ; end--)
            {
                if (inputArr[end] == ' ' || end==0 )
                {
                    int left = end==0?end:end + 1;
                    int right = currentPosition;
                    while(left<right)
                    {
                      output+= inputArr[left];
                      left++;
                    }
                    output +=end==0?null: inputArr[end];
                    currentPosition = end;
                }
            }
            return string.Join("",output);
        }

    }
}
