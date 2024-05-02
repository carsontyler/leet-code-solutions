namespace LeetCodeSolutions.ConsoleApp.Problems;

public class RomanToInteger
{
    private static Dictionary<char, int> _key = new Dictionary<char, int>(){
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    public static void Run(){
        var input = "MCMXCIV";
        var result = RomanToInt(input);
        var expected = 1994;

        Console.WriteLine("Roman to Integer Success: " + (result == expected));
    }

    private static int RomanToInt(string s) {
        var value = 0;
        char previousC = ' ';

        foreach (char c in s){
            if (previousC == 'I' &&
                (c == 'V' || c == 'X')){
                value -= 2;
            }
            if (previousC == 'X' &&
                (c == 'L' || c == 'C')){
                value -= 20;
            }
            if (previousC == 'C' &&
                (c == 'D' || c == 'M')){
                value -= 200;
            }
            value += _key[c];
            previousC = c;
        }

        return value;
    }
}
