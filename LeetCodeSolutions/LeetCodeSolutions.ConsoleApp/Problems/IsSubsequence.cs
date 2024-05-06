namespace LeetCodeSolutions.ConsoleApp.Problems;

public class IsSubsequence
{
    public static void Run(){
        var s = "abc";
        var t = "ahbgdc";

        var result = Subsequence(s, t);

        var expected = true;

        Console.WriteLine("Subsequence Success: " + (result == expected));
    }

    private static bool Subsequence(string s, string t) {
        if (s.Length == 0)
            return true;
        else if (t.Length == 0)
            return false;

        var j = 0;

        for (int i = 0; i < t.Length; i++){
            if (s[j] != t[i])
                continue;
            else {
                j++;
                if (j == (s.Length))
                    return true;;
            }
        }
        return false;
    }
}
