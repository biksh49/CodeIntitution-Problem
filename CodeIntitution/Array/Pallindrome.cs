using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeIntitution.Array
{
    internal class Pallindrome
    {
        public bool PalindromeChecker(string input)
        {
            if(string.IsNullOrEmpty(input)) 
                return true;
            input = input.ToLower().Trim();
            string reverseWord=ReverseWord(input);
            if (input == reverseWord)
            {
                return true;
            }
            else
            {
                return false;
            }

         

        }
        private string ReverseWord(string word)
        {
            char[] charArr = word.ToCharArray();
            string reverseWord = string.Empty;
            for (int i = charArr.Length - 1; i >= 0; i--)
            {
                reverseWord = reverseWord + charArr[i];
            }
            return reverseWord;
        }
        public bool IsValid(string s)
        {
            if(string.IsNullOrEmpty(s))
                return true;
            s = Regex.Replace(s, @"[^0-9a-zA-Z]+", "");
            s=s.Trim();
            int i = 0;
            int j=s.Length-1;

            while(i < j)
            {
               
                
                if (s[i] == s[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
