using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeIntitution.Array
{
    internal class VowelExchange
    {
        public string VowelExchanges(string s)
        {
            //string s = "afegijoku";
            HashSet<char> vowel = new HashSet<char>();
            vowel.Add('a');
            vowel.Add('e');
            vowel.Add('i');
            vowel.Add('o');
            vowel.Add('u');
            vowel.Add('A');
            vowel.Add('E');
            vowel.Add('I');
            vowel.Add('O');
            vowel.Add('U');

            char[] inputArray = s.ToCharArray();
            int left = 0;
            int right=s.Length-1;

            while (left < right)
            {
                if (!vowel.Contains(inputArray[left]))
                {
                    left++;
                }
                else if(!vowel.Contains(inputArray[right]))
                {
                    right--;

                }
                else
                {
                    char temp = inputArray[left];
                    inputArray[left] = inputArray[right];
                    inputArray[right] = temp;
                    left++;
                    right--;
                }
            }
            string output = new string(inputArray);
            return output;
        }
    }
}
