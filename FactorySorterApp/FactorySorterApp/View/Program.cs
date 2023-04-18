using FactorySorterApp.Controller;
using FactorySorterApp.Models;
using System.Diagnostics;

namespace FactorySorterApp.View;

public class Program
{
    static void Main()
    {
        //Greeting
        Console.WriteLine("Hi user!");


        //Prompting user how many numbers to be sorted
        Console.WriteLine("How many numbers?");
        string userInput = "";
        userInput = Console.ReadLine();

        //Checking if input valid. Input must be integer
        int num;
        bool inputValid = int.TryParse(userInput, out num);

        //Repeat until desired input, or cancel program
        while (!inputValid)
        {
            Console.WriteLine("Expected integer. Try again? (y/n)");
            userInput = Console.ReadLine();
            if (userInput.ToLower().Equals("y"))
            {
                Console.WriteLine("Please provide an integer: ");
                userInput = Console.ReadLine();
                inputValid = int.TryParse(userInput, out num);

            } else if (userInput.ToLower().Equals("n"))
            {
                Console.WriteLine("GoodBye!!");
                inputValid = true;
            }
            else
            {
                Console.WriteLine("Invalid response.");

            }
        }


        Console.WriteLine($"You entered {num}");
        ArrayGenerator arr = new ArrayGenerator(num);
        Console.WriteLine($"Unsorted array: {arr.ToString()}");
        Console.WriteLine("Input sort method:");
        bool sortValid = false;
        while (!sortValid)
        {
            try
            {
                string inputString = Console.ReadLine();
            }
            catch (ArgumentException)
            {

            }
        }


        //The timer for sorting algorithm
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        //Put sort call here:


        //Timer stops
        stopWatch.Stop();

        //Prints time elapsed
        Console.WriteLine(stopWatch.ElapsedMilliseconds + " ms");
    }

}