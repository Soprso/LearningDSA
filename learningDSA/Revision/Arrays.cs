using System;

namespace Revision;

public partial class Arrays
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = m - 1;        // pointer in nums1
        int p2 = n - 1;        // pointer in nums2
        int p = m + n - 1;     // position to fill in nums1

        while (p1 >= 0 && p2 >= 0)
        {
            if (nums1[p1] > nums2[p2])
            {
                nums1[p--] = nums1[p1--];
            }
            else
            {
                nums1[p--] = nums2[p2--];
            }
        }

        // If nums2 still has elements, copy them
        while (p2 >= 0)
        {
            nums1[p--] = nums2[p2--];
        }

    }

    public int SingleNumber(int[] nums)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach (int i in nums)
        {
            if (map.ContainsKey(i))
            {
                map[i]++;
            }
            else
            {
                map[i] = 1;
            }
        }
        foreach (var kvp in map)
        {
            if (kvp.Value == 1)
            {
                return kvp.Key;
            }
        }
        return 0;
    }

   

}
