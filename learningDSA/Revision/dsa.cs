using System;
using System.Data;

namespace Revision;

public class dsa
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int sum = (n + 1) * (n + 2) / 2;
        foreach (int i in nums)
        {
            sum -= i;
        }
        return sum;
    }

    public int MaxProfit(int[] prices)
    {
        int MaxProfit = 0;
        int MinSoFar = prices[0];
        int profit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < MinSoFar)
            {
                MinSoFar = prices[i];
            }
            profit = prices[i] - MinSoFar;
            MaxProfit = Math.Max(profit, MaxProfit);
        }
        return MaxProfit;
    }

    public int[] TwoSum(int[] nums, int tar)
    {
        Dictionary<int, int> res = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int compliment = tar - nums[i];
            if (res.ContainsKey(compliment))
            {
                return new int[] { i, res[compliment] };
            }
            if (!res.ContainsKey(nums[i]))
            {
                res.Add(nums[i], i);
            }
        }
        return Array.Empty<int>();
    }

    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (freq.ContainsKey(c))
            {
                freq[c]++;
            }
            else
            {
                freq[c] = 1;
            }
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (freq[s[i]] == 1)
            {
                return i;
            }
        }
        return -1;
    }


}
