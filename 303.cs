// Range Sum Query - Immutable

public class NumArray
{

    int[] arr;
    public NumArray(int[] nums)
    {
        arr = new int[nums.Length];
        arr[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            arr[i] = arr[i - 1] + nums[i];
        }
    }

    public int SumRange(int left, int right)
    {
        return arr[right] - (left == 0 ? 0 : arr[left - 1]);
    }

    public static void Main()
    {
        var obj = new NumArray([1, 2, 3, 4, 5, 6, 7]);
        Console.WriteLine(obj.SumRange(0, 2)); //6
        Console.WriteLine(obj.SumRange(2, 5)); //18
        Console.WriteLine(obj.SumRange(0, 5)); //21
    }
}

