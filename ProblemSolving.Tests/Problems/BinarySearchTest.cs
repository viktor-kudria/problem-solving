using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving.Problems;

namespace ProblemSolving.Tests.Problems
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        [DataRow(new int[] {1,2,3,4,5}, 4, 3)]
        [DataRow(new int[] {1,2,3,4}, 1, 0)]
        [DataRow(new int[] {1,2,3,4}, -1, -1)]
        [DataRow(new int[] {-1,0,3,5,9,12}, 9, 4)]
        [DataRow(new int[] {-1,0,3,5,9,12}, 2, -1)]
        public void Search(int[] nums, int target, int index)
        {
            Assert.AreEqual(BinarySearch.Search(nums, target), index);
        }
    }
}