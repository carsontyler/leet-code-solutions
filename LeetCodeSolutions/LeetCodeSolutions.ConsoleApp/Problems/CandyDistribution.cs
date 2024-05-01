namespace LeetCodeSolutions.ConsoleApp.Problems;

public class CandyDistribution
{
    public static void Run(){
        var ratings = new[] {1,2,87,87,87,2,1};

        var result = Candy(ratings);

        var expected = 13;

        Console.WriteLine("Candy Success: " + (result == expected));
    }

    private static int Candy(int[] ratings) {
        var candies = 0;//ratings.Length;
        var candyArr = new int[ratings.Length];

        for (int i = 0; i < ratings.Length; i++){
            candyArr[i] = 1;
        }

        for (int i = 1; i < ratings.Length; i++){
            if (ratings[i] > ratings[i-1])
                candyArr[i] = candyArr[i-1] + 1;
        }

        for (int i = ratings.Length - 2; i >= 0; i--){
            if (ratings[i] > ratings[i+ 1]){
                candyArr[i] = Math.Max(candyArr[i], candyArr[i+1] + 1);
            }
        }

        for (int i = 0; i < ratings.Length; i++){
            candies += candyArr[i];
        }

        return candies;
    }
}
