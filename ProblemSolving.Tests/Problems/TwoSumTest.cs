using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving.Problems;

namespace ProblemSolving.Tests.Problems
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void Solve()
        {
            var result = TwoSum.Solve(new int [] {2,7,11,15}, 9);
            Assert.IsTrue(result.Length == 2 && result.Contains(0) && result.Contains(1));
        }
    }
}