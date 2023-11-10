using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AT_ExtraAssign;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calcultion c;
        int expected, actual;
        [TestInitialize]//thiet lap du lieu chung cho test case
        public void Init()
        {
            c = new Calcultion(10, 5);
        }

        [TestMethod] //TC1: a = 10 b = 5, kq = 15
        public void Test_Cong()
        {
            expected = 15;
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC2: a = -20 b = -7, kq = -13
        public void Test_Tru()
        {
            c = new Calcultion(-20, -7);
            expected = -13;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC3: a = 6 b = 9, kq = 54
        public void Test_Nhan()
        {
            c = new Calcultion(6, 9);
            expected = 54;
            actual = c.Execute("*");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC4: a = 35 b = 5, kq = 7
        public void Test_Chia()
        {
            c = new Calcultion(35, 5);
            expected = 7;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC5: a = 6 b = 0, kq = error
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero()
        {
            c = new Calcultion(6, 10);
            actual = c.Execute("/");
            Assert.Fail("Ngoai le khong xay ra");
        }

       
        public TestContext TestContext { get; set; }//lay du lieu tu file
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]//nguon du lieu
        [TestMethod]// TC6: voi du lieu tu file
        public void Test_Cong_WithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString()); 

            Calcultion c = new Calcultion(a, b);
            int actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\DataTest_CotToanTu.csv", "DataTest_CotToanTu#csv", DataAccessMethod.Sequential)]//nguon du lieu
        [TestMethod]// TC7: voi du lieu tu file
        public void Test_ToanTu_WithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string Operator = TestContext.DataRow[2].ToString().Remove(0,1);//remove ky tu ' khoi Operator
            int expected = int.Parse(TestContext.DataRow[3].ToString());

            c = new Calcultion(a, b);
            int actual = c.Execute(Operator);
            Assert.AreEqual(expected, actual);
        }
    }
}
