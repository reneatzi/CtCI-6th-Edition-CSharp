using System.Runtime.InteropServices;
using VII.Algorithms.Interfaces;

namespace VII.Algorithms.SortingAlgorithms
{
	public class InsertionSort : ISort
	{
		public void Sort(int[] arrayToSort)
		{
			for (var i = 1; i < arrayToSort.Length; i++)
			{
				var j = i;

				while (j > 0 && arrayToSort[j] < arrayToSort[j - 1])
				{
					Swap(arrayToSort, j, j - 1);
					j--;
				}
			}
		}

		private void Swap(int[] arrayToSort, int i, int j)
		{
			var tempValue = arrayToSort[i];

			arrayToSort[i] = arrayToSort[j];
			arrayToSort[j] = tempValue;
		}
	}
}