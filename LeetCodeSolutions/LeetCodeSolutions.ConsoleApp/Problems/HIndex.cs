namespace LeetCodeSolutions.ConsoleApp.Problems;

public class HIndex
{
    public static void Run(){
        var citations = new int[] {3,0,6,1,5};

        var result = HIndexRun(citations);

        var expected = 3;

        Console.WriteLine("HIndex Success: " + (expected == result));
    }

    private static int HIndexRun(int[] citations) {
        int h = 0;
        Array.Sort(citations);

        for (int i = citations.Length - 1; i >= 0; i--){
            if (citations[i] >= (citations.Length - i))
            {
                h = citations.Length - i;
            }
            else if (citations[i] < (citations.Length - i)){
                break;
            }
        }

        return h;
    }
}
