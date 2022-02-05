using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemSolving.Tests
{
    [TestClass]
    public class SimpleTest
    {
        [TestMethod]
        public void DoSmthTest()
        {
            Assert.AreEqual(SimpleProblem.DoSmth(), 1);
        }
    }
}