namespace Pivot_Index
{
    internal class Program
    {
        //        Input: nums = [1,7,3,6,5,6]
        //        Output: 3
        //Explanation:
        //The pivot index is 3.
        //Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11
        //Right sum = nums[4] + nums[5] = 5 + 6 = 11

        //        Input: nums = [1,2,3]
        //        Output: -1
        //Explanation:
        //There is no index that satisfies the conditions in the problem statement.
        public static int PivotIndex(int[] nums)
        {
            if (nums.Length <= 10000 || nums.Length >= 1)
            {
                int expectedsum;
                int actualSum = 0;
                expectedsum = 0;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    actualSum += nums[i + 1];
                }
                if (actualSum == expectedsum) { return 0; }

                int pivotindex = 1;
                int leftSum = 0, rightSum = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    pivotindex = i;
                    leftSum = rightSum = 0;
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += nums[j];
                    }
                    for (int t = nums.Length-1; t > i; t--)
                    {
                        rightSum += nums[t];
                    }
                    if (leftSum == rightSum) { return pivotindex; }

                }
                return -1;
            }
            return -1;




        }
        public static void Main(string[] args)
        {
            
        }
    }
}