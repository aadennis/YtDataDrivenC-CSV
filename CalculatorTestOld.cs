using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YTDemo;

namespace CalculatorTest {

	[TestClass]
	public class CalculatorTestOld {
	
		[TestMethod]
		public void Adding2PositiveNumbersReturnsTheSum() {
			var calc = new Calculator();

			var number1 = 55;
			var number2 = 22;
			var expectedSum = 771;
			var actualresult = calc.Add(number1, number2);
			Assert.AreEqual(expectedSum, actualresult);
		}

		[TestMethod]
		public void Adding2NegativeNumbersReturnsTheSum() {
			var calc = new Calculator();

			var number1 = -55;
			var number2 = -33;
			var expectedSum = -881;
			var actualresult = calc.Add(number1, number2);
			Assert.AreEqual(expectedSum, actualresult);
		}

		[TestMethod]
		public void Adding1NegativeAnd1PositiveNumbersReturnsTheSum() {
			var calc = new Calculator();

			var number1 = -3;
			var number2 = 7;
			var expectedSum = 41;
			var actualresult = calc.Add(number1, number2);
			Assert.AreEqual(expectedSum, actualresult);
		}
	}


}
