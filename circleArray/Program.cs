using System;

class circleArray 
{
    static void Main()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
        int position = 3;

        Console.Write("Original Array: ");
        Console.WriteLine(string.Join(", ", array));

        var result = circle(array, position);
        Console.Write("Array after circle from {0} position: ", position);
        Console.Write(string.Join(" ", result));
    }
    static int[] circle(int[] arr, int position)
    {
        int size = arr.Length;
        int[] resArr = new int[size];
        int tempI = 0;
        for (int i = position; i < size + position; i++)
        {
            resArr[tempI++] = arr[(i % size)];
        }
        return resArr;
    }
}