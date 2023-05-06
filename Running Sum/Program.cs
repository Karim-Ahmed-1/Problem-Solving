namespace Running_Sum
{
    internal class Program
    {
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