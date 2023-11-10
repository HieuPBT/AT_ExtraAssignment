using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Recursion;
namespace RecursionTester
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]//nguon du lieu
        [TestMethod]//TC tu du lieu file
        public void RecurionTest()
        {
            double x = double.Parse(TestContext.DataRow[0].ToString());
            int n = int.Parse(TestContext.DataRow[1].ToString());
            double expected = double.Parse(TestContext.DataRow[2].ToString());
            double actual = Recursion.RecursionCalculation.Power(x, n);
            Assert.AreEqual(expected, actual);
        }
    }
}
