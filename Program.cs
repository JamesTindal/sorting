using Sorting.Sorts;
using System.Diagnostics;

int[] array = [4, 1, 5, 2, 3];
var timer = new Stopwatch();

timer.Start();
// ICantBelieveItCan.Sort(array);
// Bubble.Sort(array);
Selection.Sort(array);
timer.Stop();

Console.WriteLine($"Timer: {timer.Elapsed}");
Console.WriteLine($"Final: {string.Join(", ", array)}");