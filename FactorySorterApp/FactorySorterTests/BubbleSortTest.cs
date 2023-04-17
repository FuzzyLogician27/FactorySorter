using FactorySorterApp.Models;

namespace FactorySorterTests;

public class BubbleSortTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GivenArrayGenerator_WhenBubbleSort_ReturnCorrectSortedArray()
    {
        ArrayGenerator AG = new ArrayGenerator(5);
        int[] expectedResult = AG.SortableArray;
        Array.Sort(expectedResult);
        int[] actualResult = AG.SortableArray;
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }
}