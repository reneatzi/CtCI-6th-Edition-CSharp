using System;

namespace VII.Algorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			var arrayToSort = new int[] {2, 5, -4, 11, 0, 18, 22, 67, 51, 6};

			PrintArray(arrayToSort);

			new QuickSort().Sort(arrayToSort);

			PrintArray(arrayToSort);
		}

		private static void PrintArray(int[] arrayToSort)
		{
			Console.WriteLine("Array: ");

			foreach (var item in arrayToSort)
				Console.Write(" " + item);

			Console.WriteLine();
		}
	}
}