namespace FactorySorterApp.Models;

public class ArrayGenerator
{

    public int[] SortableArray { get; set; }

    public ArrayGenerator(int arrayLength)
    {
        if(arrayLength < 1)
        {
            throw new ArgumentException("Array length cannot be less than 1!");
        }
        SortableArray = new int[arrayLength];
        GenerateRandomArray();
    }

    private void GenerateRandomArray()
    {
        var rand = new Random();
        for (int i = 0; i < SortableArray.Length; i++)
        {
            SortableArray[i] = rand.Next(-1000, 1001);
        }
    }

    public override string ToString()
    {
        string message = "{";

        for(int i = 0; i < SortableArray.Length; i++)
        {
            message += SortableArray[i];
            if(i != (SortableArray.Length - 1))
            {
                message += ",";
            }
        }
        message += "}";
        return message;
    }

}
