public class Solution {
    public bool CanPartition(int[] nums) {
        int sum = nums.Sum();
        if(sum%2==1)
        {
            return false;
        }
        int needsum = sum / 2;


        bool[] dp = new bool[needsum + 1];

        dp[0] = true;

        foreach(int num in nums)
        {
            for (int i = needsum; i > 0; i--)
            {
                if (i >= num)
                {
                    dp[i] = dp[i] || dp[i - num];
                }
            }
        }

        return dp[needsum];    
    }
}