namespace LeetCodeSolutions.ConsoleApp.Problems;

public class Palindrome
{
    public static void Run(){
        var input = "A man, a plan, a canal: Panama";

        var result = IsPalindrome(input);

        Console.WriteLine("Palindrome Success: " + result);
    }

    private static bool IsPalindrome(string s) {
        if (string.IsNullOrWhiteSpace(s))
            return true;

        int j = s.Length - 1;

        for (int i = 0; i <= j; i++){
            if (!Char.IsLetterOrDigit(s[i]))
                continue;

            while (!Char.IsLetterOrDigit(s[j]))
                j--;

            if (Char.ToLower(s[i]) != Char.ToLower(s[j]))
                return false;

            j--;
        }

        return true;
    }
}
