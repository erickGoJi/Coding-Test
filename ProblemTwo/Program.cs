using ProblemTwo;

Solution solution = new Solution();
int[] nums = {0,4,3,0};
int target = 0;
var result1 = solution.TwoSum(nums, target);
Console.WriteLine("Exercise 2:");
Console.WriteLine(string.Join(", ", result1));