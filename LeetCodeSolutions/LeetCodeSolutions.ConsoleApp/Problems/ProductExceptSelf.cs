namespace LeetCodeSolutions.ConsoleApp.Problems;

public class ProductExceptSelf
{
    public static void Run(){
        var nums = new int[4] { 1, 2, 3, 4 };

        var result = ProductExceptSelfRun(nums);

        var expected = new[] {24,12,8,6};
        var success = true;

        for (int i = 0; i < expected.Length; i++){
            if (expected[i] != result[i])
                success = false;
        }

        Console.WriteLine("Product Except Self Success: " + success);
    }

    private static int[] ProductExceptSelfRun(int[] nums) {
        int[] answer = new int[nums.Length];
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];

        prefix[0] = 1;
        for (int i = 1; i < nums.Length; i++){
            prefix[i] = nums[i - 1] * prefix[i - 1];
        }

        suffix[nums.Length - 1] = 1;
        for (int i = nums.Length - 2; i >= 0; i--){
            suffix[i] = nums[i + 1] * suffix[i + 1];
        }

        for (int i = 0; i < nums.Length; i++){
            answer[i] = prefix[i] * suffix[i];
        }
        
        return answer;
    }
}
