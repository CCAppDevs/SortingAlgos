using SortingAlgos;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

Stopwatch stopwatch = Stopwatch.StartNew();

// usage 100 thousand values
stopwatch.Start();
int[] largeArr = GenerateRandomArray(100000000, 1, 1000);
stopwatch.Stop();
DisplayRuntime(stopwatch);


// Write your function to test each algorithm here
Console.WriteLine("Starting the sort");
stopwatch.Restart();
largeArr = Sort.MergeSortAlgorithm(largeArr, largeArr.Length - 1);
stopwatch.Stop();
DisplayRuntime(stopwatch);


Console.WriteLine("Press any key to continue");
Console.ReadLine();

// find the item
Console.WriteLine("Starting the search for 999");
stopwatch.Restart();
Console.WriteLine("At index: " + Search.binarySearch(largeArr, 0, largeArr.Length - 1, 999));
stopwatch.Stop();
DisplayRuntime(stopwatch);

Console.WriteLine("Press any key to continue");
Console.ReadLine();


// Write individual functions for each algorithm here (Bubble, Insertion, Merge, and Quick sort)
//for (int i = 0; i < result.Length; i++)
//{
//    Console.WriteLine(result[i]);
//}

// function
static int[] GenerateRandomArray(int length, int minValue, int maxValue)
{
    Random rand = new Random();
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(minValue, maxValue); // Generates a random integer within the specified range
    }

    return array;
}

static void DisplayRuntime(Stopwatch stopwatch)
{
    TimeSpan ts = stopwatch.Elapsed;


    // Format and display the TimeSpan value.
    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
        ts.Hours, ts.Minutes, ts.Seconds,
        ts.Milliseconds / 10);
    Console.WriteLine("Time Taken: " + elapsedTime);
}