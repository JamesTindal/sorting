using System.Diagnostics;

int[] array = [4, 1, 5, 2, 3];
var timer = new Stopwatch();

timer.Start();
WeirdSort(array);
timer.Stop();

Console.WriteLine($"Timer: {timer.Elapsed}");
Console.WriteLine($"Final: {string.Join(", ", array)}");

static void WeirdSort(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        for (var j = 0; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                (array[i], array[j]) = (array[j], array[i]);
            }

            Console.WriteLine($"Step {i},{j}: {string.Join(", ", array)}");
        }
    }
}