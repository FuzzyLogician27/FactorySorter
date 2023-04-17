using FactorySorterApp.Models;
using NUnit.Framework;

namespace FactorySorterTests
{
    public class MergeSortTest
    {
        private ArrayGenerator? _standardSolvedArray;
        private ArrayGenerator? _customAgloArray;

        [TestCase(5, 5)]
        [TestCase(2, 10)]
        [TestCase(10, 2)]
        [TestCase(1, 100)]
        public void GivenArrayGenerator_WhenMergeSort_ReturnsCorrectSortedArray(int a, int b) 
        {
            _standardSolvedArray = new ArrayGenerator(a, b);
            _customAgloArray = new ArrayGenerator(a, b);
            int[] expectedResult = _standardSolvedArray.SortableArray;
            Array.Sort(expectedResult);
            var mergeSort = new Merge(_customAgloArray);
            mergeSort.Sort();
            int[] actualResult = _customAgloArray.SortableArray;
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
