namespace Longest_Palindrome
{
    internal class Program
    {
        #region Problem
        /*
         Given a string s which consists of lowercase or uppercase letters, return the length of the longest palindrome that can be built with those letters.

Letters are case sensitive, for example, "Aa" is not considered a palindrome here.

 

Example 1:

Input: s = "abccccdd"
Output: 7
Explanation: One longest palindrome that can be built is "dccaccd", whose length is 7.
Example 2:

Input: s = "a"
Output: 1
Explanation: The longest palindrome that can be built is "a", whose length is 1.
 

Constraints:

1 <= s.length <= 2000
s consists of lowercase and/or uppercase English letters only.*/
        #endregion
        public int LongestPalindrome(string s)
        {
            if (s.Length <= 1)
                return 1;

            List<char> lst = new List<char>();
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (lst.Contains(s[i]))
                {
                    lst.Remove(s[i]);
                    count++;
                }
                else
                {
                    lst.Add(s[i]);
                }
            }
            if (lst.Count == 0)
                return count * 2;
            else
                return count * 2 + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}