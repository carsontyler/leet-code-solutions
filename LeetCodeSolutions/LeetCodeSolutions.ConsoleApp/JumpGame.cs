public class JumpGame
{
    public static void Run(){
        var nums = new int[] {2,3,1,1,4};
        var canJump = CanJump(nums);

        Console.WriteLine("Jump Game Success: " + canJump);
    }

    private static bool CanJump(int[] nums) {
        int finishIndex = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i + nums[i] >= finishIndex)
            {
                if (i == 0) return true;
                finishIndex = i;
            }
        }
        return false;
    }
}
