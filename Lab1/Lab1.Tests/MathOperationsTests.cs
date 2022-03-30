using Xunit;

namespace Lab1.Tests;

public class MathOperationsTests {

	[Theory]
	[InlineData(1, 2, -1)]
	[InlineData(-1, 2, -3)]
	[InlineData(1.5, 2.5,-1)]
	public void Subtract_Succeeds(double a, double b, double result) {
		Assert.Equal(result, MathOperations.Subtract(a, b));
	}

	[Theory]
	[InlineData(1, 2, 2)]
	[InlineData(-1, 2, -2)]
	[InlineData(1.5, 2.5, 3.75)]
	public void Multiply_Succeeds(double a, double b, double result) {
		Assert.Equal(result, MathOperations.Multiply(a, b));
	}

	[Theory]
	[InlineData(1, 2, 0.5)]
	[InlineData(-1, 2, -0.5)]
	[InlineData(1.5, 2.5, 0.6)]
	public void Divide_Succeeds(double a, double b, double result) {
		Assert.Equal(result, MathOperations.Divide(a, b));
	}

	[Theory]
	[InlineData(1, 2, 3)]
	[InlineData(-1, 2, 1)]
	[InlineData(1.5, 2.5, 4)]
	public void Add_Succeeds(double a, double b, double result) {
		Assert.Equal(result, MathOperations.Add(a, b));
	}

}