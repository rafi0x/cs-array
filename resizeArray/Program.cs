using System;

class resizeArray
{
	static void Main()
	{
		int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int newSize = 3;

        Console.Write("Original Array: ");
        Console.WriteLine(string.Join(", ", array));

        Console.WriteLine("New size: {0}", newSize);

        var result = resizer(array, newSize);

        Console.Write("Array after resizing: ");
        Console.WriteLine(string.Join(", ", result));
	}
    static int[] resizer(int[] oldArray, int newSize = 1)
        {
            int[] resizedArray = new int[newSize];

            for (int i = 0; i < newSize; i++)
            {
                  resizedArray[i] = oldArray[i];
            }
            return resizedArray;
        }
}
