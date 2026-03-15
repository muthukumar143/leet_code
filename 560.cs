// Subarray Sum Equals K
/*
Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.

A subarray is a contiguous non-empty sequence of elements within an array.

 

Example 1:

Input: nums = [1,1,1], k = 2
Output: 2

Example 2:

Input: nums = [1,2,3], k = 3
Output: 2

 

Constraints:

    1 <= nums.length <= 2 * 104
    -1000 <= nums[i] <= 1000
    -107 <= k <= 107

*/

int SubarraySum(int[] nums, int k)
{
    var prefixCount = new Dictionary<int, int>();
    prefixCount[0] = 1;
    int sum = 0, res = 0;

    foreach (var num in nums)
    {
        sum += num;
        if (prefixCount.ContainsKey(sum - k))
            res += prefixCount[sum - k];

        if (!prefixCount.ContainsKey(sum))
            prefixCount[sum] = 0;
        prefixCount[sum]++;
    }

    return res;
}


Console.WriteLine(SubarraySum([1, 2, 1, 2, 1], 5));
Console.WriteLine(SubarraySum([1, 2, 3], 3));
Console.WriteLine(SubarraySum([1, -1, 0], 0));
