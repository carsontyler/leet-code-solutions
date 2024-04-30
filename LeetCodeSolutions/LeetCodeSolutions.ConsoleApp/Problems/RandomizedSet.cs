namespace LeetCodeSolutions.ConsoleApp.Problems;

public class RandomizedSet
{
    public static void Run()
    {
        var obj = new RandomizedSetObject();
        var success1 = obj.Insert(1) == true;
        var success2 = obj.Remove(2) == false;
        var success3 = obj.Insert(2) == true;
        var random1 = obj.GetRandom();
        var success4 = (random1 == 1) || (random1 == 2);
        var success5 = obj.Remove(1) == true;
        var success6 = obj.Insert(2) == false;
        var random2 = obj.GetRandom();
        var success7 = random2 == 2;

        var success = success1 && success2 && success3 && success4 && success5 && success6 && success7;

        Console.WriteLine("Randomized Set Success: " + success);
    }
}

class RandomizedSetObject
{

    private readonly List<int> _set;
    private readonly Dictionary<int, int> _dict;

    public RandomizedSetObject()
    {
        _set = new List<int>();
        _dict = new Dictionary<int, int>();
    }

    public bool Insert(int val)
    {
        if (_dict.ContainsKey(val))
            return false;

        _set.Add(val);
        _dict.Add(val, _set.Count - 1);

        return true;
    }

    public bool Remove(int val)
    {
        if (_dict.ContainsKey(val))
        {
            _set.Remove(val);
            _dict.Remove(val);
            return true;
        }
        return false;
    }

    public int GetRandom()
    {
        Random rnd = new Random();
        int r = rnd.Next(_set.Count);
        return _set[r];
    }
}