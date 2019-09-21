using VII.Algorithms.Interfaces;

namespace VII.Algorithms
{
	public class BubbleSort : ISort
	{
		public void Sort(int[] arrayToSort)
		{
			var isUnsorted = true;

			while (isUnsorted)
			{
				isUnsorted = false;

				for (var i = 0; i < arrayToSort.Length - 1; i++)
				{
					if (arrayToSort[i] > arrayToSort[i + 1])
					{
						SwapValues(arrayToSort, i, i + 1);
						isUnsorted = true;
					}
				}
			}
		}

		private void SwapValues(int[] arrayToSort, int i, int j)
		{
			var tempValue = arrayToSort[i];

			arrayToSort[i] = arrayToSort[j];
			arrayToSort[j] = tempValue;
		}
	}
}