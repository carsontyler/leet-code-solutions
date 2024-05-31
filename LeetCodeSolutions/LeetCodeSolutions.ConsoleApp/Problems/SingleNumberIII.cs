namespace LeetCodeSolutions.ConsoleApp.Problems;

public class SingleNumberIII
{
    public static void Run(){
        var input = new int[] {1,2,1,3,2,5};

        var result = SingleNumber(input);

        var expected = 2;
        
        Console.WriteLine("Single Number III Success: " + (result.Length == expected));
    }

    private static int[] SingleNumber(int[] nums) {
        var list = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++){
            if (list.Contains(nums[i])){
                list.Remove(nums[i]);
            }
            else{
                list.Add(nums[i]);
            }
        }

        return list.ToArray();
    }
 
}
