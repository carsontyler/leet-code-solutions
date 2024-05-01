namespace LeetCodeSolutions.ConsoleApp.Problems;

public class TrappingRainWater
{
    public static void Run(){
        var height = new[] {0,1,0,2,1,0,1,3,2,1,2,1};

        var result = Trap(height);

        var expected = 6;

        Console.WriteLine("Trapping Rain Water Success: " + (result == expected));

    }

    private static int Trap(int[] height) {

        var right = new int[height.Length];
        var left = new int[height.Length];
        var localMax = 0;

        for (int i = 0; i < height.Length; i++){
            left[i] = localMax;

            if (height[i] > localMax)
                localMax = height[i];
        }

        localMax = 0;

        for (int i = height.Length - 1; i >= 0; i--){
            right[i] = localMax;

            if (height[i] > localMax)
                localMax = height[i];
        }

        var water = 0;

        for (int i = 0; i < height.Length; i++){
            var collected = Math.Min(right[i], left[i]) - height[i];

            if (collected > 0)
                water += collected;
        }

        return water;
    }
}
