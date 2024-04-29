namespace LeetCodeSolutions.ConsoleApp.Problems;

public class RemoveElement
{

    public static void Run()
    {
        var nums = new int[] { 3, 2, 2, 3 };

        var val = 3;

        var k = Remove(nums, val);

        var expectedK = 2;
        var expectedNums = new int[] { 2, 2 };

        var success = expectedK == k;

        for (int i = 0; i < k; i++)
        {
            if (nums[i] != expectedNums[i])
                success = false;
        }

        Console.WriteLine("Remove Element Success: " + success);
    }

    private static int Remove(int[] nums, int val)
    {
        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[index] = nums[i];
                index++;
            }
        }
        return index;
    }
}
