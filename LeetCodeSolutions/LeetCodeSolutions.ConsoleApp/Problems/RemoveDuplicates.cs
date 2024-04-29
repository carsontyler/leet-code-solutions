namespace LeetCodeSolutions.ConsoleApp.Problems;

public class RemoveDuplicates
{
    public static void Run(){
        var nums = new int[] { 0,0,1,1,1,2,2,3,3,4 };

        var k = Remove(nums);

        var expectedNums = new int[] { 0, 1, 2, 3, 4 };
        var expectedK = 5;

        var success = expectedK == k;

        for (int i = 0; i < k; i++){
            if (nums[i] != expectedNums[i])
                success = false;
        }

        Console.WriteLine("Remove Duplicates Success: " + success);
    }

    private static int Remove(int[] nums) {
        if (nums.Length == 0)
            return 0;

        int j = nums.Length - 1;
        int returnVal = 1;

        for (int i = 0; i < j; i++){
            int k = i;
            while (nums[k] <= nums[i] && k < j){
                k++;
            }
            
            if (k == j && nums[k] == nums[i])
                break;

            nums[i+1] = nums[k];
            returnVal++;
        }
        return returnVal;
    }
}
