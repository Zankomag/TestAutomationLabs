using System.Reflection.Metadata.Ecma335;

namespace Lab1; 

public class Task9 {

	public static bool Contains<T>(IEnumerable<T> list, T objectToFind) => list.Contains(objectToFind);

	public static bool Contains(string text, string stringToSearch) => text.Contains(stringToSearch);

	public static void ArrayCallback(IEnumerable<string> items, ICallback callback) {
		foreach(var item in items) {
			callback.CallbackFunction(item);
		}
	}

	public static void StringCallback(string text, ICallback callback) {
		callback.CallbackFunction(text.Split(' '));
	}

}


public interface ICallback {

	public void CallbackFunction(params string[] args){ }

}


public interface IConsole {

	public void Write(string value);

}


public class Person {

	public Person(string firstName, string lastName, IConsole console) {
		this.FirstName = firstName;
		this.LastName = lastName;
		this.Console = console;
	}

	public string FirstName { get; init; }
	public string LastName { get; init; }
	private IConsole Console { get; init; }
	
	public void Introduce() => Console.Write($"Hello, I'm {FirstName} {LastName}");

}