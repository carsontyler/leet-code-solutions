namespace LeetCodeSolutions.ConsoleApp.Problems;

public class MajorityElement
{
    public static void Run(){
        var nums = new int[] {2,2,1,1,1,2,2};
        var majority = Majority(nums);
        var expected = 2;
        Console.WriteLine("Majority Element Success: " + (majority == expected));
    }

    private static int Majority(int[] nums) {
        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach (var num in nums){
            if (count.ContainsKey(num))
                count[num]++;
            else
                count[num] = 1;
        }

        foreach (var item in count){
            if (item.Value > nums.Length / 2)
                return item.Key;
        }
        return 0;
    }
}