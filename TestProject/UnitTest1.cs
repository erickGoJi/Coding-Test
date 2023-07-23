using System.Collections;
using System.Collections.Generic;
using ProblemOne;

namespace TestProject;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethodFindMissing_FirstCase()
    {
        // Arrange
        Solution solution = new Solution();
        int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
        // Expected Result
        IList<int>  expected = new List<int> { 5, 6 };
        // Act 
        IList<int>  actual = solution.FindMissing(nums);
        // Assert
        CollectionAssert.AreEqual((ICollection)expected, (ICollection)actual);
    }
    
    [TestMethod]
    public void TestMethodFindMissing_SecondCase()
    {
        // Arrange
        Solution solution = new Solution();
        int[] nums = { 1, 1 };
        // Expected Result
        IList<int>  expected = new List<int> { 2 };
        // Act 
        IList<int>  actual = solution.FindMissing(nums);
        // Assert
        CollectionAssert.AreEqual((ICollection)expected, (ICollection)actual);
    }
    
    [TestMethod]
    public void TestFindMissing_NoMissingNumbers() {
        // Arrange
        Solution solution = new Solution();
        int[] nums = {1, 2, 3, 4, 5, 6, 7, 8};
        // Expected result
        IList<int> expected = new List<int>();
        // Act
        IList<int> actual = solution.FindMissing(nums);
        // Assert
        CollectionAssert.AreEqual((ICollection)expected, (ICollection)actual);
    }
}