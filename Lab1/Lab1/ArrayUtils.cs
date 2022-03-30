namespace Lab1; 

public class ArrayUtils {

	public static int GetListSum(IEnumerable<int> list) => list.Sum();
	
	public static IEnumerable<int> SelectPositiveNumbers(IEnumerable<int> list) => list.Where(x => x > 0);
	
	public static IEnumerable<int> SelectNegativeNumbers(IEnumerable<int> list) => list.Where(x => x < 0);
	

}