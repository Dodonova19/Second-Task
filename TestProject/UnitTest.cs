using Microsoft.VisualStudio.TestTools.UnitTesting;
using Second_Task;

namespace TestProject
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void SolveTestFirst()
        {
            int n = 99;

            long i = Logic.Solve(n);

            Assert.AreEqual(100, i);
        }

        [TestMethod]
        public void SolveTestSecond()
        {
            int n = 1;

            long i = Logic.Solve(n);

            Assert.AreEqual(4, i);
        }
    }
}
