using System.Collections.Generic;
using System.Linq;
using Moq;
using Xunit;

namespace Lab1.Tests;

public class Task9Tests {

	private readonly Mock<ICallback> callbackMock = new Mock<ICallback>();
	private readonly Mock<IConsole> consoleMock = new Mock<IConsole>();
	
	[Fact]
	public void Contains_Succeeds() {
		var array = Enumerable.Range(1, 10).ToList();
		const string str = "one two three";
		Assert.True(Task9.Contains(array, 5));
		Assert.False(Task9.Contains(array, 11));
		Assert.True(Task9.Contains((string)str, "two"));
		Assert.False(Task9.Contains((string)str, "five"));
		
		
	}

	[Fact]
	public void ArrayCallback_Succeeds() {
		IEnumerable<string> array = new string('a', 5).Select(x => x.ToString());
		
		Task9.ArrayCallback(array, callbackMock.Object);
		
		callbackMock.Verify(x => x.CallbackFunction(It.IsAny<string>()), Times.Exactly(5));
		
	}

	[Fact]
	public void StringCallback_Succeeds() {
		const string wordsString = "one two three";
		var wordsArray = new[] {"one", "two", "three"};

		Task9.StringCallback(wordsString, callbackMock.Object);

		callbackMock.Verify(x => x.CallbackFunction(wordsArray), Times.Once);

	}

	[Fact]
	public void Introduce_Succeeds() {
		Person person = new Person("John", "Smith", consoleMock.Object);
		
		person.Introduce();
		
		consoleMock.Verify(x => x.Write("Hello, I'm John Smith"), Times.Once);
	}
	

}