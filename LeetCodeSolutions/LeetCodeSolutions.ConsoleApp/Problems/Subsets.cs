namespace LeetCodeSolutions.ConsoleApp.Problems;

public class Subsets
{
    public static void Run(){
        var input = new[] {1,2,3};

        var result = Subset(input);

        Console.WriteLine("Subsets success: " + (result.Count() == 8));
    }

    private static IList<IList<int>> Subset(int[] nums) {
        var result = new List<IList<int>>(){
            new List<int>()
        };

        for (int i = 0; i < nums.Length; i++){
            var tmpArr = new List<int>() {nums[i]};

            var count = result.Count;
            for (int j = 0; j < count; j++) {
                var tmp2 = result[j].Select(x => x).ToList();
                tmp2.Add(nums[i]);
                result.Add(tmp2);
            }
        }

        return result;
    }
}
