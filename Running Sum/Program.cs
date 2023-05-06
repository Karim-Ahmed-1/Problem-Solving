namespace Running_Sum
{
    internal class Program
    {
        #region Problem
        /*
                    * Given two strings s and t, determine if they are isomorphic.

        Two strings s and t are isomorphic if the characters in s can be replaced to get t.

        All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.

 

        Example 1:

        Input: s = "egg", t = "add"
        Output: true
        Example 2:

        Input: s = "foo", t = "bar"
        Output: false
        Example 3:

        Input: s = "paper", t = "title"
        Output: true
 

        Constraints:

        1 <= s.length <= 5 * 104
        t.length == s.length
        s and t consist of any valid ascii character.
         */
        #endregion
        public int[] RunningSum(int[] nums)
        {
            int[] sum = new int[nums.Length];
            if (nums.Length <= 1000 || nums.Length >= 1)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (i <= j)
                        {
                            sum[j] += nums[i];
                        }
                    }
                }
            }
            return sum;

        }
        static void Main(string[] args)
        {
           
        }
    }
}