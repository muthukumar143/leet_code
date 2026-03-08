// Move Zeroes
/*
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

 

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]

Example 2:

Input: nums = [0]
Output: [0]

 

Constraints:

    1 <= nums.length <= 104
    -231 <= nums[i] <= 231 - 1

*/

void MoveZeroes(int[] nums)
{
    int left = 0, right = 0, n = nums.Length;

    while (left < n)
    {
        if (nums[left] == 0 && left + 1 < n)
        {

            right = right == 0 ? left + 1 : right++;
            while (right < n)
            {
                if (nums[right] != 0)
                {
                    int tmp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = tmp;
                    left++;
                    break;
                }
                else
                {
                    right++;
                }
            }

            if (right > n - 1) break;
        }
        else
        {
            left++;
        }
    }
}

int[] nums = [0];
MoveZeroes(nums);
Console.WriteLine(string.Join(',', nums));
