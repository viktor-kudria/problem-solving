using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving.Problems;

namespace ProblemSolving.Tests.Problems
{
    [TestClass]
    public class ThreeSumTest
    {
        [TestMethod]
        public void BruteForce()
        {
            var input = new int[] {-1,0,1,2,-1,-4};
            var expected = new List<IList<int>>() 
                {
                    new List<int>(){-1,-1,2},
                    new List<int>(){-1,0,1}
                };

            var output = ThreeSum.BruteForce(input);
        }

        [TestMethod]
        [DataRow(new int[] {-1,0,1,2,-1,-4})]
        [DataRow(new int[] {0,0,0})]
        [DataRow(new int[] {0,0,0,0})]
        [DataRow(new int[] {3,0,-2,-1,1,2})]
        public void BruteForceWithHash(int[] input)
        {
            var output = ThreeSum.BruteForceWithHash(input);
            output = ThreeSum.BruteForceWithHash(input);
        }
    }
}