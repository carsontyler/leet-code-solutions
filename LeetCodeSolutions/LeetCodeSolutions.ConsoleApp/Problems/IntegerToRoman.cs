using System.Reflection.Metadata;

namespace LeetCodeSolutions.ConsoleApp.Problems;

public class IntegerToRoman
{
    private static readonly Dictionary<int, char> _key = new Dictionary<int, char>(){
        {1000, 'M'},
        {500, 'D'},
        {100, 'C'},
        {50, 'L'},
        {10, 'X'},
        {5, 'V'},
        {1, 'I'}
    };

    public static void Run(){
        var input = 3749;

        var result = IntToRoman(input);

        var expected = "MMMDCCXLIX";

        Console.WriteLine("Integer to Roman Success: " + (result == expected));
    }

    private static string IntToRoman(int num) {
        string val = "";

        foreach (var kvp in _key){

            while ((double)(num/kvp.Key) >= 1){
                val += kvp.Value;
                num -= kvp.Key;
            }
        }

        val = val.Replace("VIIII", "IX");
        val = val.Replace("IIII", "IV");
        val = val.Replace("LXXXX", "XC");
        val = val.Replace("XXXX", "XL");
        val = val.Replace("DCCCC", "CM");
        val = val.Replace("CCCC", "CD");
        
        return val;
    }
}
