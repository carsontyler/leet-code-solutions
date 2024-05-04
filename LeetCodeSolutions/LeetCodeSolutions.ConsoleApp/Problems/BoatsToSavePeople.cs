namespace LeetCodeSolutions.ConsoleApp.Problems;

public class BoatsToSavePeople
{
    public static void Run(){
        var people = new[] {21,40,16,24,30};
        var limit = 50;

        var result = NumRescueBoats(people, limit);

        var expected = 3;

        Console.WriteLine("Boats to Save People Success: " + (result == expected));
    }

    private static int NumRescueBoats(int[] people, int limit) {
        var boats = 0;
        Array.Sort(people);
        int i = 0, j = people.Length - 1;

        while (i <= j){
            if (i == j){
                boats++;
                break;
            }
            if (people[i] + people[j] <= limit){
                boats++;
                i++;
                j--;
                continue;
            }
            else {
                boats++;
                j--;
                continue;
            }
        }

        return boats;
    }
}
