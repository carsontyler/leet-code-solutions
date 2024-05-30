namespace LeetCodeSolutions.ConsoleApp.Problems;

public class ReduceBinaryNumber
{
    public static void Run(){
        var input = "1101";
        var result = NumSteps(input);
        var expected = 6;

        Console.WriteLine("Reduce Binary Number Success: " + (result == expected));
    }

    private static int NumSteps(string s) {
        var sb = new System.Text.StringBuilder(s);
        int steps = 0;

        // Loop until the binary number is reduced to '1'
        while (sb.Length > 1) {
            if (sb[sb.Length - 1] == '0') {
                // If the number is even, remove the last character
                sb.Length--; // Equivalent to sb.Remove(sb.Length - 1, 1)
            } else {
                // If the number is odd, we need to add 1
                int i = sb.Length - 1;
                while (i >= 0 && sb[i] == '1') {
                    sb[i] = '0';
                    i--;
                }
                // If we have a carry past the most significant bit, prepend '1'
                if (i >= 0) {
                    sb[i] = '1';
                } else {
                    sb.Insert(0, '1');
                }
            }
            steps++;
        }

        return steps;
    }
}
