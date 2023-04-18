using FactorySorterApp.Controller;
using FactorySorterApp.Models;
using System.Diagnostics;

namespace FactorySorterApp.View;

public class Program
{
    private static List<string> _validSorts = new List<string> { "standard", "bubble", "merge", "quick" };
    static void Main()
    {
        Console.WriteLine("================================================");
        Console.WriteLine("Welcome to the PAJID Sorting Factory!");
        IntroText();
        View();

        bool repeat = true;
        while (repeat)
        {
            Console.WriteLine("Would you like to try the Factory again? (y/n)");
            string? userInput = Console.ReadLine().ToLower();
            if (userInput.Equals("y"))
            {
                Console.WriteLine("Welcome BACK to the JAPID Sorting Factory!");
                IntroText();
                View();
            }
            else if (userInput.ToLower().Equals("n"))
            {
                Console.WriteLine("========================================================");
                Console.WriteLine("Thank you for visiting the PAJID Sorting Factory! GG WP");
                Console.WriteLine("========================================================");
                repeat = false;
            }
            else
            {
                Console.WriteLine("Invalid response.");
            }
        }
    }

    private static void View() 
    {
        string? sortingMethod = Console.ReadLine();
        bool validSort = false;
        while (!validSort)
        {
            if (_validSorts.Contains(sortingMethod))
            {
                validSort = true;
            }
            else
            {
                Console.WriteLine("Not a valid option, please try again:");
                sortingMethod = Console.ReadLine();
            }
        }
        Console.WriteLine("Please enter an array length:");
        string? userInput = Console.ReadLine();

        bool inputValid = int.TryParse(userInput, out int num);
        while (!inputValid)
        {
            Console.WriteLine("Expected integer, please try again:");
            userInput = Console.ReadLine();
            inputValid = int.TryParse(userInput, out num);
        }

        Console.WriteLine($"You entered {num}");
        ArrayGenerator arr = new ArrayGenerator(num);
        Console.WriteLine($"Unsorted array: {arr.ToString()}");

        Stopwatch stopWatch = new Stopwatch(); 
        stopWatch.Start();
        SortFactory.ChosenSort(sortingMethod, arr);
        stopWatch.Stop();

        Console.WriteLine($"Your sorted array is: {arr.ToString()}");
        Console.WriteLine($"Time taken: {stopWatch.ElapsedTicks/100}ns");
    }

    private static void IntroText() 
    {
        Console.WriteLine("================================================");
        Console.WriteLine("Please choose a sorting method listed below:");
        Console.WriteLine("- DotNetSort : 'standard'");
        Console.WriteLine("- BubbleSort : 'bubble'");
        Console.WriteLine("- MergeSort : 'merge'");
        Console.WriteLine("- QuickSort : 'quick'");
    }
}