using FactorySorterApp.Models;
namespace FactorySorterTests;

internal class ArrayGeneratorTest
{
    [TestCase(1)]
    [TestCase(3)]
    [TestCase(5)]
    public void GivenInteger_WhenArrayGenerator_ReturnAGContainingArrayOfLength(int length)
    {
        ArrayGenerator aG = new ArrayGenerator(length);
        Assert.That(length, Is.EqualTo(aG.SortableArray.Length));
    }

    [TestCase(0)]
    [TestCase(-30)]
    public void GivenANegativeInteger_WhenArrayGenerator_ThrowsArgumentException(int length)
    {
        Assert.That(() => new ArrayGenerator(length), Throws.TypeOf<ArgumentException>().With.Message.Contain("Array length cannot be less than 1!"));
    }

    [TestCase(1)]
    [TestCase(10)]
    [TestCase(20)]
    public void GivenInteger_WhenArrayGenerator_ArrayMembersInRange(int length)
    {
        ArrayGenerator aG = new ArrayGenerator(length);
        foreach(int i in aG.SortableArray)
        {
            Assert.That(i, Is.AtMost(1000));
            Assert.That(i, Is.AtLeast(-1000));
        }
    }

}
