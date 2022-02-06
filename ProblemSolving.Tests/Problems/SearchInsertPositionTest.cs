using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving.Problems;

namespace ProblemSolving.Tests.Problems
{
    [TestClass]
    public class SearchInsertPositionTest
    {
        [TestMethod]
        [DataRow(new int[] {1,3,5,6}, 5, 2)]
        [DataRow(new int[] {1,3,5,6}, 2, 1)]
        [DataRow(new int[] {1,3,5,6}, 7, 4)]
        public void SearchInsert(int[] input, int target, int index)
        {
            Assert.AreEqual(SearchInsertPosition.SearchInsert(input, target), index);
        }
    }
}