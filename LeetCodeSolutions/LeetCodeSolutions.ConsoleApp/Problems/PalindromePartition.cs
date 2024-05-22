namespace LeetCodeSolutions.ConsoleApp.Problems;

public class PalindromePartition
{
    public static void Run(){
        var str = "aab";
        var result = Partition(str);

        var success = result.Count() == 2;

        Console.WriteLine("Palindrome Parition Success: " + success);
    }

    public static IList<IList<string>> Partition(string s) {
        var result = new List<IList<string>>();
        Part(s, 0, result, []);
        return result;
    }

    private static void Part(string s, int start, List<IList<string>> result, List<string> currentList){
        if (start >= s.Length){
            result.Add(new List<string>(currentList));
        }

        for (int end = start; end < s.Length; end++){
            if (IsPalindrome(s, start, end)){
                currentList.Add(s.Substring(start, end - start + 1));
                Part(s, end + 1, result, currentList);
                currentList.RemoveAt(currentList.Count - 1);
            }

        }
    }

    private static bool IsPalindrome(string s, int start, int end){
        while (start < end){
            if (s[start++] != s[end--]) 
                return false;
        }

        return true;
    }
}
