namespace LeetCodeSolutions.ConsoleApp.Problems;

public class CompareVersionNumbers
{
    public static void Run(){
        var v1 = "7.5.2.4";
        var v2 = "7.5.3";

        var result = CompareVersion(v1, v2);

        var expected = -1;

        Console.WriteLine("Compare Version Numbers Success: " + (result == expected));
    }

    private static int CompareVersion(string version1, string version2) {
        var v1 = version1.Split('.');
        var v2 = version2.Split('.');

        var maxLength = Math.Max(v1.Length, v2.Length);

        for (int i = 0; i < maxLength; i++){
            var v1Val = 0;
            var v2Val = 0;

            if (v1.Length >= (i + 1))
                v1Val = Int32.Parse(v1[i]);

            if (v2.Length >= (i + 1))
                v2Val = Int32.Parse(v2[i]);

            if (v1Val < v2Val)
                return -1;

            if (v1Val > v2Val)
                return 1;
        }

        return 0;
    }
}
