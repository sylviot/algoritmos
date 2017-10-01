using System;
using System.Collections.Generic;

class Sort
{
  static void Main()
  {
    int[] unsorted = new int[]{2,3,1,5,4};
    int[] sorted = Merge(unsorted);
    
    foreach(var item in sorted)
    {
      Console.WriteLine(item);
    }
  }

  /* Método utilizado para envelopar a função (wrapper) */
  static int[] Merge(int[] array)
  {
    return Merge(array, 0, array.Length - 1);
  }

  static int[] Merge(int[] array, int left, int right)
  {
    if(left >= right) return array;

    int middle = (left + right) / 2;
    Merge(array, left, middle);
    Merge(array, middle + 1, right);
    MergeHalves(array, new int[array.Length], left, middle, right);

    return array;
  }

  static void MergeHalves(int[] array, int[] temp, int low, int middle, int high)
  {
    int left = low;
    int right = middle + 1;
    int index = 0;
    int size = high - low + 1;

    while(left <= middle && right <= high)
    {
      if(array[left] <= array[right])
      {
        temp[index] = array[left];
        left++;
      }
      else
      {
        temp[index] = array[right];
        right++;
      }

      index++;
    }

    while(left<=middle) temp[index++] = array[left++];
    while(right<=high) temp[index++] = array[right++];

    for(int i = 0; i < size;i++)
    {
      array[i+low] = temp[i]; 
    }
  }
}
