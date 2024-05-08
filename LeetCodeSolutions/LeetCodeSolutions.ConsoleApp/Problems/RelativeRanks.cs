namespace LeetCodeSolutions.ConsoleApp.Problems;

public class RelativeRanks
{
    public static void Run(){
        var input = new[] {5,4,3,2,1};
        var result = FindRelativeRanks(input);

        var expected = new[] {"Gold Medal","Silver Medal","Bronze Medal","4","5"};

        var success = true;

        for (int i = 0; i < expected.Length; i++){
            if (expected[i] != result[i])
                success = false;
        }

        Console.WriteLine("Relative Ranks Success: " + success);
    }

    private static string[] FindRelativeRanks(int[] score) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        var output = new string[score.Length];

        for (int i = 0; i < score.Length; i++){
            map.Add(score[i], i);
        }

        Array.Sort(score);

        for (int i = 0; i < score.Length; i++){
            var val = score[score.Length - 1 - i];
            var sVal = "";

            switch (i){
                case 0: 
                    sVal = "Gold Medal";
                    break;
                case 1:
                    sVal = "Silver Medal";
                    break;
                case 2:
                    sVal = "Bronze Medal";
                    break;
                default:
                    sVal = (i + 1).ToString();
                    break;
            }

            output[map[val]] = sVal;

        }

        return output;
    }
}
