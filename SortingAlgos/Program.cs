using SortingAlgos;
using System.Diagnostics;

Stopwatch stopwatch = Stopwatch.StartNew();
FakeItem[] tacos = new FakeItem[100];

for (int i = 0; i < tacos.Length; i++)
{
    tacos[i] = new FakeItem();
}

tacos = Sort<FakeItem>.BubbleSort(tacos, tacos.Length);

foreach (var item in tacos)
{
    Console.WriteLine(item.RandomNumber);
}

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