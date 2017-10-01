using System;
using System.Collections.Generic;
using System.IO;

class QuickSort 
{
  static void Main(String[] args) 
  {
    int[] unsorted = new int[]{2,3,1,5,4};
    int[] sorted = Quick(unsorted);
    
    foreach(var item in sorted)
    {
      Console.WriteLine(item);
    }
  }
  
  // Método utilizado apenas para envelopar a função recursiva (wrapper-function)
  static int[] Quick(int[] array)
  {
    return Quick(array, 0, array.Length - 1);
  }
  
  static int[] Quick(int[] array, int left, int right)
  {
    int index = Partition(array, left, right);
    
    if(left < index - 1) Quick(array, left, index - 1);
    if(index < right) Quick(array, index, right);
    
    return array;
  }
  
  static int Partition(int[] array, int left, int right)
  {
    int i = left,
        j = right,
        pivot = array[(left + right) / 2];
            
    while(i <= j)
    {
      while(array[i] < pivot) i++;
      while(array[j] > pivot) j--;
                    
      if(i <= j)
      {
        Swap(array, i, j);
        i++;
        j--;
      }
    }
            
    return i;
  }
  
  static void Swap(int[] array, int a, int b)
  {
    int aux = array[a];
    array[a] = array[b];
    array[b] = aux;
  }
}
