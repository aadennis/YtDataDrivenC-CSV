using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YTDemo;

namespace CalculatorTest {

	[TestClass]
	public class CalculatorTest {
		private TestContext testContextInstance;

		public TestContext TestContext {
			get { return testContextInstance; }
			set { testContextInstance = value; }
		}

		[TestMethod]
		[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
			"|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential),
			DeploymentItem("data.csv")]
		public void Adding2NumbersReturnsTheSum() {
			var calc = new Calculator();

			var number1 = Int32.Parse(TestContext.DataRow["number1"].ToString());
			var number2 = Int32.Parse(TestContext.DataRow["number2"].ToString());
			var expectedSum = Int32.Parse(TestContext.DataRow["sum"].ToString());

			var actualresult = calc.Add(number1, number2);
			Assert.AreEqual(expectedSum, actualresult);


		}
	}
}
