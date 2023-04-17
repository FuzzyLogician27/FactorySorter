using FactorySorterApp.Models;

namespace FactorySorterTests;

public class StandardTest
{
    [Test]
    public void GivenArrayLength3_StandardSort_ReturnsSortedArray()
    {
        ArrayGenerator array = new(3);
        Standard standard = new(array);
        standard.Sort();
        Assert.That(standard._array.SortableArray, Is.Ordered);
    }
    
    [Test]
    public void GivenArrayLength10_StandardSort_ReturnsSortedArray()
    {
        ArrayGenerator array = new(10);
        Standard standard = new(array);
        standard.Sort();
        Assert.That(standard._array.SortableArray, Is.Ordered);
    }
}