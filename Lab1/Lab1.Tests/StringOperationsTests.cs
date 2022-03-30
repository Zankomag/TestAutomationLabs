using Xunit;

namespace Lab1.Tests;

public class StringOperationsTests {

	[Theory]
	[InlineData("aba", true)]
	[InlineData("qwertrewq", true)]
	[InlineData("dfgrer", false)]
	public void IsPalindrome_Succeeds(string value, bool result) {
		Assert.Equal(result, StringOperations.IsPalindrome(value));
	}

	[Theory]
	[InlineData("aba", "baa", true)]
	[InlineData("aba", "aab", true)]
	[InlineData("aba", "aba", true)]
	[InlineData("aba", "bba", false)]
	[InlineData("aba", "baaa", false)]
	public void IsAnagram_Succeeds(string a, string b, bool result) {
		Assert.Equal(result, StringOperations.IsAnagram(a, b));
	}
	

}