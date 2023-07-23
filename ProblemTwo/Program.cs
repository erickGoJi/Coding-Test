using ProblemTwo;

Solution solution = new Solution();
int[] nums = {2,7,11,15};
int target = 9;
var result1 = solution.TwoSum(nums, target);
Console.WriteLine("Example 2:");
Console.WriteLine(string.Join(", ", result1));