namespace Sorting.Sorts;

public static class Selection
{
    public static void Sort(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            var minIndex = i;
            for (var j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                    minIndex = j;
            }
            (array[i], array[minIndex]) = (array[minIndex], array[i]);
        }
    }
}