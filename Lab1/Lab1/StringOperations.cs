namespace Lab1; 

public class StringOperations {

	public static bool IsPalindrome(string value) => value.SequenceEqual(value.Reverse());

	public static bool IsAnagram(string a, string b) => a.OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));

}