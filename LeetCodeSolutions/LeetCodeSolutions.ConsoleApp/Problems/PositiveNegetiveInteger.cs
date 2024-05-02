namespace LeetCodeSolutions.ConsoleApp.Problems;

public class PositiveNegetiveInteger
{
    public static void Run(){
        var input = new[] {-1,10,6,7,-7,1};

        var result = FindMaxK(input);

        var expected = 7;

        Console.WriteLine("Positive Negetive Integer Success: " + (result == expected));
    }

    private static int FindMaxK(int[] nums) {
        var val = -1;
        var i = 0;
        var j = nums.Length - 1;

        Array.Sort(nums);

        while (i < j){
            if (nums[i] + nums[j] == 0)
                return nums[j];
            else if (nums[i] + nums[j] < 0){
                i++;
            }
            else {
                j--;
            }
        }

        return val;
    }
}
