namespace LeetCodeSolutions.ConsoleApp.Problems;

public class BestTimeToBuyStocks
{
    public static void Run()
    {
        var prices = new int[] { 7, 1, 5, 3, 6, 4 };

        var result = MaxProfit(prices);

        var expected = 5;

        Console.WriteLine("Best Time To Buy Stocks Success: " + (result == expected));
    }

    private static int MaxProfit(int[] prices) {
        var maxDif = 0;

        for (int i = 0; i < prices.Length - 1; i++){
            for (int j = i + 1; j < prices.Length; j++){
                if (prices[j] <= prices[i]){
                    i = j;
                    continue;
                }
                var difference = prices[j] - prices[i];
                if (difference > maxDif)
                {
                    maxDif = difference;
                }
            }
        }

        return maxDif;
    }
}
