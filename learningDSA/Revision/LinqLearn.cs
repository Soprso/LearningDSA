using System;

namespace Revision;

public class LinqLearn
{
    public List<int> FilterEvenNumbers(int[] nums)
    {
        List<int> evenNumbers = nums.Where(num => num % 2 == 0).ToList();

        return evenNumbers;
    }

    public List<int> SquaresOfOddNumbers(int[] nums)
    {
        List<int> squareResult = nums.Where(num => num % 2 != 0)
                                    .Select(num => num * num).ToList();
        return squareResult;
    }

    public List<string> StringsWithMoreThan3Char(string[] strs)
    {
        List<string> moreThan3Letters = strs.Where(s => s.Length > 3).ToList();
        return moreThan3Letters;

    }
    public int[] SortedDescending(int[] nums)
    {
        int[] sortedDesc = nums.Where(n => n % 2 != 0).OrderByDescending(n => n).ToArray();
        return sortedDesc;
    }

    public Dictionary<int, List<string>> GroupWordsByLength(string[] strs)
    {
        Dictionary<int, List<string>> myDict = new Dictionary<int, List<string>>();
        myDict = strs.GroupBy(s => s.Length).ToDictionary(pair => pair.Key, pair => pair.ToList());
        return myDict;
    }

    public Dictionary<string, int> CountWordFreq(string[] strs)
    {
        return strs.GroupBy(s => s).ToDictionary(pair => pair.Key, pair => pair.Count());
    }

    public int[] Top3OddDesc(int[] nums)
    {
        return nums.Where(n => n % 2 != 0).OrderByDescending(n => n).Take(3).ToArray();
    }

    //check if all elements are positive in an array and any element is divisible by 10

    public bool PositiveAndDivisibleBy10(int[] nums)
    {
        return nums.All(n => n > 0) ? nums.Any(n => n % 10 == 0) : false;
    }

    //Boss Challenge 💪:
    // Group numbers by remainder when divided by 3, and return the group with the most elements, sorted in ascending order.
    public int[] BossChallenge(int[] nums)
    {
        return nums.GroupBy(n => n % 3).OrderByDescending(n => n.Count()).First().OrderBy(n => n).ToArray();
    }

    public Dictionary<char,List<string>> GroupStringsByFirstLetter(string[] strs)
    {
        return strs.GroupBy(s => s[0]).ToDictionary(pair => pair.Key, pair => pair.ToList());
    }
}
