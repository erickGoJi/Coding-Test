using ProblemTwo;

namespace TestProject;
[TestClass]
public class UnitTest2
{
    [TestMethod]
    public void TestMethodTwoSums_FirstCase()
    {
        // Arrange
        Solution solution = new Solution();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        // Act
        var result = solution.TwoSum(nums, target);
        // Act 
        var expected = new int[] { 0, 1 };
        // Assert
        Assert.IsTrue(result.SequenceEqual(expected));
    }
    
    [TestMethod]
    public void TestMethodTwoSums_SecondCase()
    {
        // Arrange
        Solution solution = new Solution();
        int[] nums = { 3, 2, 4 };
        int target = 6;
        // Act
        var result = solution.TwoSum(nums, target);
        // Act 
        var expected = new int[] { 1, 2 };
        // Assert
        Assert.IsTrue(result.SequenceEqual(expected));
    }
    
    [TestMethod]
    public void TestMethodTwoSums_ThirdCase()
    {
        // Arrange
        Solution solution = new Solution();
        int[] nums = { 3, 3 };
        int target = 6;
        // Act
        var result = solution.TwoSum(nums, target);
        // Act 
        var expected = new int[] { 0, 1 };
        // Assert
        Assert.IsTrue(result.SequenceEqual(expected));
    }
    
    [TestMethod]
    public void Test_TwoSum_WithDifferentInput()
    {
        // Arrange
        Solution solution = new Solution();
        int[] nums = { 3, 2, 4 };
        int target = 6;
        // Act
        int[] result = solution.TwoSum(nums, target);
        // Assert
        int[] expected = { 1, 2 };
        Assert.IsTrue(result.SequenceEqual(expected));
    }
}