using System;

public class Array
{
  public static void Main()
  {
    int[] A = {1,2,3,4,5,6,7,8,9,10};

    int x = 8;

    int p = BinarySearch(x, A, 0, A.Length);

    Console.WriteLine("[{0}] is in position: {1}", x, p);
  }
      
  public static int BinarySearch(int x, int[] arr, int l, int r)
  {
    /* Encontra o elemento do meio. */
    int m = (l+r)/2;

    /* Caso encontrar o elemento, retorne-o. */
    if(arr[m] == x) return m;

    /* Caso o elemento seja maior que o elemento do meio, faça */
    if(x > arr[m]) return BinarySearch(x, arr, m+1, r);

    /* Caso o elemento seja menor que o elemento do meio, faça */
    if(x < arr[m]) return BinarySearch(x, arr, l, m);

    /* Caso não encontre. */
    return -1;
  }
}
