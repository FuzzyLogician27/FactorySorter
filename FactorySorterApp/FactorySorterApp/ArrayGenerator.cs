﻿namespace FactorySorterApp;

public class ArrayGenerator
{

    public int[] SortableArray { get; set; }

    public ArrayGenerator(int arrayLength)
    {
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

}
