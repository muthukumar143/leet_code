//Find Pivot Index
// The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.

int PivotIndex(int[] nums)
{
    var totalSum = nums.Aggregate((acc, val) => acc + val);
    int i = 0, lftSum = 0;
    while (i < nums.Length)
    {
        lftSum += nums[i];
        if (lftSum == totalSum - (lftSum - nums[i])) return i;
        i++;
    }
    return -1;
}

Console.WriteLine(PivotIndex([1, 7, 3, 6, 5, 6]));
Console.WriteLine(PivotIndex([1, 2, 3]));
Console.WriteLine(PivotIndex([2, 1, -1]));
