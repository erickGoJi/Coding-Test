using System.Collections;

namespace ProblemOne;

public class Solution
{
    // Use a HasSet to store the numbers from array nums
    // Iterate from 1 to the length of the nums list and check which numbers are missing by checking if they are not in the HashSet
    public IList<int> FindMissing(int[] nums)
    {
        int n = nums.Length;
        HashSet<int> numSet = new HashSet<int>(nums);
        List<int> missingNums = new List<int>();
        for (var i = 1; i <= n; i++)
        {
            if (!numSet.Contains(i))
            {
                missingNums.Add(i);
            }
        }

        return missingNums;
    }
}