using ProblemOne;

Solution solution = new Solution();
int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
IList<int> result1 = solution.FindMissing(nums1);
Console.WriteLine("Exercise 1:");
foreach (int num in result1)
{
    Console.WriteLine(num);
}

