namespace Sorting.Sorts;

public static class ICantBelieveItCan
{
    public static void Sort(int[] array)
    {
        for (var i = 0; i < array.Length; i++)
            for (var j = 0; j < array.Length; j++)
                if (array[i] < array[j])
                    (array[i], array[j]) = (array[j], array[i]);
    }
}