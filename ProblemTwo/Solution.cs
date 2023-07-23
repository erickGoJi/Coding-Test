namespace ProblemTwo;

public class Solution
{
    public int[] TwoSum(int[] nums, int target) {
        // Create an Array to store the index
        var res = new int[] { };
        
        for (var i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            // Get the Index of the target value in the array
            int position = Array.IndexOf(nums, complement);
            // If Array.IndexOf returns -1 the value not found in the array   
            if (position != -1)
            {
                res = new []{ position, i };
            }
        }

        return res;
    }
}