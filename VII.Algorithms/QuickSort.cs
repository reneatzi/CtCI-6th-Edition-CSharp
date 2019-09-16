using VII.Algorithms.Interfaces;

namespace VII.Algorithms
{
	public class QuickSort : ISort
	{
		public void Sort(int[] arrayToSort)
		{
			Sort(arrayToSort, 0, arrayToSort.Length - 1);
		}


		private static void Sort(int[] arrayToSort, int lowIndex, int highIndex)
		{
			if (lowIndex < highIndex)
			{
				var pivot = Partition(arrayToSort, lowIndex, highIndex);

				if (pivot > 1)
					Sort(arrayToSort, lowIndex, pivot - 1);

				if (pivot + 1 < highIndex)
					Sort(arrayToSort, pivot + 1, highIndex);
			}
		}

		private static int Partition(int[] arrayToSort, int lowIndex, int highIndex)
		{
			// Initially set pivot to the first value of the array
			var pivot = arrayToSort[lowIndex];

			while (true)
			{
				// Search from left to right for the first value that is greater or equal than the pivot
				while (arrayToSort[lowIndex] < pivot)
					lowIndex++;

				// Search from right to left for the first value that is lower or equal than the pivot
				while (arrayToSort[highIndex] > pivot)
					highIndex--;

				if (lowIndex < highIndex)
				{
					if (arrayToSort[lowIndex] == arrayToSort[highIndex])
						return highIndex;

					// Swap values
					var tempValue = arrayToSort[lowIndex];

					arrayToSort[lowIndex] = arrayToSort[highIndex];
					arrayToSort[highIndex] = tempValue;
				}
				else
				{
					return highIndex;
				}
			}
		}
	}
}