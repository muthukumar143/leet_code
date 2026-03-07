// Running Sum of 1d Array
public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int[] ans = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            var prev = i == 0 ? 0 : ans[i - 1];
            ans[i] = nums[i] + prev;
        }
        return ans;
    }

    public static void Main()
    {
        Console.WriteLine(new Solution().RunningSum(new[] { 1, 2, 3, 4, 5, 6 }));
    }
}
