using System;

class Program
{
    static void Main()
    {
        int[] array = new int[5];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = GetUserDefinedValue(i + 1);
            Console.WriteLine($"Element {i + 1}: {array[i]}");
        }

        int largestElement = FindLargestElement(array);
        Console.WriteLine($"The largest element in the array is: {largestElement}");
    }

    static int GetUserDefinedValue(int n)
    {
        return n * n;
    }

    static int FindLargestElement(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}