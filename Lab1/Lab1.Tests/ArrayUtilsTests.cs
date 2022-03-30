using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Lab1.Tests;

public class ArrayUtilsTests {


	private readonly List<int> numbers;
	private readonly List<int> positiveNumbers;
	private readonly List<int> negativeNumbers;
	private readonly int numbersSum;

	public ArrayUtilsTests() {
		numbers = new List<int> {1, -1, 2, -2, 3, -3, 0};
		positiveNumbers = new List<int> {1, 2, 3,};
		negativeNumbers = new List<int> {-1, -2, -3,};
		numbersSum = 0;
	}

	[Fact]
	public void GetListSum_Succeeds() {
		Assert.Equal(numbersSum, ArrayUtils.GetListSum(numbers));
	}

	[Fact]
	public void SelectPositiveNumbers_Succeeds() {
		Assert.Equal(positiveNumbers, ArrayUtils.SelectPositiveNumbers(numbers).ToList());
	}

	[Fact]
	public void SelectNegativeNumbers_Succeeds() {
		Assert.Equal(negativeNumbers, ArrayUtils.SelectNegativeNumbers(numbers).ToList());
	}

	

}