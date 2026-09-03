namespace Sorting.Sorts;

public static class Bubble
{
    public static void Sort(int[] array)
    {
        var finished = false;
        while (!finished)
        {
            finished = true;
            for (var i = 0; i < array.Length - 1; i++)
                if (array[i] > array[i + 1])
                {
                    (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    finished = false;
                }
        }
    }
}