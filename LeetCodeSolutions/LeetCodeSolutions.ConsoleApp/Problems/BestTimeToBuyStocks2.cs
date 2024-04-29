namespace LeetCodeSolutions.ConsoleApp.Problems;

public class BestTimeToBuyStocks2
{
    public static void Run()
    {
        var prices = new int[] { 7, 1, 5, 3, 6, 4 };

        var result = MaxProfit(prices);

        var expected = 7;

        Console.WriteLine("Best Time To Buy Stocks 2 Success: " + (result == expected));
    }

    private static int MaxProfit(int[] prices)
    {
        var maxDif = 0;

        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i] < prices[i + 1])
            {
                maxDif += prices[i + 1] - prices[i];
            }
        }

        return maxDif;
    }
}
