using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving.Problems;

namespace ProblemSolving.Tests.Problems
{
    [TestClass]
    public class PalindromeNumberTest
    {
        [TestMethod]
        [DataRow(1001, true)]
        [DataRow(1230321, true)]
        [DataRow(100, false)]
        [DataRow(123456, false)]
        [DataRow(-123456, false)]
        [DataRow(9, true)]
        public void Solve(int input, bool result)
        {
            Assert.AreEqual(PalindromeNumber.IsPalindrome(input), result);
        }
    }
}