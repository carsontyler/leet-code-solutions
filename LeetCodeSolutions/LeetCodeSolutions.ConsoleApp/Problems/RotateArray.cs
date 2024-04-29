namespace LeetCodeSolutions.ConsoleApp.Problems;

public class RotateArray
{
    public static void Run(){
        var nums = new int[] {1,2,3,4,5,6,7};
        int k = 3;

        Rotate(nums, k);

        var expected = new int[] {5,6,7,1,2,3,4};
        var success = false;

        for (int i = 0; i < nums.Length; i++){
            if (nums[i] != expected[i])
                success = false;
        }

        Console.WriteLine("Rotate Array Success: " + success);
    }

    private static void Rotate(int[] nums, int k) {
        int j = nums.Length - k;

        int[] numsTemp = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++){
            int index = (i + k) % nums.Length;
            numsTemp[index] = nums[i];

        }

        for (int i = 0; i < nums.Length; i++){
            nums[i] = numsTemp[i];
        }
    }
}
