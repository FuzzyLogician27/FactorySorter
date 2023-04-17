using FactorySorterApp.Models;

namespace FactorySorterTests;

public class BubbleSortTests
{

    [TestCase(5,5)]
    [TestCase(5, 9)]
    [TestCase(50, -1)]
    public void GivenArrayGenerator12_WhenBubbleSort_ReturnCorrectSortedArray(int length, int seed)
    {
        var AG1 = new ArrayGenerator(length, seed);
        var AG2 = new ArrayGenerator(length, seed);
        var bubbleSort = new Bubble(AG2);
        int[] expectedResult = AG1.SortableArray;
        Array.Sort(expectedResult);
        bubbleSort.Sort();
        int[] actualResult = AG2.SortableArray;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}