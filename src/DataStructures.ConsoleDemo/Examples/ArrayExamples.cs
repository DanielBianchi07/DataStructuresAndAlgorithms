using System.Collections;
using DataStructures.Collections;

namespace DataStructures.ConsoleDemo.Examples;

public class ArrayExamples
{
    public static void Run()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("--------- ArrayExamples ----------");
        
        Arrays nums = new Arrays(10);
        
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            nums.Insert((int)(rand.NextDouble() * 100));
        }
        nums.DisplayElements();
        
        // nums.BubbleSort();
        // nums.SelectionSort();
        nums.InsertionSort();
    }
}