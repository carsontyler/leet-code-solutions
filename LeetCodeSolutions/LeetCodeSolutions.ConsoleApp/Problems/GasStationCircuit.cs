using System.Runtime.CompilerServices;

namespace LeetCodeSolutions.ConsoleApp.Problems;

public class GasStationCircuit
{
    public static void Run()
    {
        var gas = new[] { 1, 2, 3, 4, 5 };
        var cost = new[] { 3, 4, 5, 1, 2 };

        var result = CanCompleteCircuit(gas, cost);

        var expected = 3;

        Console.WriteLine("Gas Station Circuit Success: " + (result == expected));
    }

    private static int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var start = 0;
        var diff = 0;
        var totalDiff = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            totalDiff += (gas[i] - cost[i]);
            diff += (gas[i] - cost[i]);
            if (diff < 0)
            {
                diff = 0;
                start = i + 1;
            }
        }

        if (totalDiff < 0)
            return -1;

        return start;
    }
}
