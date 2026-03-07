// Maximum Average Subarray I

double FindMaxAverage(int[] nums, int k)
{
    int[] presums = new int[nums.Length];

    presums[0] = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
        presums[i] = presums[i - 1] + nums[i];
    }

    double avg = double.MinValue;
    for (int i = 0; i + k - 1 < nums.Length; i++)
    {
        double total = (presums[i + k - 1] - (i == 0 ? 0 : presums[i - 1]));
        if (avg < total / k) avg = total / k;
    }

    return avg;

    /*
    [1,12,-5,-6,50,3]
    [1,13,8,2,52,3]
    k = 4;
    */
}

Console.WriteLine(FindMaxAverage([4, 0, 4, 3, 3], 5));

