using System;

class rotateArray
{
   static void Main()
   {               
      int[] array = new[] { 1, 2, 3, 4, 5 };  
      int shift = 2;

      Console.Write("Array before shift: ");
      Console.WriteLine(string.Join(", ", array));

      var leftResult = left(array, shift);
      Console.Write("Left shift of array by {0} is: ", shift);
      Console.Write(string.Join(", ", leftResult));

      var rightResult = right(array, shift);
      Console.Write("\nRight shift of array by {0} is: ", shift);
      Console.Write(string.Join(", ", rightResult));
   }   
                     
   static int[] left(int[] arr, int shift = 1)
   {
      int size = arr.Length;
      int[] shiftedArr = new int[size];

      for (int i = 0; i < size; i++)
      {
            shiftedArr[i] = arr[(i + shift) % size];
      }
      return shiftedArr;
   }

   static int[] right(int[] arr, int shift = 1)
   {
      int size = arr.Length;
      int[] shiftedArr = new int[size];

      for (int i = 0; i < size; i++)
      {
            shiftedArr[(i + shift) % size] = arr[i];
      }
      return shiftedArr;
   }
} 
