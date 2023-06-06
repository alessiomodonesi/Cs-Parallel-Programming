// Create an array of numbers
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Parallelize the processing of the numbers using Parallel.For
Parallel.For(0, numbers.Length, i =>
{
    // Perform some computation on each number
    int result = ComputeSquare(numbers[i]);

    // Display the result with a thread-safe output
    lock (Console.Out)
    {
        Console.WriteLine("Computed square of {0} = {1}", numbers[i], result);
    }
});

Console.ReadLine();

static int ComputeSquare(int number)
{
    // Simulate some time-consuming computation
    Task.Delay(1000).Wait();

    // Compute the square of the number
    int square = number * number;

    return square;
}