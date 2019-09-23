using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VII.Algorithms.SortingAlgorithms;

namespace VII.Algorithms.Tests
{
	[TestClass]
	public class QuickSortTests
	{
		[TestMethod]
		public void TestSimpleArray_Should_ReturnSortedArray()
		{
			var arrayToSort = new[] {5, 3, 1, 4, 7, -7, 50, 2000};

			new QuickSort().Sort(arrayToSort);

			arrayToSort.Should().BeInAscendingOrder();
			arrayToSort.Length.Should().Be(8);
		}

		[TestMethod]
		public void TestArrayWithDuplicates_Should_ReturnSortedArray()
		{
			var arrayToSort = new[] {5, 3, 3, 3, 7, -7, 50, 2000};

			new QuickSort().Sort(arrayToSort);

			arrayToSort.Should().BeInAscendingOrder();
			arrayToSort.Length.Should().Be(8);
		}

		[TestMethod]
		public void TestNegativeOnly_Should_ReturnSortedArray()
		{
			var arrayToSort = new[] {-5, -3, -3, -3, -19234123, -7, -50, -2000};

			new QuickSort().Sort(arrayToSort);

			arrayToSort.Should().BeInAscendingOrder();
			arrayToSort.Length.Should().Be(8);
		}
	}
}